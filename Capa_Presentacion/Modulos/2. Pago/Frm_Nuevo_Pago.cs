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

namespace Capa_Presentacion.Modulos._2._Pago
{
    public partial class Frm_Nuevo_Pago : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Pago()
        {
            InitializeComponent();
            txt_Fecha_Pago.Text = objCapaNegocio.ObtenerFechaActual();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseNuevoPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumerosDecimales(e);
        }
    }
}
