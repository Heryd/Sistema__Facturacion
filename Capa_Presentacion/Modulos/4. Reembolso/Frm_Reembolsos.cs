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
    public partial class Frm_Reembolsos : Form
    {
        public Frm_Reembolsos()
        {
            InitializeComponent();
            CargarElementos();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Frm_Actualizar_Reembolso frm_update_Reembolso = new Frm_Actualizar_Reembolso();
            frm_update_Reembolso.ShowDialog();
        }

        private void CargarElementos()
        {
            cmb_Filtro_Pago.SelectedIndex = 0;
            cmb_Filtro_Reembolso.SelectedIndex = 0;
        }

          private void dtgV_Reembolsos_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void dtgV_Reembolsos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
          {

          }
     }
}
