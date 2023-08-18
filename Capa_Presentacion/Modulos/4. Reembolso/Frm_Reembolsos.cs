using Capa_Negocio;
using Capa_Presentacion.Modulos._3._Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Reembolsos : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

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
            cmb_Filtro_Pago.SelectedIndex = 0;
            cmb_Filtro_Reembolso.SelectedIndex = 0;
        }

        private IEnumerable<Object> CargarRegistrosReembolso()
        {
            var getReembolso = objCapaNegocio.CN_DevolverReembolso()
                            .Select(r => new
                            {
                                CODIGO = r.Id,
                                Identificador_Factura = r.IdFactura,
                                Cliente = objCapaNegocio.CN_DevolverFactura().Join(
                                        objCapaNegocio.CN_DevolverCliente(),
                                        f => f.IdCliente,
                                        cl => cl.Id,
                                        (f, cl) =>
                                            cl.Nombres+" "+cl.Apellidos).FirstOrDefault(),
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
    }
}
