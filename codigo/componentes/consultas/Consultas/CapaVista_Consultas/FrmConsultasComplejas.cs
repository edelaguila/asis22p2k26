using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "19/09/26"
    public partial class FrmConsultasComplejas : CapaVista_Componentes.ClsBaseTerminus
    {
        public string TablaActual { get; private set; }
        public string CampoSeleccionado { get; private set; }
        public bool SeleccionRealizada { get; private set; }

        List<Form> _FormularioCerrar = new List<Form>();


        public FrmConsultasComplejas()
        {
            InitializeComponent();
            ConsultasMetConfigurarFormulario();
        }

        public FrmConsultasComplejas(string Tabla, string CampoId): this()
        {
            TablaActual = Tabla;
            ConsultasUsrConsultasReutilizables.Tabla = TablaActual;
            ConsultasUsrConsultasReutilizables.ConsultasProcRefrescarConsultas();

            ConsultasUsrTabla.ConsultasMetConfigurarSeleccion(CampoId);

            ConsultasUsrTabla.ConsultasProcCambiarRegistrosPorPagina(30,TablaActual);
        }

        private void ConsultasMetConfigurarFormulario()
        {
            ConsultasUsrTabla.ConsultasMetAjustarAlturaFilas(30);
            ConsultasUsrConsultasReutilizables.ConsultaSeleccionada += ConsultasMetEjecutarConsultaSeleccionada;

            ConsultasUsrTabla.ConsultasEvtFilaSeleccionada += ConsultasMetUcTablaFilaSeleccionada;
        }

        private void ConsultasMetUcTablaFilaSeleccionada(object Sender, EventArgs Evento)
        {
            CampoSeleccionado =
                ConsultasUsrTabla.CampoSeleccionado;

            SeleccionRealizada =
                ConsultasUsrTabla.SeleccionRealizada;

            if (!SeleccionRealizada)
            {
                return;
            }

            DialogResult =
                DialogResult.OK;

            Close();
        }

        // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "19/09/26"

        // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"

        private void ConsultasMetEjecutarConsultaSeleccionada(string Query, string Tabla)
        {
            TablaActual = Tabla;

            ConsultasUsrTabla.ConsultasProcCargarConsultaDesdeQuery(Query,Tabla);
        }

        private void ConsultasMetBtnSeleccionarClick(object Sender,EventArgs Evento)
        {
            bool ResultadoSeleccion = ConsultasUsrTabla.ConsultasFuncSeleccionarRegistro();

            if (!ResultadoSeleccion)
            {
                MessageBox.Show(
                    "Seleccione un registro.",
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            CampoSeleccionado = ConsultasUsrTabla.CampoSeleccionado;
            SeleccionRealizada = ConsultasUsrTabla.SeleccionRealizada;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConsultasMetBtnSalirClick(object Sender, EventArgs Evento)
        {
            DialogResult Respuesta =
                MessageBox.Show(
                    "¿Desea salir del componente de Consultas?",
                    "Consultas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {

                foreach (Form Formulario in Application.OpenForms)
                {
                    if (Formulario.Name == "FrmConsultasSimples")
                    {
                        _FormularioCerrar.Add(Formulario);
                    }
                }
                foreach (Form Formulario in _FormularioCerrar)
                {
                    Formulario.Close();
                }
                this.Dispose();

            }
        }

        private void ConsultasMetBtnInicioClick(object Sender, EventArgs Evento)
        {
            Close();
        }

        private void ConsultasMetBtnRefrescarClick(object Sender, EventArgs Evento)
        {
            ConsultasUsrTabla.ConsultasProcActualizarTabla(TablaActual);
            ConsultasUsrConsultasReutilizables.ConsultasProcRefrescarConsultas();
        }
        // Fin de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"

        //Inicio de código de Diego Fernando Santizo Samayoa 0901-22-15950 22/09/2026
        private void ConsultasMetBtnAyudaClick(object Sender, EventArgs Evento)
        {
            DirectoryInfo Directorio = new DirectoryInfo(Application.StartupPath);

            while (Directorio != null)
            {
                string Ruta = Path.Combine(Directorio.FullName, "ayuda", "componentes", "consultas", "Ayuda_Consultas.chm");

                if (File.Exists(Ruta))
                {
                    Help.ShowHelp(this, Ruta, "ConsultaCompleja.html");
                    return;
                }
                Directorio = Directorio.Parent;
            }

            MessageBox.Show("No se encontró el archivo de ayuda.");
        }

        //Fin de código de Diego Fernando Santizo Samayoa 0901-22-15950 22/09/2026
    }
}