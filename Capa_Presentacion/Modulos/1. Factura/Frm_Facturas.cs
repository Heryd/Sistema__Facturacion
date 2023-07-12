using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Facturas : Form
    {
        public Frm_Facturas()
        {
            InitializeComponent();
            Select_First_Index_ComboBox();
        }

        private void Select_First_Index_ComboBox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Frm_Actualizar_Factura frm_update = new Frm_Actualizar_Factura();
            frm_update.ShowDialog();
        }
    }
}
