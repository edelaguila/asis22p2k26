using CapaControlador_Consultas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    //Inicio del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457 20/09/2026
    public partial class FrmMantenimientoConsultas : CapaVista_Componentes.ClsBaseTerminus
    {
        private readonly ClsControladorMantenimiento _Control = new ClsControladorMantenimiento();
        private Dictionary<string, string> _Tipos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private string _Tabla;

        private const int _ColCampo = 0;
        private const int _ColOperador = 1;
        private const int _ColValor = 2;
        private const int _ColOrden = 3;
        private const int _ColConector = 4; // NUEVO: columna para AND/OR

        public FrmMantenimientoConsultas(string Tabla)
        {
            InitializeComponent();
            _Tabla = (Tabla ?? "").Trim();
            Load += ConsultasMetFrmMantenimientoConsultasLoad;
            ConsultasUsrValor.MaxLength = 50;
            ConsultasTxtNombre.MaxLength = 50;
        }

        private void ConsultasMetFrmMantenimientoConsultasLoad(object Sender, EventArgs Evento)
        {
            try
            {
                ConsultasProcConectarEventos();
                ConsultasProcCargarOperadores("");
                ConsultasProcCargarConectores();
                ConsultasCboConector.Enabled = false;

                if (_Tabla == "")
                {
                    BeginInvoke(new MethodInvoker(Close));
                    return;
                }

                ConsultasProcCargarColumnas();
            }
            catch (Exception Excepcion)
            {
                ConsultasProcMostrarError("No se pudo cargar el formulario.", Excepcion);
                BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void ConsultasProcConectarEventos()

        {
            ConsultasCboOperadorCampo.SelectedIndexChanged += ConsultasCboOperadorCampo_SelectedIndexChanged;
            ConsultasCboOperador.SelectedIndexChanged += ConsultasCboOperador_SelectedIndexChanged;
            ConsultasBtnIngresar.Click += ConsultasMetBtnIngresarClick;
            ConsultasBtnEliminar.Click += ConsultasMetBtnEliminarClick;
            ConsultasBtnGuardar.Click += ConsultasMetBtnGuardarClick;
        }

        //Inicio del código de Miguel David Contreras Jacinto 0901-21-3878 el 22/09/2026
        private void ConsultasProcCargarOperadores(string TipoCampo)
        {
            ConsultasCboOperador.Items.Clear();
            ConsultasUsrValor.MaxLength = 50;
            ConsultasUsrValor.Text = "";


            if (string.IsNullOrWhiteSpace(TipoCampo))
            {
                ConsultasCboOperador.SelectedIndex = -1;
                return;
            }

            string Tipo = TipoCampo.Trim().ToLowerInvariant();
            int PosicionParentesis = Tipo.IndexOf('(');

            if (PosicionParentesis > 0)
            {
                Tipo = Tipo.Substring(0, PosicionParentesis);
            }

            if (Tipo.Contains("int") ||
                Tipo == "integer" ||
                Tipo == "bigint" ||
                Tipo == "smallint" ||
                Tipo == "mediumint" ||
                Tipo == "tinyint" ||
                Tipo == "decimal" ||
                Tipo == "numeric" ||
                Tipo == "float" ||
                Tipo == "double" ||
                Tipo == "real")
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add(">");
                ConsultasCboOperador.Items.Add("<");
                ConsultasCboOperador.Items.Add(">=");
                ConsultasCboOperador.Items.Add("<=");
                ConsultasUsrValor.MaxLength = 10;
            }

            else if (Tipo.Contains("char") ||
                     Tipo.Contains("text") ||
                     Tipo.Contains("string") ||
                     Tipo == "varchar")
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add("Contiene");
                ConsultasCboOperador.Items.Add("Empieza con");
                ConsultasCboOperador.Items.Add("Termina con");
            }

            else if (Tipo.Contains("date") ||
                     Tipo.Contains("time"))
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add(">");
                ConsultasCboOperador.Items.Add("<");
                ConsultasCboOperador.Items.Add(">=");
                ConsultasCboOperador.Items.Add("<=");
            }

            else
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add("IS NULL");
                ConsultasCboOperador.Items.Add("IS NOT NULL");
            }

            ConsultasCboOperador.SelectedIndex = -1;
        }

        private void ConsultasProcCargarConectores()
        {
            ConsultasCboConector.Items.Clear();
            ConsultasCboConector.Items.AddRange(new object[] { "AND", "OR" });
            ConsultasCboConector.SelectedIndex = 0;
        }
        private void ConsultasProcCargarColumnas()
        {
            _Tipos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            ConsultasCboOperadorCampo.Items.Clear();

            foreach (KeyValuePair<string, string> Columna in _Control.ConsultasMetObtenerColumnas(_Tabla))
            {
                _Tipos[Columna.Key] = Columna.Value;
                ConsultasCboOperadorCampo.Items.Add(Columna.Key);
            }

            if (_Tipos.Count == 0)
            {
                throw new ArgumentException(
                    "No se encontraron campos para \"" + _Tabla + "\". Revisa que exista en la base de datos dbConsulta.");
            }

            ConsultasCboOperadorCampo.SelectedIndex = -1;
        }

        private void ConsultasCboOperador_SelectedIndexChanged(object Sender, EventArgs Evento)
        {
            string Operador = ConsultasCboOperador.SelectedItem == null ? "" : ConsultasCboOperador.SelectedItem.ToString();
            bool SinValor = Operador == "IS NULL" || Operador == "IS NOT NULL";

            ConsultasUsrValor.Enabled = !SinValor;
            if (SinValor)
            {
                ConsultasUsrValor.Text = string.Empty;
                ConsultasUsrValor.ConsultasMetLimpiarError();
            }
        }

        //Inicio del código de Miguel David Contreras Jacinto 0901-21-3878 el 22/09/2026
        private void ConsultasCboOperadorCampo_SelectedIndexChanged(object Sender, EventArgs Evento)
        {
            if (ConsultasCboOperadorCampo.SelectedIndex < 0)
            {
                ConsultasProcCargarOperadores("");
                return;
            }

            string Campo = ConsultasCboOperadorCampo.SelectedItem.ToString();

            if (_Tipos.ContainsKey(Campo))
            {
                string TipoCampo = _Tipos[Campo];

                ConsultasProcCargarOperadores(TipoCampo);
            }
        }

        //Fin del código de Miguel David Contreras Jacinto 0901-21-3878 el 22/09/2026

        // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"
          // Valida el valor del filtro y muestra el error directamente bajo el campo.
        private void ConsultasMetBtnIngresarClick(object Sender, EventArgs Evento)
        {
            ConsultasUsrValor.ConsultasMetLimpiarError();

            try
            {
                if (ConsultasCboOperadorCampo.SelectedItem == null)
                {
                    ConsultasProcAviso("Selecciona un campo.");
                    return;
                }

                string Campo = ConsultasCboOperadorCampo.SelectedItem.ToString();
                string Operador = ConsultasCboOperador.SelectedItem == null
                    ? ""
                    : ConsultasCboOperador.SelectedItem.ToString();
                string Valor = ConsultasUsrValor.Text.Trim();
                string Orden = ConsultasRdoAscendente.Checked
                    ? "ASC"
                    : (ConsultasRdoDescendente.Checked ? "DESC" : "");

                if (Operador == "" && Valor != "")
                {
                    ConsultasProcAviso("Selecciona un operador para usar el valor.");
                    return;
                }

                if (Operador == "" && Orden == "")
                {
                    ConsultasProcAviso(
                        "Selecciona un operador con su valor, o un ordenamiento (ASC / DESC).");
                    return;
                }

                bool RequiereValor =
                    Operador != "" &&
                    Operador != "IS NULL" &&
                    Operador != "IS NOT NULL";

                if (RequiereValor && string.IsNullOrWhiteSpace(Valor))
                {
                    ConsultasUsrValor.ConsultasMetMostrarError("Ingrese un valor para el filtro.");
                    ConsultasUsrValor.ConsultasMetEnfocarTexto();
                    return;
                }

                bool ExisteCondicionPrevia =
                    ConsultasDgvConsultasFiltros.Rows.Count > 0;

                string Conector = Operador != "" && ExisteCondicionPrevia
                    ? ConsultasCboConector.SelectedItem.ToString()
                    : "";

                try
                {
                    _Control.ConsultasProcValidarCondicion(Campo, Operador, Valor, _Tipos);
                }
                catch (ArgumentException Excepcion)
                {
                    ConsultasUsrValor.ConsultasMetMostrarError(Excepcion.Message);
                    ConsultasUsrValor.ConsultasMetEnfocarTexto();
                    return;
                }

                ConsultasDgvConsultasFiltros.Rows.Add(Campo, Operador, Valor, Orden, Conector);

                ConsultasCboConector.Enabled = true;
                ConsultasUsrValor.Text = string.Empty;
                ConsultasUsrValor.ConsultasMetLimpiarError();
                ConsultasCboOperadorCampo.SelectedIndex = -1;
                ConsultasCboOperador.SelectedIndex = -1;
                ConsultasRdoAscendente.Checked = true;
                ConsultasRdoDescendente.Checked = false;
                ConsultasCboConector.SelectedIndex = 0;
            }
            catch (ArgumentException Excepcion)
            {
                ConsultasProcAviso(Excepcion.Message);
            }
            catch (Exception Excepcion)
            {
                ConsultasProcMostrarError(
                    "No se pudo agregar la condición.", Excepcion);
            }
        }
        // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"

        private void ConsultasMetBtnEliminarClick(object Sender, EventArgs Evento)
        {
            if (ConsultasDgvConsultasFiltros.SelectedRows.Count == 0)
            {
                ConsultasProcAviso("Selecciona en la tabla la condicion que quieres quitar.");
                return;
            }

            ConsultasDgvConsultasFiltros.Rows.Remove(ConsultasDgvConsultasFiltros.SelectedRows[0]);

            if (ConsultasDgvConsultasFiltros.Rows.Count == 0)
            {
                ConsultasCboConector.Enabled = false;
            }
        }

        private void ConsultasMetBtnGuardarClick(object Sender, EventArgs Evento)
        {
            try
            {
                string Nombre = ConsultasTxtNombre.Text.Trim();
                if (Nombre == "")
                {
                    ConsultasProcAviso("Escribe un nombre para la consulta.");
                    ConsultasTxtNombre.Focus();
                    return;
                }

                string Query = _Control.ConsultasFuncConstruirQuery(_Tabla, ConsultasMetLeerCondiciones(), _Tipos);

                DialogResult Resultado = MessageBox.Show(this,
                 "¿Guardar la consulta \"" + Nombre + "\"?",
                 "Guardar consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Resultado != DialogResult.Yes)
                {
                    return;
                }

                _Control.ConsultasProcGuardar(Nombre, _Tabla, Query);

                MessageBox.Show(this, "Consulta guardada.", "Mantenimiento de consultas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (ArgumentException Excepcion)
            {
                ConsultasProcAviso(Excepcion.Message);
            }
            catch (Exception Excepcion)
            {
                ConsultasProcMostrarError("No se pudo guardar la consulta.", Excepcion);
            }
        }

        // Ya no devuelve List<ClsCondicion>: devuelve una lista de tuplas, un tipo
        // del propio C#, para que la Vista no dependa de ninguna clase de otra capa.
        private List<(string Campo, string Operador, string Valor, string Orden, string Conector)> ConsultasMetLeerCondiciones()
        {
            List<(string Campo, string Operador, string Valor, string Orden, string Conector)> Lista =
                new List<(string Campo, string Operador, string Valor, string Orden, string Conector)>();

            foreach (DataGridViewRow Fila in ConsultasDgvConsultasFiltros.Rows)
            {
                Lista.Add((
                    ConsultasFuncTexto(Fila.Cells[_ColCampo]),
                    ConsultasFuncTexto(Fila.Cells[_ColOperador]),
                    ConsultasFuncTexto(Fila.Cells[_ColValor]),
                    ConsultasFuncTexto(Fila.Cells[_ColOrden]),
                    ConsultasFuncTexto(Fila.Cells[_ColConector])
                ));
            }

            return Lista;
        }

        private void ConsultasProcLimpiarFormulario()
        {
            ConsultasDgvConsultasFiltros.Rows.Clear();
            ConsultasTxtNombre.Clear();
            ConsultasUsrValor.Text = string.Empty;
            ConsultasUsrValor.ConsultasMetLimpiarError();
            ConsultasUsrValor.Enabled = true;
            ConsultasCboOperadorCampo.SelectedIndex = -1;
            ConsultasCboOperador.SelectedIndex = -1;
            ConsultasRdoAscendente.Checked = true;
            ConsultasRdoDescendente.Checked = false;
            ConsultasCboConector.SelectedIndex = 0;
            ConsultasCboConector.Enabled = false;
        }

        private static string ConsultasFuncTexto(DataGridViewCell Celda)
        {
            return Celda.Value == null ? "" : Celda.Value.ToString();
        }

        private void ConsultasProcAviso(string Mensaje)
        {
            MessageBox.Show(this, Mensaje, "Mantenimiento de consultas",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ConsultasProcMostrarError(string Mensaje, Exception Excepcion)
        {
            MessageBox.Show(this, Mensaje + Environment.NewLine + Environment.NewLine + Excepcion.Message,
                "Mantenimiento de consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Fin del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457 20/09/2026

        //Inicio del código realizado por Diego Fernando Santizo Samayoa 0901-22-15950 22/09/2026
        private void ConsultasMetBtnAyudaClick(object Sender, EventArgs Evento)
        {
            DirectoryInfo Directorio = new DirectoryInfo(Application.StartupPath);

            while (Directorio != null)
            {
                string Ruta = Path.Combine(Directorio.FullName, "ayuda", "componentes", "consultas", "Ayuda_Consultas.chm");

                if (File.Exists(Ruta))
                {
                    Help.ShowHelp(this, Ruta, "ConsultasReutilizables.html");
                    return;
                }

                Directorio = Directorio.Parent;
            }

            MessageBox.Show("No se encontró el archivo de ayuda.");
        }

        private void ConsultasMetBtnRefrescarClick(object Sender, EventArgs Evento)
        {
            ConsultasProcLimpiarFormulario();
        }

        //Fin del código realizado por Diego Fernando Santizo Samayoa 0901-22-15950 22/09/2026
    }

    //Fin del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457 20/09/2026
}