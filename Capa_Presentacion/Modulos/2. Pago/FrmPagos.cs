using Capa_Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._2._Pago
{
    public partial class FrmPagos : Form
    {
        #region Atributos
        /// <summary>
        /// Ojbeto de solo lectura para la invocación de los métodos de la clase <b>CN_GetData</b>
        /// </summary> 
        private readonly CN_GetData objCapaNegocio = new CN_GetData();
        /// <summary>
        /// Índice que servirá para la correspondiente aplicación de filtros.
        /// </summary>
        private int index_object = -1;
        #endregion

        public FrmPagos()
        {
            InitializeComponent();
            CargarDatosDataGridView();
            cmbFiltroPagos.SelectedIndex = 0;
        }

        private void btnClosePagos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            switch (index_object)
            {
                case 1:
                var pagos = objCapaNegocio.CN_DevolverPago()
                            .Where(p => p.Estado.ToString().Contains(txtBusquedaPago.Text.Trim()))
                               .Select(p => new
                               {
                                   CODIGO = p.Id,
                                   CLIENTE = objCapaNegocio.CN_DevolverCliente()
                                            .Where(cl => cl.Id == p.IdCliente)
                                            .Select(cl => cl.Nombres + " " + cl.Apellidos)
                                            .FirstOrDefault(),
                                   FECHA = p.Fecha,
                                   METODO_PAGO = p.MetodoPago,
                                   MONTO = p.Valor,
                                   ESTADO = p.Estado
                               });
                if (pagos.Count() <= 0 || pagos == null)
                {
                    MessageBox.Show("No se hallaron coincidencias", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pagos.Any())
                {
                    dtgV_Pagos.DataSource = pagos.ToList();

                }
                break;
                case 2:
                var pagosXFecha = objCapaNegocio.CN_DevolverPago()
                        .Where(p => p.Fecha.ToString().Contains(txtBusquedaPago.Text.Trim().ToString()))
                           .Select(p => new
                           {
                               CODIGO = p.Id,
                               CLIENTE = objCapaNegocio.CN_DevolverCliente()
                                        .Where(cl => cl.Id == p.IdCliente)
                                        .Select(cl => cl.Nombres + " " + cl.Apellidos)
                                        .FirstOrDefault(),
                               FECHA = p.Fecha,
                               METODO_PAGO = p.MetodoPago,
                               MONTO = p.Valor,
                               ESTADO = p.Estado
                           });
                if (pagosXFecha.Count() <= 0 || pagosXFecha == null)
                {
                    MessageBox.Show("No se hallaron coincidencias", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pagosXFecha.Any())
                {
                    dtgV_Pagos.DataSource = pagosXFecha.ToList();

                }
                break;
                case 3:
                var pagosXMonto = objCapaNegocio.CN_DevolverPago()
                    .Where(p => p.Valor.ToString().Contains(txtBusquedaPago.Text.Trim().ToString()))
                       .Select(p => new
                       {
                           CODIGO = p.Id,
                           CLIENTE = objCapaNegocio.CN_DevolverCliente()
                                    .Where(cl => cl.Id == p.IdCliente)
                                    .Select(cl => cl.Nombres + " " + cl.Apellidos)
                                    .FirstOrDefault(),
                           FECHA = p.Fecha,
                           METODO_PAGO = p.MetodoPago,
                           MONTO = p.Valor,
                           ESTADO = p.Estado
                       });
                if (pagosXMonto.Count() <= 0 || pagosXMonto == null)
                {
                    MessageBox.Show("No se hallaron coincidencias", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pagosXMonto.Any())
                {
                    dtgV_Pagos.DataSource = pagosXMonto.ToList();

                }
                break;
                default:
                break;
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
                             .Select(cl => cl.Nombres + " " + cl.Apellidos)
                             .FirstOrDefault(),
                    FECHA = p.Fecha,
                    METODO_PAGO = p.MetodoPago,
                    MONTO = p.Valor,
                    ESTADO = p.Estado
                });
            dtgV_Pagos.DataSource = pagos.ToList();
        }

        //private void MostrarElementos()
        //{
        //    if (cmbFiltroPagos.SelectedIndex == 3)
        //    {
        //        cmbFiltrarMonto.Visible = true;
        //        txt_Valor1.Visible = true;
        //    }
        //}

        private void cmbFiltroPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

            index_object = cmbFiltroPagos.SelectedIndex + 1;
            txtBusquedaPago.Text = "";
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