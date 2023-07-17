using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Actualizar_Cliente : Form
    {
        public Frm_Actualizar_Cliente(string indice, string cedula, string nombre, string apellido, string correo, string genero)
        {
            InitializeComponent();
            txt_Codigo_Cliente.Texts= indice;
            txt_Cedula.Text = "0" + cedula;
            txt_Nombres.Text= nombre.ToUpper();
            txt_Apellidos.Text = apellido.ToUpper();
            txt_Correo.Text = correo;
            Set_Item_ComboBox(genero.ToUpper());
        }

        private void Set_Item_ComboBox(String genero)
        {
            switch (genero)
            {
                case "MASCULINO":
                    cmb_Genero.SelectedIndex = 1;
                break;
                case "FEMENINO":
                    cmb_Genero.SelectedIndex = 2;
                break;
                case "PREFIERO NO DECIRLO":
                    cmb_Genero.SelectedIndex = 3;
                break;
            }
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Cedula_Load(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnActCliente(object sender, EventArgs e)
        {

        }

        private void btnCancelarAtc(object sender, EventArgs e)
        {

        }

        private void btn_CloseForm_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
