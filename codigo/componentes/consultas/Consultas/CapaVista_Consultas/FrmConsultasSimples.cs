using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;
using CapaVista_Consultas.Controles;
using System.Globalization;

namespace CapaVista_Consultas
{
    
    public partial class FrmConsultasSimples : CapaVista_Componentes.ClsBaseTerminus
    {
        private readonly ClsControladorFiltroSimple _Controlador = new ClsControladorFiltroSimple();

        // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "20/09/26"
        private string _TablaActual;
        private string _CampoId;
        private string _CampoFiltro;
        private string _OperadorFiltro;
        private string _ValorFiltro;

        private const int _RegistrosPorPagina = 15;
        public string CampoSeleccionado { get; private set; }
        public bool SeleccionRealizada { get; private set; }
        public FrmConsultasSimples()
        {
            InitializeComponent();

            ConsultasMetSuscribirEventos();
        }
        public FrmConsultasSimples(string Tabla, string CampoId): this()
        {
            _TablaActual = Tabla;
            _CampoId = CampoId;
            ConsultasUsrTablaSimple.ConsultasMetConfigurarSeleccion(CampoId);
            ClsTablaSeleccionada.ConsultasMetGuardarTabla(Tabla);
            ConsultasUsrTablaSimple.ConsultasProcActualizarTabla(Tabla);
            ConsultasUsrAgregarFiltro.ConsultasProcActualizarTabla(Tabla);
        }

        // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "20/09/26"

        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        public FrmConsultasSimples(string[] Tablas, string CampoId) : this()
        {
            if (Tablas == null || Tablas.Length == 0)
            {
                throw new ArgumentException(
                    "Debe proporcionar al menos una tabla.",
                    nameof(Tablas));
            }
            _TablaActual = Tablas[0];
            _CampoId = CampoId;
            ConsultasUsrTablaSimple.ConsultasMetConfigurarSeleccion(CampoId);
            ClsTablaSeleccionada.ConsultasMetGuardarTablas(Tablas);
            ConsultasUsrTablaSimple.ConsultasProcActualizarTabla(_TablaActual);
            ConsultasUsrAgregarFiltro.ConsultasProcActualizarTabla(_TablaActual);
        }
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"


        // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
        private void ConsultasMetSuscribirEventos()
        {
            ConsultasUsrAgregarFiltro.ConsultasEvtBuscarSolicitado += ConsultasMetAgregarFiltroBuscarSolicitado;
            ConsultasUsrAgregarFiltro.ConsultasEvtRefrescarSolicitado += ConsultasMetAgregarFiltroRefrescarSolicitado;
            ConsultasUsrTablaSimple.ConsultasEvtFilaSeleccionada += ConsultasMetTablaSimpleFilaSeleccionada;
        }

        private void ConsultasMetTablaSimpleFilaSeleccionada(object Sender, EventArgs Evento)
        {
            CampoSeleccionado = ConsultasUsrTablaSimple.CampoSeleccionado;

            SeleccionRealizada = ConsultasUsrTablaSimple.SeleccionRealizada;

            if (!SeleccionRealizada)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ConsultasMetAgregarFiltroBuscarSolicitado(object Sender, UsrAgregarFiltro.ClsArgumentosFiltro ArgumentosFiltro)
        {
            Type TipoCampo = _Controlador.ConsultasFuncObtenerTipoCampo(
                _TablaActual, ArgumentosFiltro.Campo);

            string Valor = (ArgumentosFiltro.Valor ?? "").Trim();

            bool EsNumerico =
            TipoCampo == typeof(byte) ||
            TipoCampo == typeof(short) ||
            TipoCampo == typeof(int) ||
            TipoCampo == typeof(long) ||
            TipoCampo == typeof(float) ||
            TipoCampo == typeof(double) ||
            TipoCampo == typeof(decimal);

            if (EsNumerico &&
                !decimal.TryParse(
                    Valor,
                    NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out _))
            {
                ConsultasUsrAgregarFiltro.ConsultasProcMostrarErrorValor(
                    "El campo " + ArgumentosFiltro.Campo +
                    " es numérico. Escriba un número válido.");
                return;
            }

            _CampoFiltro = ArgumentosFiltro.Campo;
            _OperadorFiltro = ArgumentosFiltro.Operador;
            _ValorFiltro = Valor;

            ConsultasUsrAgregarFiltro.ConsultasProcLimpiarErrorValor();
            ConsultasMetAplicarFiltro();
        }

        private void ConsultasMetAgregarFiltroRefrescarSolicitado(object Sender,EventArgs Evento)
        {
            _CampoFiltro = null;
            _OperadorFiltro = null;
            _ValorFiltro = null;

            ConsultasUsrTablaSimple.ConsultasProcActualizarTabla(_TablaActual);
        }

        private void ConsultasMetAplicarFiltro()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DataTable Resultado = _Controlador.ConsultasFuncBuscar(_TablaActual, _CampoFiltro, _OperadorFiltro, _ValorFiltro, 1, _RegistrosPorPagina);
                int TotalRegistros = _Controlador.ConsultasFuncContar(_TablaActual,_CampoFiltro,_OperadorFiltro,_ValorFiltro);
                ConsultasUsrTablaSimple.ConsultasProcMostrarResultado(Resultado,TotalRegistros);

                if (TotalRegistros == 0)
                {
                    Type TipoCampo = _Controlador.ConsultasFuncObtenerTipoCampo(
                        _TablaActual, _CampoFiltro);

                    string Mensaje = TipoCampo == typeof(DateTime)
                        ? "Ningún registro cumple con el filtro. Verifique la fecha: " +
                          "aaaa-MM-dd HH:mm:ss."
                        : "Ningún registro cumple con el filtro indicado. Verifique el formato del campo";

                    ConsultasUsrAgregarFiltro.ConsultasProcMostrarErrorValor(Mensaje);
                }
                else
                {
                    ConsultasUsrAgregarFiltro.ConsultasProcLimpiarErrorValor();
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show("No se pudo ejecutar la consulta.\n\n" + "Detalle: " + Excepcion.Message,"Consultas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConsultasMetBtnComplejasClick(object Sender, EventArgs Evento)
        {
            using (FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas(_TablaActual,_CampoId))
            {
                Hide();

                FormularioConsultasComplejas.ShowDialog();

                if (FormularioConsultasComplejas.SeleccionRealizada)
                {
                    CampoSeleccionado = FormularioConsultasComplejas.CampoSeleccionado;
                    SeleccionRealizada = true;
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                Show();
                BringToFront();
            }
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
                this.Dispose();
            }
        }
    }

    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "15/09/26"
}