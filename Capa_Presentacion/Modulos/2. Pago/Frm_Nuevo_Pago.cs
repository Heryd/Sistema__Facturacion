using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._2._Pago
{
    public partial class Frm_Nuevo_Pago : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Pago()
        {
            InitializeComponent();
            txt_Fecha_Pago.Text = objCapaNegocio.ObtenerFechaActual();
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void btnCloseNuevoPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumerosDecimales(e);
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedIndex == 1 || cmbMetodoPago.SelectedIndex == 2)
            {
                pcb_Tarjetas_Bg.Visible = true;
                radioAmerican.Visible = true;
                radioDinners.Visible = true;
                radioMaster.Visible = true;
                radioVisa.Visible = true;
            }
            else
            {
                //Hacer Invisible los controles
                pcb_Tarjetas_Bg.Visible = false;
                radioAmerican.Visible = false;
                radioDinners.Visible = false;
                radioMaster.Visible = false;
                radioVisa.Visible = false;
                //Deseleccionar los radio button
                radioAmerican.Checked = false;
                radioDinners.Checked = false;
                radioMaster.Checked = false;
                radioVisa.Checked = false;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void Limpieza()
        {
            txt_Cliente.Texts = "";
            txt_Valor_Pago.Text = "";
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Cliente.Texts.Length <= 9)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Cliente.Texts.Length > 9 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("C\u00f3digo de cliente debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    decimal valorDecimal = valorEntero / 100.0m;

                    // Asignar el valor formateado al TextBox
                    txt_Valor_Pago.Text = valorDecimal.ToString("N2");
                    txt_Valor_Pago.SelectionStart = txt_Valor_Pago.Text.Length; // Colocar el cursor al final del texto
                }
            }
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Cliente.Texts))
            {
                mensajeValidacion += "\n\t- C\u00f3digo del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Valor_Pago.Text))
            {
                mensajeValidacion += "\n\t- Valor del Pago";
                confirm++;
            }
            if (cmbMetodoPago.SelectedIndex == 0)
            {
                mensajeValidacion += "\n\t- M\u00e9todo de Pago";
                confirm++;
            }
            if (cmbMetodoPago.SelectedIndex == 1 || cmbMetodoPago.SelectedIndex == 2)
            {
                if (!radioAmerican.Checked && !radioDinners.Checked && !radioMaster.Checked && !radioVisa.Checked)
                {
                    mensajeValidacion += "\n\t- Elegir Tarjeta";
                    confirm++;
                }
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }


        private void btn_Nuevo_Pago_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Pago p = new Pago
                {
                    IdCliente = int.Parse(txt_Cliente.Texts.Trim()),
                    Valor = float.Parse(txt_Valor_Pago.Text.Trim()),
                    MetodoPago = cmbMetodoPago.SelectedItem.ToString(),
                    Fecha = DateTime.Today
                };
                objCapaNegocio.CN_Nuevo_Pago(p);
                Limpieza();
            }
        }
    }
}
