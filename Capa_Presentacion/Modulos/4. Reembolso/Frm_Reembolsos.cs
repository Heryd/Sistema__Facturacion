using Capa_Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Reembolsos : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

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

        private void CargarRegistrosReembolso()
        {
            var getReembolso = objCapaNegocio.CN_DevolverReembolso()
                            .Select(r => new
                            {
                                Id_Reembolso = r.Id,
                                Identificador_Factura = r.IdFactura,
                                Cliente = objCapaNegocio.CN_DevolverFactura().Join(
                                        objCapaNegocio.CN_DevolverCliente(),
                                        f => f.IdCliente,
                                        cl => cl.Id,
                                        (f, cl) =>
                                            cl.Apellidos + " " + cl.Nombres).FirstOrDefault(),
                                Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                            .Join(objCapaNegocio.CN_DevolverCliente(),
                                                    p => p.IdCliente,
                                                    cl => cl.Id,
                                                    (p, cl) => p.MetodoPago).FirstOrDefault(),
                                Estado_Pago = objCapaNegocio.CN_DevolverFactura()
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
                            }).ToList();
            dtgV_Reembolsos.DataSource = getReembolso;

        }
        private void dtgV_Reembolsos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgV_Reembolsos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
