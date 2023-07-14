using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Nueva_Factura : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nueva_Factura()
        {
            InitializeComponent();
            txt_fecha.Text = Get_Date();
            chb_IVA.Checked = false;
            cmb_Metodo_Pago.SelectedIndex = 0;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chb_IVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_IVA.Checked)
            {
                chb_IVA.ForeColor = Color.Green;
                lbl_IVA_Value.Text = "0.12";
            }
            else
            {
                lbl_IVA_Value.Text = "0.00";
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Codigo_Cliente.Texts = "";
            txt_Cedula.Texts = "";
            txt_Nombre.Texts = "";
            txt_Telefono.Texts = "";
            cmb_Metodo_Pago.SelectedIndex = 0;
            txt_Descripcion.Text = "";
            nmUD_Cantidad.Value = 1;
            txt_Nombre_Encargado.Texts = "";
            txt_Valor_Pago.Text = "";
            chb_IVA.Checked = false;
            lbl_IVA_Value.Text = "0.00";
            txt_Subtotal.Text = "0.00";
            txt_Vuelto.Text = "0.00";
            txt_Total.Text = "0.00";
        }

        private void txt_Codigo_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
