# Mantenimiento2k26 – Segundo Parcial (Serie IV)

**Alumno:** Byron Alexander – **Carné:** 0901-23-3747

Mantenimiento de la tabla **departamento** con MVC, usando el componente **Navegador** para el CRUD,
con **reporte** (ReportViewer + RDLC, igual que Seguridad), **ayuda** (.chm en la carpeta `ayuda`, igual
que Seguridad) y cada acción registrada en la **bitácora de Seguridad**.

---

## 1. Qué se hizo y dónde está

### Nuevo proyecto de clases (MVC) – `codigo/componentes/mantenimiento2k26/Mantenimiento2k26/`
| Archivo | Capa | Qué hace |
|---|---|---|
| `Mantenimiento2k26.sln` | – | Solución con las 3 capas |
| `CapaModelo_Mantenimiento2k26/ClsDepartamento.cs` | Modelo | Entidad (propiedades = columnas de la BD) |
| `CapaModelo_Mantenimiento2k26/ClsRepositorioDepartamento.cs` | Modelo | SELECT por ODBC para el reporte (único lugar con SQL) |
| `CapaControlador_Mantenimiento2k26/ClsControladorDepartamento.cs` | Controlador | Tabla, módulo 4, aplicación 16; datos del reporte + bitácora "Reporte" |
| `CapaVista_Mantenimiento2k26/FrmDepartamento.cs` | Vista | Navegador + botón **Reporte** que muestra el ReportViewer dentro del mismo form; Ayuda → .chm |
| `CapaVista_Mantenimiento2k26/Reportes/RpReporteDepartamento.rdlc` | Vista | Diseño del reporte (estilo de los reportes de Seguridad) |

### Ayuda – `ayuda/componentes/mantenimiento2k26/Mantenimiento2k26Ayudas/`
| Archivo | Qué es |
|---|---|
| `Mantenimiento2k26Ayudas.chm` | Ayuda compilada (la que abre el botón Ayuda) |
| `Departamentos_Mantenimiento2k26.html` | Página de ayuda (mismo formato que `SeguridadAyudas`) |
| `Mantenimiento2k26Ayudas.hhp` / `.hhc` | Proyecto e índice de HTML Help Workshop |
| `Css/style.css`, `Imagenes/...` | Estilo e imágenes (copiados de SeguridadAyudas) |

> Para agregar capturas reales: pon las imágenes en `Imagenes/Departamentos/`, agrégalas al `.html` con
> `<img class="imgVentana" src="Imagenes/Departamentos/archivo.png">` y vuelve a compilar el `.hhp`
> con HTML Help Workshop.

### Cambios mínimos en componentes existentes
| Archivo | Cambio |
|---|---|
| `navegador/.../CapaVista_Navegador/Formularios/ClsCrudCoordinador.cs` | Registra en bitácora: Insertar, Consultar, Modificar, Eliminar |
| `navegador/.../CapaVista_Navegador/Seguridad/ClsNavegadorBitacora.cs` | Método `NavegadorMetRegistrar` para la bitácora |
| `navegador/.../CapaVista_Navegador/Navegador.cs` | Si el formulario maneja la **Ayuda**, el Navegador ya no abre la suya |
| `navegador/.../CapaModelo_Navegador/Conexion/ClsConexionBD.cs` | DSN → `segundoparcial2k26b` |
| `seguridad/.../CapaModelo_Seguridad/Repositorios/ClsConexion.cs` | DSN → `segundoparcial2k26b` |
| `consultas/.../CapaModelo_Consultas/Repositorios/ClsConexion.cs` | DSN → `segundoparcial2k26b` |
| `seguridad/.../CapaVista_Seguridad/FrmMDISeguridad.cs` y `.Designer.cs` | Botón **Departamentos** en el menú (módulo 4, aplicación 16) |
| `seguridad/.../CapaVista_Seguridad/CapaVista_Seguridad.csproj` | Referencia a `CapaVista_Mantenimiento2k26.dll` |

### Script de base de datos – `scripts/componentes/seguridad/departamento_2p2k26b.sql`
Tabla `departamento`, aplicación 16 "Departamentos", perfil **perfil2p2k26b**, empleado `EMP-2P26` y
usuario **examen2p2k26b** (contraseña `Examen2p2k26b`).

---

## 2. Base de datos y DSN
1. Ejecuta `scripts/componentes/seguridad/departamento_2p2k26b.sql` (si ya corriste los pasos 1 a 3, corre solo desde el paso 4).
2. DSN de sistema ODBC (MySQL) llamado **`segundoparcial2k26b`** apuntando a `dbsistemaembutidos`.
3. En Visual Studio busca `EmbutidosS.A` en toda la carpeta (Ctrl+Shift+F); si aparece en otro archivo, cámbialo por `segundoparcial2k26b`.

## 3. Compilar (en este orden, **Recompilar solución** en cada una)
1. `codigo/componentes/navegador/Navegador/Navegador.sln`
2. `codigo/componentes/mantenimiento2k26/Mantenimiento2k26/Mantenimiento2k26.sln`
3. `codigo/componentes/seguridad/Seguridad/Seguridad.sln`
4. Ejecuta `Ejecucion_Seguridad`, entra con `examen2p2k26b` / `Examen2p2k26b` y pulsa **Departamentos**.

> Si al cerrar la ayuda aparece también la del Navegador, es que el Navegador no se recompiló: vuelve al paso 1.
> El botón **Imprimir** del Navegador sigue como lo dejó su equipo (pendiente del Reporteador); el reporte
> se muestra con el botón **Reporte** dentro del form de Departamentos (otro clic lo oculta).

## 4. Prueba para el video
- **Ingresar** 3 registros → Guardar (ej. `D001 Ventas A`, `D002 Compras A`, `D003 Bodega A`)
- **Modificar** 1 (ej. D002 → estatus `I`) → Guardar
- **Eliminar** 1 (ej. D003)
- **Consultar** y **Refrescar**
- Botón **Reporte** → el reporte aparece dentro del form de Departamentos
- **Ayuda** → ayuda .chm
- En MySQL: `SELECT * FROM departamento;`
- Bitácora: botón **Bitácora** de Seguridad, o
  `SELECT * FROM tblbitacora WHERE tablaBitacora='departamento' ORDER BY idBitacora DESC;`

---

## 5. Git
Los pasos para subir el proyecto (fork, clone, ramas, merge, `bitacora.txt`, push y Pull Request) están en
`LEEME_PRIMERO.md` de la carpeta de entrega `ENTREGA_2P_0901233747`.

Ramas:
- `Rama_mantenimiento_1_0901233747` → script de base de datos
- `Rama_mantenimiento_2_0901233747` → Mantenimiento2k26, ayuda y cambios a Navegador/Seguridad/DSN

## 6. Entregables en Canvas
1. ZIP del proyecto (carpeta del repo, sin `bin/`, `obj/`, `.vs/`)
2. Link de tu repositorio (fork)
3. Imagen del Pull Request al repositorio del catedrático
4. `bitacora.txt`
5. Link del **video** en Google Drive (link del archivo, NO de la carpeta)
