using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Actualizar_Reembolso : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Actualizar_Reembolso(int codigo_reembolso)
        {
            InitializeComponent();
            CargarElementos();
            RetornarValoresReembolso(codigo_reembolso);
        }

        //Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarElementos()
        {
            txt_fecha.Text = Get_Date();
            cmb_Estado.SelectedIndex = 0;
        }

        private void RetornarValoresReembolso(int codigo)
        {
            var reembolsoData = objCapaNegocio.CN_DevolverReembolso()
        .Where(r => r.Id == codigo)
        .Join(objCapaNegocio.CN_DevolverFactura(),
            r => r.IdFactura,
            f => f.Id,
            (r, f) => new { Reembolso = r, Factura = f })
        .Join(objCapaNegocio.CN_DevolverCliente(),
            rf => rf.Factura.IdCliente,
            cl => cl.Id,
            (rf, cl) => new { ReembolsoFactura = rf, Cliente = cl })
        .Select(result => new
        {
            CEDULA = result.Cliente.Cedula,
            NOMBRES = result.Cliente.Nombres+ " " +result.Cliente.Apellidos,
            result.ReembolsoFactura.Reembolso.Fecha,
            ESTADO_PAGO = "REEMBOLSADO",
            result.ReembolsoFactura.Reembolso.Motivo
        }).FirstOrDefault();

            if (reembolsoData != null)
            {
                txt_fecha.Text = reembolsoData.Fecha.ToString("dddd dd MMMM, yyyy", CultureInfo.CreateSpecificCulture("es-ES"));
                txt_Motivo_Reembolso.Text = reembolsoData.Motivo.ToString();
                cmb_Estado.SelectedIndex = 2;
                txt_Cedula.Text = reembolsoData.CEDULA.ToString();
                txt_Nombres_Cliente.Text = reembolsoData.NOMBRES.ToString();
            }
        }
    }
}
