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

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Actualizar_Factura : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Actualizar_Factura(string indice)
        {
            InitializeComponent();
            RetornarDatosFactura(int.Parse(indice));
        }

        //Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        //Cerrar el Formulario
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Encargado.Text))
            {
                mensajeValidacion += "\n\t- Nombre del Encargado";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Descripcion.Text))
            {
                mensajeValidacion += "\n\t- Descripción del Servicio";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Val_Unit.Text))
            {
                mensajeValidacion += "\n\t- Precio Unitario del Servicio";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }
        }

        private void RetornarDatosFactura(int codigo)
        {
            var facturaData = objCapaNegocio.CN_DevolverFactura()
                             .Where(f => f.IdDetalleFactura == codigo)
                             .Select(f => new
                             {
                                 f.Fecha,
                                 f.Encargado,
                                 f.ValorUnitario,
                                 f.Cantidad,
                                 f.Descripcion,
                                 Cedula = objCapaNegocio.CN_DevolverCliente().Where(cl => cl.Id == f.IdCliente).Select(cl => cl.Cedula).FirstOrDefault(),
                                 Nombres = objCapaNegocio.CN_DevolverCliente().Where(cl => cl.Cedula == f.CedulaCliente).Select(cl => cl.Apellidos + " " + cl.Nombres).FirstOrDefault(),
                                 Pago = objCapaNegocio.CN_DevolverPago().Where(p => p.Id == f.IdPago).Select(p => p.Valor).FirstOrDefault(),
                                 f.Total
                             }).FirstOrDefault();
            if (facturaData != null)
            {
                txt_fecha.Text = facturaData.Fecha.ToString("D");
                txt_Encargado.Text = facturaData.Encargado.ToString();
                txt_Val_Unit.Text = facturaData.ValorUnitario.ToString();
                nmUD_Cantidad.Value = int.Parse(facturaData.Cantidad.ToString());
                txt_Descripcion.Text = facturaData.Descripcion.ToString();
                txt_Cedula.Text = facturaData.Cedula.ToString();
                txt_Nombres_Cliente.Text = facturaData.Nombres.ToString();
                txt_Valor_Pago.Texts = Convert.ToSingle(facturaData.Pago.ToString(),CultureInfo.InvariantCulture)+"";
                txt_Total.Text = facturaData.Total.ToString();
                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            float vuelto = 0, valor_pago = 0, valor_unit = 0;
            valor_unit = float.Parse(txt_Val_Unit.Text.Trim().ToString());
            int cantidad = int.Parse(nmUD_Cantidad.Value.ToString());
            valor_pago = float.Parse(txt_Valor_Pago.Texts.ToString());

            txt_Subtotal.Text = CalcularSubTotal();
            txt_Vuelto.Text = CalcularVuelto()+"";

            float total = valor_unit * cantidad + vuelto;
            txt_Total.Text = String.Format("%.2f", total);
        }

        public string CalcularSubTotal() => string.Format("%.2f", float.Parse(txt_Val_Unit.Text.Trim()) * int.Parse(nmUD_Cantidad.Value.ToString()));

        public float CalcularVuelto() => float.Parse(txt_Valor_Pago.Text.ToString()) - float.Parse(CalcularSubTotal());

        private void txt_Val_Unit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Val_Unit.Text))
            {
                // Eliminar cualquier coma o punto existente en el texto
                string valorSinComaPunto = txt_Val_Unit.Text.Replace(",", "").Replace(".", "");

                if (int.TryParse(valorSinComaPunto, out int valorEntero))
                {
                    // Dividir el valor entre 100 para obtener el valor decimal con dos decimales
                    decimal valorDecimal = valorEntero / 100.0m;

                    // Asignar el valor formateado al TextBox
                    txt_Val_Unit.Text = valorDecimal.ToString("N2");
                    txt_Val_Unit.SelectionStart = txt_Val_Unit.Text.Length; // Colocar el cursor al final del texto
                }
                //CalcularTotal();
            }
        }

        private void nmUD_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            //CalcularTotal();
        }
    }
}
