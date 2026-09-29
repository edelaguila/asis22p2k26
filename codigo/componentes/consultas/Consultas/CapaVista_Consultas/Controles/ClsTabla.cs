using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class ClsTabla : Componentes.ClsControlUsuarioConsultas
    {

        private string _CampoId;

        public string IdSeleccionado { get; private set; }

        public string TablaSeleccionada { get; private set; }

        public bool SeleccionRealizada { get; private set; }

        private readonly ClsTablas _Tablas =
            new ClsTablas();

        private readonly ClsConsultaSeleccionada _ConsultaSeleccionada =
            new ClsConsultaSeleccionada();

        private int _PaginaActual = 1;
        private string _QuerySeleccionada = "";
        private bool _EsConsultaPersonalizada = false;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;

        private readonly int _CantidadBotonesPagina = 5;

        public int RegistrosPorPagina { get; private set; } = 15;

        public event EventHandler
             ConsultasEvtFilaSeleccionada;
        public ClsTabla()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode !=
                LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
            }
        }
        public ClsTabla(string Tabla) : this()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasProcActualizarTabla(
                    Tabla);
            }
        }
        public bool ConsultasFuncSeleccionarRegistro()
        {
            if (string.IsNullOrWhiteSpace(_CampoId))
            {
                return false;
            }

            string ValorSeleccionado = ConsultasFuncObtenerValorSeleccionado(_CampoId);

            if (string.IsNullOrWhiteSpace(ValorSeleccionado))
            {
                return false;
            }

            IdSeleccionado = ValorSeleccionado;

            TablaSeleccionada = _TablaSeleccionada;

            SeleccionRealizada = true;

            return true;
        }
        public void ConsultasMetConfigurarSeleccion(
            string CampoId)
        {
            _CampoId = CampoId;

            IdSeleccionado = null;
            TablaSeleccionada = null;
            SeleccionRealizada = false;
        }

        public string ConsultasFuncObtenerValorSeleccionado(
            string Campo)
        {
            if (string.IsNullOrWhiteSpace(Campo))
            {
                return null;
            }

            if (ConsultasDgvSimples.CurrentRow == null)
            {
                return null;
            }

            if (!ConsultasDgvSimples.Columns.Contains(Campo))
            {
                return null;
            }

            object Valor = ConsultasDgvSimples.CurrentRow.Cells[Campo].Value;

            if (Valor == null || Valor == DBNull.Value)
            {
                return null;
            }

            return Valor.ToString();
        }

        public void ConsultasMetAjustarAlturaFilas(
            int RegistrosPorPagina)
        {
            if (RegistrosPorPagina <= 0)
            {
                return;
            }

            this.RegistrosPorPagina = RegistrosPorPagina;
        }

        public void ConsultasProcActualizarTabla(
            string TablaSeleccionada)
        {
            try
            {
                if (_TablaSeleccionada != TablaSeleccionada || _EsConsultaPersonalizada)
                {
                    _PaginaActual = 1;
                    _InicioRangoPagina = 1;
                }

                _TablaSeleccionada = TablaSeleccionada;

                _QuerySeleccionada = "";

                _EsConsultaPersonalizada = false;

                ConsultasProcCalcularTotalPaginas();

                DataTable ResultadoTablas = _Tablas.ConsultasFuncLlenarTabla(_TablaSeleccionada, _PaginaActual, RegistrosPorPagina);

                ConsultasDgvSimples.DataSource = ResultadoTablas;

                ConsultasProcCrearBotonesPaginas();

                ConsultasProcCambiarLbl();
            }
            catch (ArgumentException Excepcion)
            {
                ConsultasMetMostrarAdvertencia(
                    Excepcion.Message);
            }
            catch (InvalidOperationException Excepcion)
            {
                ConsultasMetMostrarError(
                    Excepcion.Message);
            }
            catch (Exception Excepcion)
            {
                ConsultasMetMostrarError(
                    "Ocurrió un error inesperado al cargar " + "los registros.\n\n" + Excepcion.Message);
            }
        }
        public void ConsultasProcCargarConsultaDesdeQuery(
            string Consulta,
            string Tabla)
        {
            try
            {
                bool CambioConsulta = !_EsConsultaPersonalizada || _QuerySeleccionada != Consulta;

                if (CambioConsulta)
                {
                    _PaginaActual = 1;
                    _InicioRangoPagina = 1;
                }

                _TablaSeleccionada = Tabla;

                _QuerySeleccionada = Consulta;

                _EsConsultaPersonalizada = true;

                _TotalRegistros = _ConsultaSeleccionada.ConsultasFuncContarResultadosQuery(_QuerySeleccionada);

                _TotalPaginas = (int)Math.Ceiling((double)_TotalRegistros / RegistrosPorPagina);

                DataTable DtTablas = _ConsultaSeleccionada.ConsultasFuncCargarConsulta(_QuerySeleccionada, _PaginaActual, RegistrosPorPagina);

                ConsultasDgvSimples.DataSource = DtTablas;

                ConsultasProcCrearBotonesPaginas();

                ConsultasProcCambiarLblResultado();
            }
            catch (ArgumentException Excepcion)
            {
                ConsultasDgvSimples.DataSource =
                    null;

                _TotalRegistros = 0;
                _TotalPaginas = 0;

                ConsultasMetMostrarAdvertencia(
                    Excepcion.Message);
            }
            catch (InvalidOperationException Excepcion)
            {
                ConsultasDgvSimples.DataSource =
                    null;

                _TotalRegistros = 0;
                _TotalPaginas = 0;

                ConsultasMetMostrarError(
                    Excepcion.Message);
            }
            catch (Exception Excepcion)
            {
                ConsultasDgvSimples.DataSource =
                    null;

                _TotalRegistros = 0;
                _TotalPaginas = 0;

                ConsultasMetMostrarError(
                    "Ocurrió un error inesperado al ejecutar " +
                    "la consulta.\n\n" +
                    Excepcion.Message);
            }
        }
        private void ConsultasProcActualizarBotonesPaginacion()
        {
            // Si pagina actual es mayor a 1, habilitar botón anterior
            ConsultasBtnAnterior.Enabled = _PaginaActual > 1;


            // Si pagina actual es menor al total de paginas, habilitar botón siguiente
            ConsultasBtnSiguiente.Enabled = _PaginaActual < _TotalPaginas;


        }

        public void ConsultasProcMostrarResultado(
            DataTable Datos,
            int TotalRegistros)
        {
            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            _TotalRegistros =
                TotalRegistros;

            _TotalPaginas =
                (int)Math.Ceiling(
                    (double)_TotalRegistros /
                    RegistrosPorPagina);

            ConsultasDgvSimples.DataSource =
                Datos;

            ConsultasProcCrearBotonesPaginas();

            ConsultasProcCambiarLblResultado();
        }

        public void ConsultasProcMostrarResultado(
            DataTable Datos)
        {
            ConsultasProcMostrarResultado(
                Datos,
                Datos == null
                    ? 0
                    : Datos.Rows.Count);
        }

        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros =
                _Tablas.ConsultasFuncContarRegistros(
                    _TablaSeleccionada);

            _TotalPaginas =
                (int)Math.Ceiling(
                    (double)_TotalRegistros /
                    RegistrosPorPagina);
        }

        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            if (_TotalPaginas <= 0)
            {
                ConsultasProcActualizarBotonesPaginacion();
                return;
            }

            int FinRango =
                _InicioRangoPagina +
                _CantidadBotonesPagina -
                1;

            if (FinRango > _TotalPaginas)
            {
                FinRango = _TotalPaginas;
            }

            for (
                int NumeroPagina = _InicioRangoPagina;
                NumeroPagina <= FinRango;
                NumeroPagina++)
            {
                Componentes.ClsBotonPaginacionConsultas
                    BotonPagina =
                        new Componentes.ClsBotonPaginacionConsultas();

                BotonPagina.Name =
                    $"ConsultasBtnPagina{NumeroPagina}";

                BotonPagina.Text =
                    NumeroPagina.ToString();

                BotonPagina.Tag =
                    NumeroPagina;

                BotonPagina.EsActivo =
                    NumeroPagina == _PaginaActual;

                BotonPagina.Click +=
                    ConsultasMetBtnPaginaClick;

                ConsultasFlpPaginas.Controls.Add(
                    BotonPagina);
            }

            // Actualizar Anterior / Siguiente
            ConsultasProcActualizarBotonesPaginacion();
        }


        private void ConsultasMetBtnPaginaClick(
            object Sender,
            EventArgs Evento)
        {
            Componentes.ClsBotonPaginacionConsultas
                BotonPagina =
                    (Componentes
                        .ClsBotonPaginacionConsultas)Sender;

            _PaginaActual =
                Convert.ToInt32(
                    BotonPagina.Tag);

            ConsultasProcRecargarPaginaActual();
        }

        private void ConsultasMetBtnAnteriorClick(
            object Sender,
            EventArgs Evento)
        {
            if (_PaginaActual <= 1)
            {
                return;
            }

            _PaginaActual--;

            if (_PaginaActual <
                _InicioRangoPagina)
            {
                _InicioRangoPagina--;
            }

            ConsultasProcRecargarPaginaActual();
        }

        private void ConsultasMetBtnSiguienteClick(
            object Sender,
            EventArgs Evento)
        {
            if (_PaginaActual >=
                _TotalPaginas)
            {
                return;
            }

            _PaginaActual++;

            if (_PaginaActual >=
                _InicioRangoPagina +
                _CantidadBotonesPagina)
            {
                _InicioRangoPagina++;
            }

            ConsultasProcRecargarPaginaActual();
        }

        private void ConsultasProcRecargarPaginaActual()
        {
            if (_EsConsultaPersonalizada)
            {
                ConsultasProcCargarConsultaDesdeQuery(
                    _QuerySeleccionada,
                    _TablaSeleccionada);
            }
            else
            {
                ConsultasProcActualizarTabla(
                    _TablaSeleccionada);
            }
        }

        private void ConsultasProcCambiarLbl()
        {
            if (_TotalRegistros == 0)
            {
                ConsultasLblPaginacion.Text =
                    "Sin registros";

                return;
            }

            int Desde =
                ((_PaginaActual - 1) *
                RegistrosPorPagina) + 1;

            int Hasta =
                _PaginaActual *
                RegistrosPorPagina;

            if (Hasta > _TotalRegistros)
            {
                Hasta =
                    _TotalRegistros;
            }

            ConsultasLblPaginacion.Text =
                "Mostrando " +
                Desde +
                "-" +
                Hasta +
                " de " +
                _TotalRegistros +
                " registros";
        }

        private void ConsultasProcCambiarLblResultado()
        {
            if (_TotalRegistros == 0)
            {
                ConsultasLblPaginacion.Text =
                    "Sin registros que coincidan";

                return;
            }

            int Desde =
                ((_PaginaActual - 1) *
                RegistrosPorPagina) + 1;

            int Hasta =
                _PaginaActual *
                RegistrosPorPagina;

            if (Hasta > _TotalRegistros)
            {
                Hasta =
                    _TotalRegistros;
            }

            ConsultasLblPaginacion.Text =
                "Mostrando " +
                Desde +
                "-" +
                Hasta +
                " de " +
                _TotalRegistros +
                " registros";
        }

        public void ConsultasProcCambiarRegistrosPorPagina(
            int Cantidad)
        {
            if (Cantidad <= 0)
            {
                ConsultasMetMostrarAdvertencia(
                    "La cantidad de registros por página " +
                    "debe ser mayor a cero.");

                return;
            }

            RegistrosPorPagina =
                Cantidad;

            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            ConsultasProcRecargarPaginaActual();
        }

        public void ConsultasProcCambiarRegistrosPorPagina(int Cantidad, string Tabla)
        {
            if (Cantidad <= 0)
            {
                ConsultasMetMostrarAdvertencia(
                    "La cantidad de registros por página " +
                    "debe ser mayor a cero.");

                return;
            }

            RegistrosPorPagina =
                Cantidad;

            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            ConsultasProcActualizarTabla(Tabla);
        }

        private void ConsultasMetMostrarError(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ConsultasMetMostrarAdvertencia(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void ConsultasMetDgvSimplesCellDoubleClick(
            object Sender,
            DataGridViewCellEventArgs Evento)
        {
            if (Evento.RowIndex < 0)
            {
                return;
            }

            string ValorSeleccionado =
                ConsultasFuncObtenerValorSeleccionado(
                    _CampoId);

            if (string.IsNullOrWhiteSpace(
                ValorSeleccionado))
            {
                return;
            }

            DialogResult Respuesta =
                MessageBox.Show(
                    "¿Desea seleccionar el registro con ID " +
                    ValorSeleccionado +
                    "?",
                    "Seleccionar registro",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

            if (Respuesta != DialogResult.OK)
            {
                return;
            }

            if (!ConsultasFuncSeleccionarRegistro())
            {
                return;
            }

            ConsultasEvtFilaSeleccionada?.Invoke(this, EventArgs.Empty);
        }
    }
}