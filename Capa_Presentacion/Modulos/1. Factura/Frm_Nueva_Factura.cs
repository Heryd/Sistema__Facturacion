using Capa_Negocio;
using Capa_Datos.Entidades;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
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
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nueva_Factura()
        {
            InitializeComponent();
            txt_fecha.Text = Get_Date();
            chb_IVA.Checked = false;
        }

        //Cerar el Formulario
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
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
        }

        //Limpiar los textBox/[multiline], comboBox, numberUpDown, label
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Codigo_Cliente.Texts = "";
            txt_Cedula.Texts = "";
            txt_Nombre.Texts = "";
            txt_Telefono.Texts = "";
            txt_Metodo_Pago.Texts = "";
            txt_Descripcion.Text = "";
            nmUD_Cantidad.Value = 1;
            txt_Nombre_Encargado.Texts = "";
            txt_Valor_Pago.Text = "";
            chb_IVA.Checked = false;
            lbl_IVA_Value.Text = "0.00";
            txt_Subtotal.Text = "0.00";
            txt_Vuelto.Text = "0.00";
            txt_Total.Text = "0.00";
        }

        //Validar el de ingreso de números enteros positivos
        private void txt_Codigo_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Codigo_Cliente.Texts.Length <= 10)
            {
                e.Handled = false;
            }
            else if (c == (char)Keys.Back ||c==(char)Keys.LShiftKey || c == (char)Keys.RShiftKey)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Codigo_Cliente.Texts.Length > 10 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El código solo puede contener entre 1 a 7 caracteres numericos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Buscar y rellenar los campos mediante el código del cliente
        private void btn_Search_Cliente_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_Codigo_Cliente.Texts);
            bool confirm = false;
            var datosCliente = objCapaNegocio.CN_DevolverCliente()
                            .Where(cl => cl.Cedula == codigo || cl.Id ==codigo)
                            .Select(cl => new { cl.Id, cl.Nombres, cl.Apellidos, cl.Cedula, cl.Genero, cl.Correo, cl.Direccion, cl.Telefono }).FirstOrDefault();
                txt_Cedula.Texts = "0" + datosCliente.Cedula.ToString();
                txt_Nombre.Texts = datosCliente.Nombres.ToString()+" "+datosCliente.Apellidos.ToString();
                txt_Telefono.Texts = "0"+datosCliente.Telefono.ToString();
                confirm = true;
            if(!confirm)
            {
                MessageBox.Show("No se encontró el Cliente", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
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
            if (string.IsNullOrWhiteSpace(txt_Precio_Unitario.Texts))
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
            else if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space ||e.KeyChar==(char)Keys.LShiftKey
                    || e.KeyChar == (char)Keys.RShiftKey|| e.KeyChar == '.')
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
    }
}
