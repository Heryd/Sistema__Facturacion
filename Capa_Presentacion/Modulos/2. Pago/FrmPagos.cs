using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._2._Pago
{
    public partial class FrmPagos : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public FrmPagos()
        {
            InitializeComponent();
            cmbFiltrarMonto.Visible = false;
            txt_Valor1.Visible = false;
            txt_Valor2.Visible = false;
            CargarDatosDataGridView();
            cmbFiltroPagos.SelectedIndex = 0;
        }

        private void btnClosePagos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txt_Valor2.Text!=null && !txt_Valor2.Text.Equals(""))
            {
                if (int.Parse(txt_Valor1.Text) >= int.Parse(txt_Valor2.Text))
                {
                    MessageBox.Show("El primer valor del rango no puede ser mayor o igual que el segundo","Error de Rango",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }   
            }
        }

        private void CargarDatosDataGridView()
        {
            var pagos = objCapaNegocio.CN_DevolverPago()
                .Select(p => new
                {
                    CODIGO = p.Id,
                    CLIENTE = objCapaNegocio.CN_DevolverCliente()
                             .Where(cl => cl.Id == p.IdCliente)
                             .Select(cl => cl.Nombres + " "  +cl.Apellidos)
                             .FirstOrDefault(),
                    FECHA = p.Fecha,
                    METODO_PAGO = p.MetodoPago,
                    MONTO = p.Valor

                });
            dtgV_Pagos.DataSource = pagos.ToList();
        }

        private void MostrarElementos()
        {
            if (cmbFiltroPagos.SelectedIndex == 3)
            {
                cmbFiltrarMonto.Visible = true;
                txt_Valor1.Visible = true;
            }
        }

        private void cmbFiltroPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFiltroPagos.SelectedIndex)
            {
                case 1:
                    cmbFiltrarMonto.Visible = false;
                    cmbFiltrarMonto.SelectedIndex = 0;
                    txt_Valor1.Visible = false;
                    txt_Valor2.Visible = false;
                    txt_fecha.Visible = true;
                    txtBusquedaPago.Enabled = false;
                break;
                case 2:
                    cmbFiltrarMonto.Visible = true;
                    cmbFiltrarMonto.SelectedIndex = 0;
                    txt_Valor1.Visible = true;
                    txt_fecha.Visible = false;
                    txtBusquedaPago.Enabled = false;
                break;
                default:
                    cmbFiltrarMonto.Visible = false;
                    cmbFiltrarMonto.SelectedIndex = 0;
                    txt_Valor1.Visible = false;
                    txt_Valor2.Visible = false;
                    txt_fecha.Visible = false;
                    txtBusquedaPago.Enabled = true;
                break;
            }
        }

        private void cmbFiltrarMonto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarMonto.SelectedIndex >= 0 && cmbFiltrarMonto.SelectedIndex < 4)
            {
                txt_Valor1.Visible = true;
                txt_Valor2.Visible = false;
            }
            else if(cmbFiltrarMonto.SelectedIndex==5)
            {
                txt_Valor2.Visible = true;
            }
        }

        private void dtgV_Pagos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            objCapaNegocio.CN_Show_Buttons_DTGV(e, dtgV_Pagos, Properties.Resources.edit_min_20x20, Properties.Resources.delete_min_20x20);
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Pagos);
        }

        private void dtgV_Pagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edita una fila seleccionada enviando los valores a otro formulario
            if (dtgV_Pagos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                string indice = dtgV_Pagos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                Frm_Actualizar_Pago frm_Update = new Frm_Actualizar_Pago(indice);
                frm_Update.ShowDialog();
                CargarDatosDataGridView();
            }

            //Cambia el estado de un registro a "Eliminado"
            if (dtgV_Pagos.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                DialogResult dg = MessageBox.Show("¿Está seguro de Eliminar este Pago?", "Eliminar Pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    //obtienes el valor de la primer columna
                    string indice = dtgV_Pagos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                    objCapaNegocio.CN_EliminarPago(indice);
                    CargarDatosDataGridView();
                }
            }
        }
    }
}