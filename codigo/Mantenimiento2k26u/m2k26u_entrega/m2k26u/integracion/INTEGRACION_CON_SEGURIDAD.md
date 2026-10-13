# Integración del mantenimiento con el proyecto de Seguridad

> Punto **b.i** del enunciado: *«agregar la referencia del formulario al proyecto de Seguridad
> en el Menú de Mantenimientos o Catálogos»*.

Son cuatro cambios, todos en `CapaVista_Seguridad`. Ninguno toca los otros componentes.

---

## 1. Agregar la referencia a la DLL

En el proyecto **`CapaVista_Seguridad`**: clic derecho en *Referencias* → *Agregar referencia* →
*Examinar* → seleccionar:

```
...\mantenimiento2k26u\Mantenimiento2k26u\CapaVista_Mantenimiento2k26u\bin\Debug\CapaVista_Mantenimiento2k26u.dll
```

Y verificar en las propiedades de la referencia que **Copiar localmente = True**.

> **La dirección de la referencia importa.** `CapaVista_Seguridad` referencia a
> `CapaVista_Mantenimiento2k26u`, nunca al revés. Por eso el mantenimiento resuelve los permisos
> con su propia `ClsPermisosMantenimiento` (que solo consulta `CapaControlador_Seguridad`) en vez
> de usar `ClsSeguridadFormHelper`: si ambos proyectos se referenciaran mutuamente, ninguno de los
> dos compilaría. Es el mismo motivo por el que el componente Navegador tiene su
> `ClsNavegadorPermisos`.

---

## 2. Agregar el botón al menú lateral del MDI

Abrir **`FrmMDISeguridad`** en el diseñador. En el panel lateral `SeguridadPnlNavegador`, copiar
y pegar uno de los botones que ya existen (por ejemplo `SeguridadBtnModulos`) para heredar su
estilo, y cambiarle:

| Propiedad | Valor |
|---|---|
| `(Name)` | `SeguridadBtnPeliculas` |
| `Text`   | `Películas` |

Ubicarlo debajo del último botón del menú.

---

## 3. Registrar el botón en el mapa de permisos del MDI

En **`FrmMDISeguridad.cs`**, dentro de `FrmMDISeguridad_Load`, agregar la última línea del
diccionario (ojo con la coma de la línea anterior):

```csharp
var MapaBotonesMDI = new Dictionary<Control, (int, int)>
{
    { SeguridadBtnEmpleados,(4, 4)},
    { SeguridadBtnUsuarios,(4, 5)},
    { SeguridadBtnModulos,(4, 6)},
    { SeguridadBtnAplicaciones,(4, 7)},
    { SeguridadBtnPerfiles,(4, 8)},
    { SeguridadBtnAsignaPerfiles,(4, 9)},
    { SeguridadBtnAplicaPerfiles,(4, 10)},
    { SeguridadBtnAplicaUsuario,(4, 11)},
    { SeguridadBtnBitacora,(4, 12)},
    { SeguridadBtnPeliculas,(20, 21)}      // <-- Catálogos / Películas
};
ClsSeguridadFormHelper.SeguridadMetAplicarPermisosEnBotonesMDI(MapaBotonesMDI);
```

El par `(20, 21)` es el mismo que inserta el script `dbPeliculas_Mantenimiento2k26u.sql` y el
mismo que llevan las constantes `ID_MODULO` e `ID_APLICACION` del formulario. Si se cambia en un
lado hay que cambiarlo en los tres.

---

## 4. Agregar el manejador del clic

También en **`FrmMDISeguridad.cs`**, junto a los demás manejadores de botones:

```csharp
// Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "13/10/26"
private void SeguridadBtnPeliculas_Click(object sender, EventArgs e)
{
    if (!ClsSeguridadFormHelper.SeguridadMetTieneAcceso(IdModulo: 20, IdAplicacion: 21))
    {
        MessageBox.Show("No tienes acceso a este módulo.",
            "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    CapaVista_Mantenimiento2k26u.FrmMantenimientoPeliculas Peliculas =
        new CapaVista_Mantenimiento2k26u.FrmMantenimientoPeliculas();
    Peliculas.ShowDialog();
}
// Fin de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "13/10/26"
```

Y enlazarlo. Si el botón se creó copiando otro, Visual Studio pudo dejarlo apuntando al manejador
del botón original: hay que verificarlo en *Propiedades* → rayo (*Eventos*) → `Click` y
seleccionar `SeguridadBtnPeliculas_Click`. Si no, el botón Películas abrirá el mantenimiento de
Módulos y no es evidente por qué.

### Para usar la variante con el componente Navegador

Cambiar únicamente la clase que se instancia:

```csharp
CapaVista_Mantenimiento2k26u.FrmPeliculasNavegador Peliculas =
    new CapaVista_Mantenimiento2k26u.FrmPeliculasNavegador();
Peliculas.ShowDialog();
```

Eso exige además que junto al ejecutable estén las tres DLL del Navegador y las cinco del
componente Consultas.

---

## Orden de compilación

Las referencias son por DLL con `HintPath` a `bin\Debug`, no `ProjectReference`. Si se compila en
otro orden, las referencias no resuelven y aparecen errores que no tienen que ver con el código:

```
1.  CapaModelo_Seguridad
2.  CapaControlador_Seguridad
3.  CapaModelo_Mantenimiento2k26u
4.  CapaControlador_Mantenimiento2k26u
5.  CapaVista_Mantenimiento2k26u
6.  CapaVista_Seguridad          <-- al final: ya referencia al mantenimiento
7.  Ejecucion_Seguridad
```

Si se va a usar la variante con Navegador, los tres proyectos del Navegador (y antes los nueve de
Consultas) van entre el paso 2 y el 5.

Todo en **Debug**: los `HintPath` apuntan a `bin\Debug`.
