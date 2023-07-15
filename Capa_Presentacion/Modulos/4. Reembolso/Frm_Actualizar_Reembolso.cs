using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Actualizar_Reembolso : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Actualizar_Reembolso()
        {
            InitializeComponent();
            CargarElementos();

        }

        //Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarElementos()
        {
            txt_fecha.Text = Get_Date();
            cmb_Estado.SelectedIndex = 0;
        }
    }
}
