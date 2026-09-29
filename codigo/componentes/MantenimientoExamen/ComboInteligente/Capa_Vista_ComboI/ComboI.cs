using CapaControlador_prototipoumg2k26;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_ComboI
{
    public partial class ComboI : UserControl
    {

        public ComboI()
        {
            InitializeComponent();
        }

        ModeloComboI controlador = new ModeloComboI();
        public void llenarCombo(string _tabla, string _campo1, string _campo2)
        {
            var dtTabla = controlador.enviarDatos(_tabla, _campo1, _campo2);

            cboPrueba.DataSource = dtTabla;
            cboPrueba.ValueMember = _campo1;
            cboPrueba.DisplayMember = _campo2;

            AutoCompleteStringCollection coleccion =
                new AutoCompleteStringCollection();

            foreach (DataRow row in dtTabla.Rows)
            {
                coleccion.Add(
                    Convert.ToString(row[_campo1]) + " - " +
                    Convert.ToString(row[_campo2])
                );

                coleccion.Add(
                    Convert.ToString(row[_campo2]) + " - " +
                    Convert.ToString(row[_campo1])
                );
            }

            cboPrueba.AutoCompleteCustomSource = coleccion;
            cboPrueba.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPrueba.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}