using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._2._Pago
{
    public partial class Frm_Actualizar_Pago : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

        public Frm_Actualizar_Pago(string id)
        {
            InitializeComponent();
            RetornarDatosPago(int.Parse(id));
        }

        private void btnCloseActPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtActImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumerosDecimales(e);
        }

        private void btnActualizarPagos_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Pago p = new Pago
                {
                    Id = int.Parse(txt_ID.Text.ToString().Trim()),
                    IdCliente = int.Parse(txt_Codigo_Cliente.Text.Trim()),
                    Fecha = DateTime.Today,
                    MetodoPago = Get_Item_ComboBox(),
                    Valor = float.Parse(txt_Valor_Pago.Text.Trim())
                };
                objCapaNegocio.CN_ActualizarPago(p);
                Close();
            }
        }

        private void Set_Item_ComboBox(String genero)
        {
            switch (genero)
            {
                case "CREDITO":
                cmbMetodoPago.SelectedIndex = 1;
                break;
                case "DEBITO":
                cmbMetodoPago.SelectedIndex = 2;
                break;
                case "EFECTIVO":
                cmbMetodoPago.SelectedIndex = 3;
                break;
            }
        }

        private string Get_Item_ComboBox() => cmbMetodoPago.SelectedItem.ToString();

        //Mapea una lista con Linq y rellena los textbox-combobox 
        private void RetornarDatosPago(int indice)
        {
            var pago = objCapaNegocio.CN_DevolverPago()
                .Where(p => p.Id == indice)
                .Select(p => new
                {
                    p.Id,
                    CODIGO_CLIENTE = objCapaNegocio.CN_DevolverCliente()
                                    .Where(cl => cl.Id == p.IdCliente)
                                    .Select(cl => cl.Cedula)
                                    .FirstOrDefault(),
                    p.MetodoPago,
                    p.Valor
                }).FirstOrDefault();
            txt_ID.Text = pago.Id.ToString();
            txt_Codigo_Cliente.Text = "0" + pago.CODIGO_CLIENTE.ToString();
            txt_Valor_Pago.Text = (!pago.Valor.ToString().Contains(".") ? pago.Valor.ToString()+"00" : pago.Valor.ToString());
            Set_Item_ComboBox(pago.MetodoPago);
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

        private void cmb_Metodo_Pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedIndex == 1 || cmbMetodoPago.SelectedIndex == 2)
            {
                pcb_Tarjetas_Bg.Visible = true;
                radioAmerican.Visible = true;
                radioDiners.Visible = true;
                radioMaster.Visible = true;
                radioVisa.Visible = true;
            }
            else
            {
                //Hacer Invisible los controles
                pcb_Tarjetas_Bg.Visible = false;
                radioAmerican.Visible = false;
                radioDiners.Visible = false;
                radioMaster.Visible = false;
                radioVisa.Visible = false;
                //Deseleccionar los radio button
                radioAmerican.Checked = false;
                radioDiners.Checked = false;
                radioMaster.Checked = false;
                radioVisa.Checked = false;
            }
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Codigo_Cliente.Text))
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
                if (!radioAmerican.Checked && !radioDiners.Checked && !radioMaster.Checked && !radioVisa.Checked)
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
    }
}
