using Capa_Datos.Entidades;
using Capa_Negocio;
using Capa_Presentacion.Modulos._3._Cliente;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Reembolsos : Form
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

        #region Inicialización del Constructor
        /// <summary>
        /// Inicializa los componentes y carga los registros de tipo reembolso al DataGridView.
        /// </summary> 
        #endregion
        public Frm_Reembolsos()
        {
            InitializeComponent();
            CargarElementos();
            CargarRegistrosReembolso();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarElementos()
        {
            cmb_Filtro_Reembolso.SelectedIndex = 0;
        }

        private IEnumerable<Object> CargarRegistrosReembolso()
        {
            var getReembolso = objCapaNegocio.CN_DevolverReembolso()
                            .Select(r => new
                            {
                                CODIGO = r.Id,
                                Identificador_Factura = r.IdFactura,
                                Cliente = objCapaNegocio.CN_DevolverFactura()
                                            .Where(f => f.Id == r.Id)
                                        .Join(objCapaNegocio.CN_DevolverCliente(),
                                        f => f.IdCliente,
                                        cl => cl.Id,
                                        (f, cl) =>
                                            cl.Nombres + " " + cl.Apellidos).FirstOrDefault(),
                                Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                            .Join(objCapaNegocio.CN_DevolverCliente(),
                                                    p => p.IdCliente,
                                                    cl => cl.Id,
                                                    (p, cl) => p.MetodoPago).FirstOrDefault(),
                                r.Motivo,
                                ESTADO = objCapaNegocio.CN_DevolverFactura()
                                             .Join(objCapaNegocio.CN_DevolverCliente(),
                                             fact => fact.IdCliente,
                                             cl => cl.Id,
                                             (fact, cl) => new { fact, cl })
                                             .Join(objCapaNegocio.CN_DevolverPago(),
                                             p => p.fact.Estado == "ANULADO",
                                             pago => pago.Estado == "REEMBOLSADO",
                                             (p, pago) => pago.Estado)
                                             .FirstOrDefault(),
                                r.Fecha
                            }).AsQueryable();

            return getReembolso;
        }

        private void dtgV_Reembolsos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string indice = dtgV_Reembolsos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            //Edita una fila seleccionada enviando los valores a otro formulario
            if (dtgV_Reembolsos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                Frm_Actualizar_Reembolso frm_Update = new Frm_Actualizar_Reembolso(int.Parse(indice));
                frm_Update.ShowDialog();
                CargarRegistrosReembolso();
            }

            //Envía el código del cliente al método Eliminar Cliente de la Capa negocio
            if (dtgV_Reembolsos.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                DialogResult dg = MessageBox.Show("¿Está seguro de eliminar el reembolso?", "Eliminar Reembolso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    objCapaNegocio.CN_EliminarReembolso(indice);
                    CargarRegistrosReembolso();
                }
            }
        }

        private void dtgV_Reembolsos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            objCapaNegocio.CN_Show_Buttons_DTGV(e, dtgV_Reembolsos, Properties.Resources.edit_min_20x20, Properties.Resources.delete_min_20x20);

        }

        private void Frm_Reembolsos_Load(object sender, EventArgs e)
        {
            dtgV_Reembolsos.DataSource = CargarRegistrosReembolso().ToList();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Reembolsos);
        }

        private void cmb_Filtro_Reembolso_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_object = cmb_Filtro_Reembolso.SelectedIndex + 1;
            txtBusquedaReembolso.Text = "";
        }

        private void txtBusquedaReembolso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            switch (index_object)
            {
                //Si el filtro seleccionado es: 
                //[1]: Código,
                //[3]: Monto,
                //entonces el evento keyPress solo permitirá el ingreso de dígitos, hasta un máximo de 10
                case 1:
                case 3:
                if (Char.IsDigit(c) && txtBusquedaReembolso.Text.Length <= 10)
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
                if (txtBusquedaReembolso.Text.Length > 10 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                case 2:
                if (Char.IsDigit(c) && txtBusquedaReembolso.Text.Length <= 10)
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
                if (txtBusquedaReembolso.Text.Length > 10 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                default:
                break;
            }
        }

        private void txtBusquedaReembolso_TextChanged(object sender, EventArgs e)
        {
            switch (index_object)
            {
                case 1:
                var getReembolso = objCapaNegocio.CN_DevolverReembolso()
                        .Where(rm => rm.Id.ToString().Contains(txtBusquedaReembolso.Text.Trim()))
                        .Select(r => new
                        {
                            CODIGO = r.Id,
                            Identificador_Factura = r.IdFactura,
                            Cliente = objCapaNegocio.CN_DevolverFactura()
                                        .Where(f => f.Id == r.Id)
                                        .Join
                                        (
                                            objCapaNegocio.CN_DevolverCliente(),
                                            f => f.IdCliente,
                                            cl => cl.Id,
                                            (f, cl) => cl.Nombres + " " + cl.Apellidos
                                        ).FirstOrDefault(),
                            Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                                    .Join(objCapaNegocio.CN_DevolverCliente(),
                                                            p => p.IdCliente,
                                                            cl => cl.Id,
                                                            (p, cl) => p.MetodoPago).FirstOrDefault(),
                            r.Motivo,
                            ESTADO = objCapaNegocio.CN_DevolverFactura()
                                        .Join(objCapaNegocio.CN_DevolverCliente(),
                                         fact => fact.IdCliente,
                                         cl => cl.Id,
                                         (fact, cl) => new { fact, cl })
                                         .Join(objCapaNegocio.CN_DevolverPago(),
                                         p => p.fact.Estado == "ANULADO",
                                         pago => pago.Estado == "REEMBOLSADO",
                                         (p, pago) => pago.Estado)
                                         .FirstOrDefault(),
                            r.Fecha
                        }).AsQueryable();
                if (txtBusquedaReembolso.Equals(""))
                {
                    lbl_Error.Visible = false;
                    dtgV_Reembolsos.DataSource = CargarRegistrosReembolso().ToList();
                }
                if (getReembolso != null && getReembolso.Any())
                {
                    dtgV_Reembolsos.DataSource = getReembolso.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
                }
                break;
                case 2:
                var getReembolsoXFecha = objCapaNegocio.CN_DevolverReembolso()
                    .Where(rm => rm.Fecha.ToString().Contains(txtBusquedaReembolso.Text.Trim()))
                    .Select(r => new
                    {
                        CODIGO = r.Id,
                        Identificador_Factura = r.IdFactura,
                        Cliente = objCapaNegocio.CN_DevolverFactura()
                                    .Where(f => f.Id == r.Id)
                                    .Join
                                    (
                                        objCapaNegocio.CN_DevolverCliente(),
                                        f => f.IdCliente,
                                        cl => cl.Id,
                                        (f, cl) => cl.Nombres + " " + cl.Apellidos
                                    ).FirstOrDefault(),
                        Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                                .Join(objCapaNegocio.CN_DevolverCliente(),
                                                        p => p.IdCliente,
                                                        cl => cl.Id,
                                                        (p, cl) => p.MetodoPago).FirstOrDefault(),
                        r.Motivo,
                        ESTADO = objCapaNegocio.CN_DevolverFactura()
                                    .Join(objCapaNegocio.CN_DevolverCliente(),
                                     fact => fact.IdCliente,
                                     cl => cl.Id,
                                     (fact, cl) => new { fact, cl })
                                     .Join(objCapaNegocio.CN_DevolverPago(),
                                     p => p.fact.Estado == "ANULADO",
                                     pago => pago.Estado == "REEMBOLSADO",
                                     (p, pago) => pago.Estado)
                                     .FirstOrDefault(),
                        r.Fecha
                    }).AsQueryable();
                if (txtBusquedaReembolso.Equals(""))
                {
                    lbl_Error.Visible = false;
                    dtgV_Reembolsos.DataSource = CargarRegistrosReembolso().ToList();
                }
                if (getReembolsoXFecha != null && getReembolsoXFecha.Any())
                {
                    dtgV_Reembolsos.DataSource = getReembolsoXFecha.ToList();
                    lbl_Error.Visible = false;
                }
                else
                {
                    Coincidencias();
                }
                break;
                case 3:
                var getReembolsoXIdFactura = objCapaNegocio.CN_DevolverReembolso()
                .Where(rm => rm.IdFactura.ToString().Contains(txtBusquedaReembolso.Text.Trim()))
                .Select(r => new
                {
                    CODIGO = r.Id,
                    Identificador_Factura = r.IdFactura,
                    Cliente = objCapaNegocio.CN_DevolverFactura()
                                .Where(f => f.Id == r.Id)
                                .Join
                                (
                                    objCapaNegocio.CN_DevolverCliente(),
                                    f => f.IdCliente,
                                    cl => cl.Id,
                                    (f, cl) => cl.Nombres + " " + cl.Apellidos
                                ).FirstOrDefault(),
                    Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                            .Join(objCapaNegocio.CN_DevolverCliente(),
                                                    p => p.IdCliente,
                                                    cl => cl.Id,
                                                    (p, cl) => p.MetodoPago).FirstOrDefault(),
                    r.Motivo,
                    ESTADO = objCapaNegocio.CN_DevolverFactura()
                                .Join(objCapaNegocio.CN_DevolverCliente(),
                                 fact => fact.IdCliente,
                                 cl => cl.Id,
                                 (fact, cl) => new { fact, cl })
                                 .Join(objCapaNegocio.CN_DevolverPago(),
                                 p => p.fact.Estado == "ANULADO",
                                 pago => pago.Estado == "REEMBOLSADO",
                                 (p, pago) => pago.Estado)
                                 .FirstOrDefault(),
                    r.Fecha
                }).AsQueryable();
                if (txtBusquedaReembolso.Equals(""))
                {
                    lbl_Error.Visible = false;
                    dtgV_Reembolsos.DataSource = CargarRegistrosReembolso().ToList();
                }
                if (getReembolsoXIdFactura != null && getReembolsoXIdFactura.Any())
                {
                    dtgV_Reembolsos.DataSource = getReembolsoXIdFactura.ToList();
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

        private void Coincidencias()
        {
            lbl_Error.Visible = true;
            lbl_Error.Text = "No se encontraron coincidencias (*)";
            lbl_Error.ForeColor = Color.OrangeRed;
        }
    }
}
