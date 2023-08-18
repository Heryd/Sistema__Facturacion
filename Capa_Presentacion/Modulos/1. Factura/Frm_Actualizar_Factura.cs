using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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
        private int index = 0;
        public Frm_Actualizar_Factura(string indice)
        {
            InitializeComponent();
            index = int.Parse(indice);
            RetornarDatosFactura(index);
            CalcularTotal();
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
            if (txt_Val_Unit.Text.Equals("0,00"))
            {
                mensajeValidacion += "\n\t- Precio Unitario del Servicio";
                confirm++;
            }
            if (txt_Valor_Pago.Text.Equals("0,00"))
            {
                mensajeValidacion += "\n\t- Efectivo";
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
                Factura f = new Factura()
                {
                    Id = index,
                    Fecha = DateTime.Parse(txt_fecha.Text.ToString()),
                    Descripcion = txt_Descripcion.Text.Trim(),
                    ValorUnitario = float.Parse(txt_Val_Unit.Text.Trim()),
                    Cantidad = int.Parse(nmUD_Cantidad.Value.ToString()),
                    Total = float.Parse(txt_Total.Text.Trim()),
                    Encargado = txt_Encargado.Text.Trim()
                };
                objCapaNegocio.CN_ActualizarFactura(f);
                Close();
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
                                 f.Total
                             }).FirstOrDefault();
            if (facturaData != null)
            {
                txt_fecha.Text = facturaData.Fecha.ToString("dddd dd MMMM, yyyy", CultureInfo.CreateSpecificCulture("es-ES"));
                txt_Encargado.Text = facturaData.Encargado.ToString();
                txt_Val_Unit.Text = EvaluarValorUnitario(facturaData.ValorUnitario.ToString());
                nmUD_Cantidad.Value = int.Parse(facturaData.Cantidad.ToString());
                txt_Descripcion.Text = facturaData.Descripcion.ToString();
                txt_Cedula.Text = facturaData.Cedula.ToString();
                txt_Nombres_Cliente.Text = facturaData.Nombres.ToString();
                txt_Valor_Pago.Text = "0,00";
                txt_Total.Text = facturaData.Total.ToString();
            }
        }
        private string EvaluarValorUnitario(string valUnit)
        {
            // Check if the string contains a decimal point.
            Regex regex1 = new Regex(@"\,[0-9]{2}$");
            Regex regex2 = new Regex(@"\,[0-9]{1}$");
            Match match1 = regex1.Match(valUnit);
            Match match2 = regex2.Match(valUnit);
            // Check if the string contains two decimals.
            if (match1.Success)
            {
                return valUnit;
            }
            if (match2.Success)
            {
                return valUnit + 0;
            }
            //if(!match1.Success&&!match2.Success)
            //{
            //    return valUnit + 00;
            //}
            return valUnit + 00;
        }
        private void CalcularTotal()
        {
            float iva = 0.12f;
            float subTotal = CalcularSubTotal();
            txt_Valor_a_Pagar.Text = CalcularValorAPagar() + "";
            //if (float.Parse(txt_Valor_a_Pagar.Text.Trim()) <= pago)
            //{
                txt_Subtotal.Text = subTotal + "";
                txt_Vuelto.Text = CalcularVuelto() + "";
                txt_Total.Text = (chb_IVA.Checked ? Math.Round((subTotal * iva) + subTotal,2,MidpointRounding.ToEven)+ "" : subTotal + "");
            //}
            //else
            //{
                //txt_Val_Unit.Text = "0,00";
                //MessageBox.Show("El valor a pagar es mayor que el efectivo del cliente.\nPorfavor considere su presupuesto", "No sea pobre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        #region Descripción del Método para Calcular el Subtotal
        /// <summary>
        /// Este método se encarga de calcular el subtotal realizando la operación <b>(Valor Unitario * Cantidad + Efectivo)</b>
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa el subtotal.</returns> 
        #endregion
        public float CalcularSubTotal() => (float)Math.Round(CalcularValorAPagar() + float.Parse(txt_Valor_Pago.Text.Trim()),2,MidpointRounding.ToEven);

        #region Descripción del Método para Calcular el valor a devolver del pago
        /// <summary>
        /// Este método se encarga de calcular la cantidad que se debe devolver al cliente por su pago, realizando la operación <b>(Valor del Pago - Subtotal)</b>, así mismo el método round, redondea el valor y se divide entre 100 para obtener solo 2 decimales. Por último el Método Abs hace el valor absoluto para no obtener un valor negativo.
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa el valor a devolver por el pago realizado.</returns> 
        #endregion
        public float CalcularVuelto() => Math.Abs((float)Math.Round(float.Parse(txt_Valor_Pago.Text.Trim()) - CalcularValorAPagar(),2,MidpointRounding.ToEven));

        #region Descripción del Método para Calcular el valor a pagar
        /// <summary>
        /// Este método se encarga de calcular el valor que debe pagar el cliente, realizando la operación <b>(Valor Unitario * Cantidad)</b>.
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa la cantidad que debe pagar el cliente.</returns> 
        #endregion
        public float CalcularValorAPagar() => float.Parse(txt_Val_Unit.Text.Trim()) * int.Parse(nmUD_Cantidad.Value.ToString());

        private void txt_Val_Unit_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Val_Unit.Text))
            {
                // Eliminar cualquier coma o punto existente en el texto
                string valorSinComaPunto = txt_Val_Unit.Text.Replace(",", "").Replace(".", "");

                if (int.TryParse(valorSinComaPunto, out int valorEntero))
                {
                    // Dividir el valor entre 100 para obtener el valor decimal con dos decimales
                    decimal valorDecimal = valorEntero / 100.00m;

                    // Asignar el valor formateado al TextBox
                    txt_Val_Unit.Text = valorDecimal.ToString("N2");
                    txt_Val_Unit.SelectionStart = txt_Val_Unit.Text.Length; // Colocar el cursor al final del texto
                    CalcularTotal();
                }
            }
        }

        private void nmUD_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void chb_IVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_IVA.Checked)
            {
                chb_IVA.ForeColor = Color.Green;
                lbl_IVA_Value.Text = "0.12";
            }
            else
            {
                lbl_IVA_Value.Text = "0.00";
            }
            CalcularTotal();
        }

        private void txt_Valor_Pago_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Valor_Pago.Text))
            {
                // Eliminar cualquier coma o punto existente en el texto
                string valorSinComaPunto = txt_Valor_Pago.Text.Replace(",", "").Replace(".", "");

                if (int.TryParse(valorSinComaPunto, out int valorEntero))
                {
                    // Dividir el valor entre 100 para obtener el valor decimal con dos decimales
                    decimal valorDecimal = valorEntero / 100.00m;

                    // Asignar el valor formateado al TextBox
                    txt_Valor_Pago.Text = valorDecimal.ToString("N2");
                    txt_Valor_Pago.SelectionStart = txt_Valor_Pago.Text.Length; // Colocar el cursor al final del texto
                    CalcularTotal();
                }
            }
        }

        private void txt_Val_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Val_Unit.Text.Length <= 10)
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
            if (txt_Val_Unit.Text.Length > 10 && c != ((char)Keys.Back))
            {
                MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Valor_Pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Valor_Pago.Text.Length <= 10)
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
            if (txt_Valor_Pago.Text.Length > 10 && c != ((char)Keys.Back))
            {
                MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
