using Capa_Negocio;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._4._Reembolso
{
    public partial class Frm_Nuevo_Reembolso : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Reembolso()
        {
            InitializeComponent();
            CargarElementos();
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void CargarElementos()
        {
            cmb_Metodo_Pago.SelectedIndex = 0;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Codigo_Factura.Texts = "";
            Txt_Fecha_Emision.Texts = "";
            cmb_Metodo_Pago.SelectedIndex = 0;
            txt_Cedula.Text = "0000000000";
            txt_Nombres_Cliente.Text = "-------";
            Txt_Valor_Pago.Texts = "";
            txt_Motivo_Reembolso.Text = "";
            Txt_Id_Pago.Text = "";
            txt_Codigo_Factura.Enabled = false;
            btn_Search_Factura.Enabled = false;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Nuevo_Reembolso_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = objCapaNegocio.ObtenerFechaActual();
        }

        private void btn_Search_Factura_Click(object sender, EventArgs e)
        {
            int codigoFactura = int.Parse(txt_Codigo_Factura.Texts);
            int codigoPago = int.Parse(Txt_Id_Pago.Text);

            if (Txt_Id_Pago.Text.Length > 0)
            {
                var facturaInfo = objCapaNegocio.CN_DevolverFactura()
                    .Where(f => f.Id == codigoFactura)
                    .Select(f => new
                    {
                        f.Fecha,
                        Cedula_Cliente = objCapaNegocio.CN_DevolverCliente()
                                        .Where(cl => cl.Id == f.IdCliente)
                                        .Select(cl => cl.Cedula)
                                        .FirstOrDefault(),
                        Nombres_Cliente = objCapaNegocio.CN_DevolverCliente()
                                        .Where(cl => cl.Id == f.IdCliente)
                                        .Select(cl => cl.Apellidos + " " + cl.Nombres)
                                        .FirstOrDefault(),
                        Metodo_Pago = objCapaNegocio.CN_DevolverPago()
                                        .Where(p => p.Id == codigoPago)
                                        .Select(p => p.MetodoPago)
                                        .FirstOrDefault(),
                        Monto = objCapaNegocio.CN_DevolverPago()
                                        .Where(p => p.Id == codigoPago)
                                        .Select(p => p.Valor)
                                        .FirstOrDefault(),
                    }).FirstOrDefault();
                if (facturaInfo != null)
                {
                    Txt_Fecha_Emision.Texts = facturaInfo.Fecha.ToString("dddd dd MMMM, yyyy", CultureInfo.CreateSpecificCulture("es-ES"));
                    txt_Cedula.Text = "0" + facturaInfo.Cedula_Cliente.ToString();
                    txt_Nombres_Cliente.Text = facturaInfo.Nombres_Cliente.ToString();
                    Txt_Valor_Pago.Texts = facturaInfo.Monto.ToString();
                    Set_Combo_Box(facturaInfo.Metodo_Pago.ToString().ToUpper());
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la factura", "Buscar código de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor digite primero el código de su Pago", "Buscar código de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Codigo_Pago_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_Id_Pago_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Id_Pago.Text != null && !Txt_Id_Pago.Equals("") && Txt_Id_Pago.Text.Length > 0)
            {
                txt_Codigo_Factura.Enabled = true;
                btn_Search_Factura.Enabled = true;
            }
            else
            {
                txt_Codigo_Factura.Enabled = false;
                btn_Search_Factura.Enabled = false;
            }
        }

        private void Set_Combo_Box(string cadena)
        {
            switch (cadena)
            {
                case "CREDITO":
                cmb_Metodo_Pago.SelectedIndex = 1;
                break;
                case "DEBITO":
                cmb_Metodo_Pago.SelectedIndex = 2;
                break;
                case "EFECTIVO":
                cmb_Metodo_Pago.SelectedIndex = 3;
                break;
            }
        }
    }
}
