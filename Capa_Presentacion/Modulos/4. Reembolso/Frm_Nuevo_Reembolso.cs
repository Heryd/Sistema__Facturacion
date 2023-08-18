using Capa_Datos.Entidades;
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
            LimpiarCampos();
        }

        private void LimpiarCampos()
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
            txt_Motivo_Reembolso.Text = "";
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
            int codigoFactura = 0, codigoPago = 0;

            if (!Txt_Id_Pago.Text.Equals("") && !txt_Codigo_Factura.Texts.Trim().Equals(""))
            {
                codigoFactura = int.Parse(txt_Codigo_Factura.Texts.Trim().ToString());
                codigoPago = int.Parse(Txt_Id_Pago.Text.Trim().ToString());

                var facturaInfo = objCapaNegocio.CN_DevolverFactura()
                    .Where(f => f.Id == codigoFactura || f.IdPago ==codigoPago)
                    .Select(f => new
                    {
                        f.Fecha,
                        Cedula_Cliente = objCapaNegocio.CN_DevolverCliente()
                                        .Where(cl => cl.Id == f.IdCliente)
                                        .Select(cl => cl.Cedula)
                                        .FirstOrDefault(),
                        Nombres_Cliente = objCapaNegocio.CN_DevolverCliente()
                                        .Where(cl => cl.Id == f.IdCliente)
                                        .Select(cl => cl.Nombres + " " + cl.Apellidos)
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
                    btn_Registrar.Enabled = true;
                    txt_Motivo_Reembolso.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la factura", "Buscar código de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor digite primero el código de su Factura", "Buscar código de Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Reembolso r = new Reembolso()
                {
                    Fecha = DateTime.Today,
                    Motivo = txt_Motivo_Reembolso.Text.Trim(),
                    Cedula = decimal.Parse(txt_Cedula.Text.Trim()),
                    IdFactura = int.Parse(txt_Codigo_Factura.Texts.Trim()),
                    IdPago = int.Parse(Txt_Id_Pago.Text.Trim())
                };
                objCapaNegocio.CN_Nuevo_Reembolso(r);
                LimpiarCampos();
            }
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(Txt_Id_Pago.Text))
            {
                mensajeValidacion += "\n\t- Código del Pago";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Codigo_Factura.Texts))
            {
                mensajeValidacion += "\n\t- Código de la Factura";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Motivo_Reembolso.Text))
            {
                mensajeValidacion += "\n\t- Motivo del Reembolso";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        private void txt_Motivo_Reembolso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Motivo_Reembolso.Text.Length <= 175)
            {
                e.Handled = false;
            }
            else if (c == (char)Keys.Back || c == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Motivo_Reembolso.Text.Length > 175 && c != ((char)Keys.Back))
            {
                MessageBox.Show("El motivo del reembolso solo puede contener 175 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
