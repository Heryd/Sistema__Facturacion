using Capa_Negocio;
using System;
using System.Drawing;
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
                if (txtBusquedaPago.Text.Equals(""))
                {
                    CargarDatosDataGridView();
                    lbl_Error.Visible = false;
                }
                if (pagos != null && pagos.Any())
                {
                    dtgV_Pagos.DataSource = pagos.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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
                if (txtBusquedaPago.Text.Equals(""))
                {
                    CargarDatosDataGridView();
                    lbl_Error.Visible = false;
                }
                if (pagosXFecha != null && pagosXFecha.Any())
                {
                    dtgV_Pagos.DataSource = pagosXFecha.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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
                if (txtBusquedaPago.Text.Equals(""))
                {
                    CargarDatosDataGridView();
                    lbl_Error.Visible = false;
                }
                if (pagosXMonto != null && pagosXMonto.Any())
                {
                    dtgV_Pagos.DataSource = pagosXMonto.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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

        private void txtBusquedaPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            switch (index_object)
            {
                //Si el filtro seleccionado es: 
                //[1]: Estado del Pago
                //entonces el evento keyPress solo permitirá el ingreso de letras
                case 1:
                if (Char.IsLetter(c) && txtBusquedaPago.Text.Length <= 30)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txtBusquedaPago.Text.Length > 30 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda solo puede incluir 30 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[2]: Fecha del Pago
                //entonces el evento keyPress solo permitirá el ingreso de la fecha en formato dd/MM/YYYY
                case 2:
                if (Char.IsDigit(c) && txtBusquedaPago.Text.Length <= 10)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back || c == '/')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txtBusquedaPago.Text.Length > 9 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[3]: Monto del pago
                //entonces el evento keyPress solo permitirá el ingreso de valores enteros o decimales
                case 3:
                if (Char.IsDigit(c) && txtBusquedaPago.Text.Length <= 10)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back || c == ',')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txtBusquedaPago.Text.Length > 10 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;  
                default:
                break;
            }
        }

        private void Coincidencias()
        {
            lbl_Error.Visible = true;
            lbl_Error.Text = "No se encontraron coincidencias (*)";
            lbl_Error.ForeColor = Color.OrangeRed;
        }
    }
}