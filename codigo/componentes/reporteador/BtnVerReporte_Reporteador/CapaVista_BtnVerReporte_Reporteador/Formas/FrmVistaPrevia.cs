using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaVista_BtnVerReporte_Reporteador
{
    public partial class FrmVistaPrevia : Form
    {
        private readonly string _RutaReporte;
        private readonly Dictionary<string, object> _FuentesDeDatos;

        // RECIBIR LA RUTA Y LAS FUENTES DE DATOS DEL REPORTE
        public FrmVistaPrevia(string RutaReporte, Dictionary<string, object> FuentesDeDatos)
        {
            InitializeComponent();
            _RutaReporte = RutaReporte;
            _FuentesDeDatos = FuentesDeDatos;
        }

        private void FrmVistaPrevia_Load(object sender, EventArgs e)
        {
            if (_FuentesDeDatos == null)
            {
                ReporteadorRpvVistaPrevia.LocalReport.ReportPath = _RutaReporte;
                ReporteadorRpvVistaPrevia.RefreshReport();
                return;
            }

            ReporteadorMetCargarReporteDinamico(_RutaReporte, _FuentesDeDatos);
        }

        // CARGAR EL RDLC Y AGREGAR SOLAMENTE LOS DATASETS QUE NECESITA
        private void ReporteadorMetCargarReporteDinamico(string RutaRdlc, Dictionary<string, object> FuentesDeDatos)
        {
            if (!File.Exists(RutaRdlc))
            {
                MessageBox.Show("No se encontro el reporte en: " + RutaRdlc);
                return;
            }

            ReporteadorRpvVistaPrevia.Reset();
            ReporteadorRpvVistaPrevia.ProcessingMode = ProcessingMode.Local;
            ReporteadorRpvVistaPrevia.LocalReport.ReportPath = RutaRdlc;

            // OBTENER LOS NOMBRES DE DATASET QUE PIDE EL ARCHIVO RDLC
            IList<string> DatasetsRequeridos = ReporteadorRpvVistaPrevia.LocalReport.GetDataSourceNames();

            if (FuentesDeDatos == null)
            {
                FuentesDeDatos = new Dictionary<string, object>();
            }

            foreach (string NombreDataset in DatasetsRequeridos)
            {
                if (FuentesDeDatos.ContainsKey(NombreDataset))
                {
                    object Datos = FuentesDeDatos[NombreDataset];

                    ReportDataSource Fuente = new ReportDataSource(NombreDataset, Datos);

                    ReporteadorRpvVistaPrevia.LocalReport.DataSources.Add(Fuente);
                }
                else
                {
                    MessageBox.Show("Advertencia: El reporte requiere el DataSet '" + NombreDataset + "', pero no fue provisto."
                    );
                }
            }

            ReporteadorRpvVistaPrevia.RefreshReport();
        }
    }
}
