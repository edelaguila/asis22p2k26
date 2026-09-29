using System;
using System.ComponentModel;
using System.Data;
using CapaControlador_Consultas;
using CapaVista_Consultas.Components;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcTablaSimple : ClsControlUsuarioConsultas
    {
        private readonly ClsTablas Tablas = new ClsTablas();
        private int _PaginaActual = 1;
        private int _RegistrosPorPagina = 10;
        private int _TotalRegistros = 0;
        private int _TotalPaginas = 0;
        private string _TablaSeleccionada = "";
        private int _InicioRangoPagina = 1;
        private int _CantidadBotonesPagina = 5;

        public UcTablaSimple()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTablaClick("tblConsulta");
            }
        }

        public UcTablaSimple(string tabla)
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasDgvSimples.AutoGenerateColumns = true;
                ConsultasProcActualizarTablaClick(tabla);
            }
        }

        public void ConsultasProcActualizarTablaClick(string tablaSeleccionada)
        {
            if (_TablaSeleccionada != tablaSeleccionada)
            {
                _PaginaActual = 1;
                _InicioRangoPagina = 1;
            }

            _TablaSeleccionada = tablaSeleccionada;

            ConsultasProcCalcularTotalPaginas();

            DataTable DtTablas = Tablas.ConsultasFuncLlenarTabla(
                _TablaSeleccionada,
                _PaginaActual,
                _RegistrosPorPagina);

            ConsultasDgvSimples.DataSource = DtTablas;

            ConsultasProcCrearBotonesPaginas();

        }
        private void ConsultasProcCalcularTotalPaginas()
        {
            _TotalRegistros = Tablas.ConsultasFuncContarRegistros(_TablaSeleccionada);

            _TotalPaginas = (int)Math.Ceiling(
                (double)_TotalRegistros / _RegistrosPorPagina
            );
        }
        private void ConsultasProcCrearBotonesPaginas()
        {
            ConsultasFlpPaginas.Controls.Clear();

            int FinRango = _InicioRangoPagina + _CantidadBotonesPagina - 1;

            if (FinRango > _TotalPaginas)
                FinRango = _TotalPaginas;

            for (int NumeroPagina = _InicioRangoPagina; NumeroPagina <= FinRango; NumeroPagina++)
            {
                ClsBotonPaginacionConsultas BotonPagina =
                    new ClsBotonPaginacionConsultas();

                BotonPagina.Name = $"ConsultasBtnPagina{NumeroPagina}";
                BotonPagina.Text = NumeroPagina.ToString();
                BotonPagina.Tag = NumeroPagina;
                BotonPagina.EsActivo = NumeroPagina == _PaginaActual;

                BotonPagina.Click += ConsultasMetBtnPaginaClick;

                ConsultasFlpPaginas.Controls.Add(BotonPagina);
            }
        }
        private void ConsultasMetBtnPaginaClick(object sender, EventArgs e)
        {
            ClsBotonPaginacionConsultas BotonPagina =
            (ClsBotonPaginacionConsultas)sender;

            _PaginaActual = Convert.ToInt32(BotonPagina.Tag);

            ConsultasProcActualizarTablaClick(_TablaSeleccionada);
        }

        private void ConsultasMetBtnAnteriorClick(object sender, EventArgs e)
        {
            if (_PaginaActual > 1)
            {
                _PaginaActual--;

                if (_PaginaActual < _InicioRangoPagina)
                {
                    _InicioRangoPagina--;
                }

                ConsultasProcActualizarTablaClick(_TablaSeleccionada);
            }
        }

        private void ConsultasMetBtnSiguiente(object sender, EventArgs e)
        {
            if (_PaginaActual < _TotalPaginas)
            {
                _PaginaActual++;

                if (_PaginaActual >=
                    _InicioRangoPagina + _CantidadBotonesPagina)
                {
                    _InicioRangoPagina++;
                }

                ConsultasProcActualizarTablaClick(_TablaSeleccionada);
            }
        }
    }
}
