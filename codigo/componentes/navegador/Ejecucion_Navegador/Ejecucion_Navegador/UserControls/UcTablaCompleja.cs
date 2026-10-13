using System;
using System.ComponentModel;
using System.Data;
using CapaControlador_Consultas;
using CapaVista_Consultas.Components;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcTablaCompleja : ClsControlUsuarioConsultas
    {
        private readonly ClsTablas _Tablas = new ClsTablas();

        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;
        private int _CantidadBotonesPagina = 5;

        public UcTablaCompleja()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasCboTablas.SelectionChangeCommitted +=
                    ConsultasMetCboTablasSelectionChangeCommitted;

                ConsultasProcPopularCboTablas();
                ConsultasProcActualizarNavegacion();
            }
        }

        public void ConsultasProcPopularCboTablas()
        {
            ConsultasCboTablas.Items.Clear();

            DataTable DtTablas =
                _Tablas.ConsultasFuncObtenerTablas();

            foreach (DataRow Fila in DtTablas.Rows)
            {
                ConsultasCboTablas.Items.Add(
                    Fila[0].ToString());
            }

            ConsultasCboTablas.SelectedIndex = -1;
        }

        private void ConsultasProcActualizarTabla()
        {
            if (string.IsNullOrWhiteSpace(_TablaSeleccionada))
            {
                return;
            }

            ConsultasProcCalcularTotalPaginas();
            ConsultasProcActualizarDgvTablas();
            ConsultasProcCrearBotonesPaginas();
            ConsultasProcActualizarNavegacion();
        }

        private void ConsultasProcActualizarDgvTablas()
        {
            DataTable DtTablas =
                _Tablas.ConsultasFuncLlenarTabla(
                    _TablaSeleccionada,
                    _PaginaActual,
                    _RegistrosPorPagina);

            ConsultasDgvComplejas.DataSource = DtTablas;
        }

        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros =
                _Tablas.ConsultasFuncContarRegistros(
                    _TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros /
                _RegistrosPorPagina);

            if (_TotalPaginas == 0)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
                return;
            }

            if (_PaginaActual > _TotalPaginas)
            {
                _PaginaActual = _TotalPaginas;
            }
        }

        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            if (_TotalPaginas <= 0)
            {
                return;
            }

            int FinRango =
                _InicioRangoPagina +
                _CantidadBotonesPagina - 1;

            if (FinRango > _TotalPaginas)
            {
                FinRango = _TotalPaginas;
            }

            for (
                int NumeroPagina = _InicioRangoPagina;
                NumeroPagina <= FinRango;
                NumeroPagina++)
            {
                ClsBotonPaginacionConsultas BotonPagina =
                    new ClsBotonPaginacionConsultas();

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
        }

        private void ConsultasProcActualizarNavegacion()
        {
            ConsultasBtnAnterior.Enabled =
                _PaginaActual > 1;

            ConsultasBtnSiguiente.Enabled =
                _TotalPaginas > 0 &&
                _PaginaActual < _TotalPaginas;
        }

        private void ConsultasMetCboTablasSelectionChangeCommitted(
            object sender,
            EventArgs e)
        {
            if (ConsultasCboTablas.SelectedItem == null)
            {
                return;
            }

            _TablaSeleccionada =
                ConsultasCboTablas.SelectedItem.ToString();

            _PaginaActual = 1;
            _InicioRangoPagina = 1;

            ConsultasProcActualizarTabla();
        }

        private void ConsultasMetBtnPaginaClick(object sender,EventArgs e)
        {
            if (!(sender is ClsBotonPaginacionConsultas BotonPagina))
            {
                return;
            }

            _PaginaActual =
                Convert.ToInt32(BotonPagina.Tag);

            ConsultasProcActualizarTabla();
        }

        private void ConsultasMetBtnSiguienteClick(object sender, EventArgs e)
        {
            if (_PaginaActual >= _TotalPaginas)
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

            ConsultasProcActualizarTabla();
        }

        private void ConsultasMetBtnAnteriorClick(object sender, EventArgs e)
        {
            if (_PaginaActual <= 1)
            {
                return;
            }

            _PaginaActual--;

            if (_PaginaActual < _InicioRangoPagina)
            {
                _InicioRangoPagina--;
            }

            ConsultasProcActualizarTabla();
        }
    }
}