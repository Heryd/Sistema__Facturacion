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
    public partial class Frm_Actualizar_Pago : Form
    {
        public Frm_Actualizar_Pago()
        {
            InitializeComponent();
        }

        private void btnCloseActPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtActImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumerosDecimales(e);
        }

        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {

        }
    }
}
