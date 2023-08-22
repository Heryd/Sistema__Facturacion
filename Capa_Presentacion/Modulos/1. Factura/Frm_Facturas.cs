using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            var facturas = objCapaNegocio.CN_DevolverFactura().OrderBy(f=> f.Id)
                                .Select(f => new
                                {
                                    CODIGO = f.Id,
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
                if (txt_Busqueda.Text.Equals(""))
                {
                    dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
                    lbl_Error.Visible = false;
                }
                if (facturas != null && facturas.Any())
                {
                    dtgV_Facturas.DataSource = facturas.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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
                if (txt_Busqueda.Text.Equals(""))
                {
                    dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
                    lbl_Error.Visible = false;
                }
                if (facturaXId != null && facturaXId.Any())
                {
                    dtgV_Facturas.DataSource = facturaXId.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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
                if (txt_Busqueda.Text.Equals(""))
                {
                    dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
                    lbl_Error.Visible = false;
                }
                if (facturaXFecha != null && facturaXFecha.Any())
                {
                    dtgV_Facturas.DataSource = facturaXFecha.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
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
                if (txt_Busqueda.Text.Equals(""))
                {
                    dtgV_Facturas.DataSource = CargarRegistrosDataGridView().ToList();
                    lbl_Error.Visible = false;
                }
                if (facturaXMonto != null && facturaXMonto.Any())
                {
                    dtgV_Facturas.DataSource = facturaXMonto.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
                }
                break;
                case 5:
                var facturaXCedula = objCapaNegocio.CN_DevolverFactura()
                    .Where(f => ("0"+f.CedulaCliente).ToString().Contains(txt_Busqueda.Text.Trim().ToString()))
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
                if (txt_Busqueda.Text.Equals(""))
                {
                    dtgV_Facturas.DataSource=CargarRegistrosDataGridView().ToList();
                    lbl_Error.Visible = false;
                }
                if (facturaXCedula!=null && facturaXCedula.Any())
                {
                    dtgV_Facturas.DataSource = facturaXCedula.ToList();
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

        private void dtgV_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string indice = dtgV_Facturas.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

            if (dtgV_Facturas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                Frm_Actualizar_Factura frm_Update = new Frm_Actualizar_Factura(indice);
                frm_Update.ShowDialog();
            }
        }

        //Al momento de ejecutarse el evento KeyPress, permitirá el ingreso de dígitos o caracteres según el índice en el que se encuentre el filtro del combobox
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            switch (opcFiltro)
            {
                //Si el filtro seleccionado es: 
                //[1]: Descripción del Servicio
                //entonces el evento keyPress solo permitirá el ingreso de letras
                case 1:
                if (Char.IsLetter(c) && txt_Busqueda.Text.Length <= 30)
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
                if (txt_Busqueda.Text.Length > 30 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda solo puede incluir 30 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[2]: Código,
                //[4]: Monto,
                //[6]: Cédula
                //entonces el evento keyPress solo permitirá el ingreso de dígitos, hasta un máximo de 10
                case 2:
                case 4:
                case 5:
                if (Char.IsDigit(c) && txt_Busqueda.Text.Length <= 10)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txt_Busqueda.Text.Length > 10 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[3]: Fecha del Registro
                //entonces el evento keyPress solo permitirá el ingreso de la fecha en formato dd/MM/YYYY, has
                case 3:
                if (Char.IsDigit(c) && txt_Busqueda.Text.Length <= 10)
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
                if (txt_Busqueda.Text.Length > 9 && c != ((char)Keys.Back))
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
