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
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();
    }
}
