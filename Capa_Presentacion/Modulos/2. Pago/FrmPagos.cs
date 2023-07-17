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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void btnClosePagos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            Frm_Actualizar_Pago Acceso=new Frm_Actualizar_Pago();
            Acceso.ShowDialog();
        }
    }
}
