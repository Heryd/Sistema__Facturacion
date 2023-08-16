using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
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
        #region Atributos
        /// <summary>
        /// Ojbeto de solo lectura para la invocación de los métodos de la clase <b>CN_GetData</b>
        /// </summary> 
        private readonly CN_GetData objCapaNegocio = new CN_GetData();
        /// <summary>
        /// Índice que servirá para la correspondiente aplicación de filtros.
        /// </summary>
        private int opcFiltro = -1;
        #endregion

        public Frm_Facturas()
        {
            InitializeComponent();
            Select_First_Index_ComboBox();
        }

        private void Select_First_Index_ComboBox()
        {
            cmb_Filtro_Facturas.SelectedIndex = 0;
            //cmb_Filtro_Cliente.SelectedIndex = 0;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Facturas_Load(object sender, EventArgs e)
        {
            dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Facturas);
        }

        private IEnumerable<Object> CargarRegistrosDataGridView()
        {
            var facturas = objCapaNegocio.CN_DevolverFactura()
                                .Select(f => new
                                {
                                    CODIGO = f.IdDetalleFactura,
                                    NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                                                objCapaNegocio.CN_DevolverCliente(),
                                                fc => f.IdCliente,
                                                cl => cl.Id,
                                                (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                                    SERVICIO = f.Descripcion,
                                    METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                                .Where(p => p.IdCliente == f.IdCliente)
                                                .Select(p => p.MetodoPago)
                                                .FirstOrDefault(),
                                    TOTAL = f.Total,
                                    FECHA = f.Fecha,
                                    ESTADO = f.Estado
                                }).AsQueryable();

            return facturas;
        }

        private void dtgV_Facturas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            objCapaNegocio.CN_Show_Buttons_DTGV(e, dtgV_Facturas, Properties.Resources.edit_min_20x20, Properties.Resources.delete_min_20x20);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Filtro_Facturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcFiltro = cmb_Filtro_Facturas.SelectedIndex + 1;
            txt_Busqueda.Text = "";
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            switch (opcFiltro)
            {
                case 1:
                var facturas = objCapaNegocio.CN_DevolverFactura()
                            .Where(f => f.Descripcion.Contains(txt_Busqueda.Text.Trim()))
                            .Select(f => new
                            {
                                CODIGO = f.IdDetalleFactura,
                                NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                            objCapaNegocio.CN_DevolverCliente(),
                            fc => f.IdCliente,
                            cl => cl.Id,
                            (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                                SERVICIO = f.Descripcion,
                                METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                            .Where(p => p.IdCliente == f.IdCliente)
                                            .Select(p => p.MetodoPago)
                                            .FirstOrDefault(),
                                TOTAL = f.Total,
                                FECHA = f.Fecha
                            });
                if (facturas.Count() <= 0 || facturas== null)
                {
                    MessageBox.Show("No se encontró el servicio", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (facturas != null)
                {
                    dtgV_Facturas.DataSource = facturas.ToList();

                }
                break;
                case 2:
                var facturaXId = objCapaNegocio.CN_DevolverFactura()
                    .Where(f => f.IdDetalleFactura.ToString().Contains(txt_Busqueda.Text.Trim()))
                    .Select(f => new
                    {
                        CODIGO = f.IdDetalleFactura,
                        NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                            objCapaNegocio.CN_DevolverCliente(),
                            fc => f.IdCliente,
                            cl => cl.Id,
                            (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                        SERVICIO = f.Descripcion,
                        METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                    .Where(p => p.IdCliente == f.IdCliente)
                                    .Select(p => p.MetodoPago)
                                    .FirstOrDefault(),
                        TOTAL = f.Total,
                        FECHA = f.Fecha
                    });
                if (facturaXId.Count() <= 0 || facturaXId == null)
                {
                    MessageBox.Show("No se encontró el Código", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!txt_Busqueda.Text.Trim().Equals(""))
                {
                    dtgV_Facturas.DataSource = facturaXId.ToList();
                }
                else
                {
                    dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
                }
                break;
                case 3:
                var facturaXFecha = objCapaNegocio.CN_DevolverFactura()
                        .Where(f => f.Fecha.ToString().Contains(txt_Busqueda.Text.Trim()))
                        .Select(f => new
                        {
                            CODIGO = f.IdDetalleFactura,
                            NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                            objCapaNegocio.CN_DevolverCliente(),
                            fc => f.IdCliente,
                            cl => cl.Id,
                            (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                            SERVICIO = f.Descripcion,
                            METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                        .Where(p => p.IdCliente == f.IdCliente)
                                        .Select(p => p.MetodoPago)
                                        .FirstOrDefault(),
                            TOTAL = f.Total,
                            FECHA = f.Fecha
                        });
                if (facturaXFecha.Any())
                {
                    dtgV_Facturas.DataSource = facturaXFecha.ToList();

                }
                else
                {
                    MessageBox.Show("No se encontró la fecha", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 4:
                    var facturaXMonto = objCapaNegocio.CN_DevolverFactura()
                        .Where(f => f.Total.ToString().Contains(txt_Busqueda.Text.Trim()))
                        .Select(f => new
                        {
                            CODIGO = f.IdDetalleFactura,
                            NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                            objCapaNegocio.CN_DevolverCliente(),
                            fc => f.IdCliente,
                            cl => cl.Id,
                            (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                            SERVICIO = f.Descripcion,
                            METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                        .Where(p => p.IdCliente == f.IdCliente)
                                        .Select(p => p.MetodoPago)
                                        .FirstOrDefault(),
                            TOTAL = f.Total,
                            FECHA = f.Fecha,
                            f.Estado
                        });
                if (facturaXMonto.Any())
                {
                    dtgV_Facturas.DataSource = facturaXMonto.ToList();

                }
                else
                {
                    MessageBox.Show("No se encontró el Monto", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 5:
                var facturaXCedula = objCapaNegocio.CN_DevolverFactura()
                    .Where(f => f.CedulaCliente.ToString().Contains(txt_Busqueda.Text.Trim().ToString()))
                    .Select(f => new
                    {
                        CODIGO = f.IdDetalleFactura,
                        NOMBRES = objCapaNegocio.CN_DevolverFactura().Join(
                            objCapaNegocio.CN_DevolverCliente(),
                            fc => f.IdCliente,
                            cl => cl.Id,
                            (fc, cl) => cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                        SERVICIO = f.Descripcion,
                        METODO_PAGO = objCapaNegocio.CN_DevolverPago()
                                    .Where(p => p.IdCliente == f.IdCliente)
                                    .Select(p => p.MetodoPago)
                                    .FirstOrDefault(),
                        TOTAL = f.Total,
                        FECHA = f.Fecha,
                        ESTADO = f.Estado
                    }).AsQueryable();
                if (facturaXCedula.Count() <= 0 || facturaXCedula == null)
                {
                    MessageBox.Show("No se encontró la Cédula", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (facturaXCedula.Any())
                {
                    dtgV_Facturas.DataSource = facturaXCedula.ToList();

                }
                break;
                default:
                break;
            }
        }

        private void dtgV_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string indice = dtgV_Facturas.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

            if (dtgV_Facturas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                Frm_Actualizar_Factura frm_Update = new Frm_Actualizar_Factura(indice);
                frm_Update.ShowDialog();
            }
        }
    }
}
