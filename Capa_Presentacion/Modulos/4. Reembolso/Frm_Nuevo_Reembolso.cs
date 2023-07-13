using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Nuevo_Reembolso : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Reembolso()
        {
            InitializeComponent();
            CargarElementos();
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void CargarElementos()
        {
            cmb_Estado.SelectedIndex = 0;
            cmb_Metodo_Pago.SelectedIndex = 0;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Codigo_Factura.Texts = "";
            txt_Fecha_Emision.Texts = "";
            cmb_Estado.SelectedIndex = 0;
            cmb_Metodo_Pago.SelectedIndex = 0;
            txt_Cedula.Text = "0000000000";
            txt_Nombres_Cliente.Text = "-------";
            txt_Monto_Pago.Texts = "";
            txt_Motivo_Reembolso.Text = "";
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
