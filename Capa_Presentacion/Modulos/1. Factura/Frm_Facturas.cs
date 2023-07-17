using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Facturas : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

        public Frm_Facturas()
        {
            InitializeComponent();
            Select_First_Index_ComboBox();
        }

        private void Select_First_Index_ComboBox()
        {
            cmb_Filtro_Facturas.SelectedIndex = 0;
            cmb_Filtro_Cliente.SelectedIndex = 0;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
               Frm_Actualizar_Factura frm_update = new Frm_Actualizar_Factura();
               frm_update.ShowDialog();
        }

        private void Frm_Facturas_Load(object sender, EventArgs e)
        {
            CargarRegistrosDataGridView();
        }

        private void CargarRegistrosDataGridView()
        {
            dtgV_Facturas.DataSource = objCapaNegocio.CN_CONSULTAR_CLIENTES();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Facturas);
        }

          private void dtgV_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               if (this.dtgV_Facturas.Columns[e.ColumnIndex].Name == "Editar"&& e.RowIndex >=0)
               {
                    Frm_Actualizar_Factura frm_Update = new Frm_Actualizar_Factura();
                    frm_Update.ShowDialog();
               }
          }

        private void dtgV_Facturas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
               objCapaNegocio.CN_Show_Buttons_DTGV(e,dtgV_Facturas, Properties.Resources.edit_min_20x20, Properties.Resources.delete_min_20x20);
        }
     }
}
