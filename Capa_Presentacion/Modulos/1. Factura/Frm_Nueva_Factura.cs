using Capa_Datos.Entidades;
using Capa_Negocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Drawing;
using System.IO;
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
    public partial class Frm_Nueva_Factura : Form
    {
        #region Atributos
        /// <summary>
        /// Ojbeto de solo lectura para la invocación de los métodos de la clase <b>CN_GetData</b>
        /// </summary> 
        private readonly CN_GetData objCapaNegocio = new CN_GetData();
        #endregion

        #region Descripción del Constructor
        /// <summary>
        /// Constructor que incializa los componentes del formulario, envía la fecha actual del sistema a un label y marca el IVA en false.
        /// </summary> 
        #endregion
        public Frm_Nueva_Factura()
        {
            InitializeComponent();
            txt_fecha.Text = Get_Date();
            chb_IVA.Checked = false;
        }

        //Cerar el Formulario
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Obtener la Fecha actual
        /// <summary>
        /// Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
        /// </summary>
        /// <returns>Retorna la fecha en formato como un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        //Calcular el valor total con IVA
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

        //Llamada al método LimpiarCampos()
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #region Limpiar los Campos para poder llenarlos de nuevo
        /// <summary>
        /// Limpiar los textBox/[multiline], comboBox, numberUpDown, label
        /// </summary>
        #endregion
        private void LimpiarCampos()
        {
            txt_Codigo_Cliente.Texts = "";
            txt_Cedula.Texts = "";
            txt_Nombre.Texts = "";
            txt_Telefono.Texts = "";
            txt_Metodo_Pago.Texts = "";
            txt_Descripcion.Text = "";
            nmUD_Cantidad.Value = 1;
            txt_Nombre_Encargado.Texts = "";
            textbox1.Text = "";
            chb_IVA.Checked = false;
            txt_Val_Unit.Text = "0,00";
            lbl_IVA_Value.Text = "0.00";
            txt_Subtotal.Text = "0.00";
            txt_Vuelto.Text = "0.00";
            txt_Total.Text = "0.00";
            textbox1.Texts = "";
            nmUD_Cantidad.Enabled = false;
            txt_Val_Unit.Enabled = false;
        }

        //Validar el de ingreso de números enteros positivos
        private void txt_Codigo_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Codigo_Cliente.Texts.Length <= 10)
            {
                e.Handled = false;
            }
            else if (c == (char)Keys.Back || c == (char)Keys.LShiftKey || c == (char)Keys.RShiftKey)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Codigo_Cliente.Texts.Length > 10 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El código solo puede contener entre 1 a 9 caracteres numericos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Buscar y rellenar los campos mediante el código del cliente
        private void btn_Search_Cliente_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_Codigo_Cliente.Texts);

            var clienteInfo = objCapaNegocio.CN_DevolverCliente()
                .Where(cl => cl.Cedula == codigo || cl.Id == codigo)
                .Select(cl => new
                {
                    cl.Id,
                    cl.Nombres,
                    cl.Apellidos,
                    cl.Cedula,
                    cl.Genero,
                    cl.Correo,
                    cl.Direccion,
                    cl.Telefono,
                    MetodoPago = objCapaNegocio.CN_DevolverPago()
                        .Where(p => p.IdCliente == cl.Id)
                        .Select(p => p.MetodoPago)
                        .FirstOrDefault(),
                    ValorPago = objCapaNegocio.CN_DevolverPago()
                        .Where(p => p.IdCliente == cl.Id && p.Estado == "EN PROCESO")
                        .Select(p => p.Valor)
                        .FirstOrDefault()
                })
                .FirstOrDefault();

            if (clienteInfo != null)
            {
                if (clienteInfo.ValorPago > 0)
                {
                    txt_Cedula.Texts = "0" + clienteInfo.Cedula.ToString();
                    txt_Nombre.Texts = clienteInfo.Nombres.ToString() + " " + clienteInfo.Apellidos.ToString();
                    txt_Telefono.Texts = "0" + clienteInfo.Telefono.ToString();
                    txt_Metodo_Pago.Texts = clienteInfo.MetodoPago.ToString();
                    txt_Valor_Pago.Text = clienteInfo.ValorPago.ToString();
                    // El método de pago y valor del pago están disponibles en clienteInfo.MetodoPago y clienteInfo.ValorPago, respectivamente.
                    nmUD_Cantidad.Enabled = true;
                    txt_Val_Unit.Enabled = true;
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Cliente: " + clienteInfo.Apellidos + " " + clienteInfo.Nombres + ", no ha registrado un pago.\nPor favor realice primero el pago.", "Cliente no ha pagado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No se encontró el Cliente", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CalcularTotal()
        {
            float pago = (float)Math.Round(float.Parse(txt_Valor_Pago.Text.Trim()),2,MidpointRounding.ToEven);
            float iva = 0.12f;
            float subtotal = CalcularSubTotal();
            txt_Valor_a_Pagar.Text = CalcularValorAPagar() + "";
            if (float.Parse(txt_Valor_a_Pagar.Text.Trim()) <= pago)
            {
                txt_Subtotal.Text = subtotal + "";
                txt_Vuelto.Text = CalcularVuelto() + "";
                txt_Total.Text = (chb_IVA.Checked ? ((subtotal * iva) + subtotal) + "" : subtotal + "");
            }
            else
            {
                txt_Val_Unit.Text = "0,00";
                MessageBox.Show("El valor a pagar es mayor que el efectivo del cliente.\nPorfavor considere su presupuesto", "No sea pobre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if (float.Parse(txt_Total.Text.Trim()) > pago)
            //{
            //    MessageBox.Show("El total a pagar es mayor que el efectivo del cliente.\nPorfavor considere su presupuesto o puede cambiar el valor del pago en las consultas del pago", "Negociemos...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        #region Descripción del Método para Calcular el Subtotal
        /// <summary>
        /// Este método se encarga de calcular el subtotal realizando la operación <b>(Valor Unitario * Cantidad + Efectivo)</b>
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa el subtotal.</returns> 
        #endregion
        public float CalcularSubTotal() => (float)Math.Round(CalcularValorAPagar() + float.Parse(txt_Valor_Pago.Text.Trim()), 2, MidpointRounding.ToEven);

        #region Descripción del Método para Calcular el valor a devolver del pago
        /// <summary>
        /// Este método se encarga de calcular la cantidad que se debe devolver al cliente por su pago, realizando la operación <b>(Valor del Pago - Subtotal)</b>, así mismo el método round, redondea el valor y se divide entre 100 para obtener solo 2 decimales. Por último el Método Abs hace el valor absoluto para no obtener un valor negativo.
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa el valor a devolver por el pago realizado.</returns> 
        #endregion
        public float CalcularVuelto() => Math.Abs((float)Math.Round(float.Parse(txt_Valor_Pago.Text.Trim()) - CalcularValorAPagar(), 2, MidpointRounding.ToEven));

        #region Descripción del Método para Calcular el valor a pagar
        /// <summary>
        /// Este método se encarga de calcular el valor que debe pagar el cliente, realizando la operación <b>(Valor Unitario * Cantidad)</b>.
        /// </summary>
        /// <returns>Un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see> que representa la cantidad que debe pagar el cliente.</returns> 
        #endregion
        public float CalcularValorAPagar() => float.Parse(txt_Val_Unit.Text.Trim()) * int.Parse(nmUD_Cantidad.Value.ToString());

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta un mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Codigo_Cliente.Texts))
            {
                mensajeValidacion += "\n\t- Código del Cliente";
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
            if (string.IsNullOrWhiteSpace(txt_Nombre_Encargado.Texts))
            {
                mensajeValidacion += "\n\t- Nombre del Encargado";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        //Cargar el registro de la nueva factura en la Base de Datos
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Factura f = new Factura()
                {
                    IdCliente = int.Parse(txt_Codigo_Cliente.Texts.Trim().ToString()),
                    Descripcion = txt_Descripcion.Text.Trim().ToString(),
                    Cantidad = int.Parse(nmUD_Cantidad.Value.ToString()),
                    ValorUnitario = float.Parse(txt_Val_Unit.Text.Trim()),
                    Encargado = txt_Nombre_Encargado.Texts.Trim().ToString().ToUpper(),
                    Fecha = DateTime.Today,
                    Total = float.Parse(txt_Total.Text.Trim().ToString())
                };
                objCapaNegocio.CN_Nueva_Factura(f);
                LimpiarCampos();
                CargarRegistrosFactura();
            }
        }

        private void txt_Nombre_Encargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Nombre_Encargado.Texts.Length <= 30)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Nombre_Encargado.Texts.Length > 30 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("Solo se pueden ingresar 20 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) && txt_Descripcion.Text.Length <= 120)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.LShiftKey
                    || e.KeyChar == (char)Keys.RShiftKey || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Nombre_Encargado.Texts.Length > 120 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("Solo se pueden ingresar 120 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Frm_Nueva_Factura_Load(object sender, EventArgs e)
        {
            CargarRegistrosFactura();
        }

        private void CargarRegistrosFactura()
        {
            var facturas = objCapaNegocio.CN_DevolverFactura()
                .Select(f => new
                {
                    f.Id,
                    f.Descripcion,
                    f.Cantidad,
                    f.ValorUnitario,
                    f.Total,
                    f.Fecha
                });
            dtgV_Facturas.DataSource = facturas.ToList();
        }

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
                    CalcularTotal();
                }
            }
        }


        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            Frm_Input_Data_Records frm_dt_rc = new Frm_Input_Data_Records();
            frm_dt_rc.ShowDialog();
        }

        private void nmUD_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
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
                MessageBox.Show("El valor unitario debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
