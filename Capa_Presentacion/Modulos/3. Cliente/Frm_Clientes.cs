using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
            CargarElementos();
        }

        private void CargarElementos()
        {
            cmb_Filtro_Cliente.SelectedIndex= 0;
            cmb_Filtro_Pago.SelectedIndex= 0;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Frm_Actualizar_Cliente frm_Update_Cliente = new Frm_Actualizar_Cliente();
            frm_Update_Cliente.ShowDialog();
        }
    }
}
