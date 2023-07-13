using Capa_Negocio;
using System;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Nuevo_Cliente : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Cliente()
        {
            InitializeComponent();
            CargarElementos();

        }

        private void CargarElementos()
        {
            txt_fecha.Text=Get_Date();
            cmb_Genero.SelectedIndex = 0;
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Cedula.Texts = "";
            txt_Apellidos.Texts = "";
            txt_Nombres.Texts = "";
            cmb_Genero.SelectedIndex=0;
            txt_Correo.Texts = "";
            txt_Direccion.Texts = "";
            txt_Telefono.Texts = "";
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
