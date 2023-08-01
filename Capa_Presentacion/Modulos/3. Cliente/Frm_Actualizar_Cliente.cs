using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Actualizar_Cliente : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

        public Frm_Actualizar_Cliente(string cedula)
        {
            InitializeComponent();
            RetornarDatosCliente(int.Parse(cedula));
        }

        private void Set_Item_ComboBox(String genero)
        {
            switch (genero)
            {
                case "MASCULINO":
                    cmb_Genero.SelectedIndex = 1;
                break;
                case "FEMENINO":
                    cmb_Genero.SelectedIndex = 2;
                break;
                case "PREFIERO NO DECIRLO":
                    cmb_Genero.SelectedIndex = 3;
                break;
            }
        }

        private string Get_Item_ComboBox()
        {
            string value = "";
            switch (cmb_Genero.SelectedIndex)
            {
                case 1:
                value = "MASCULINO";
                    break;
                case 2:
                value = "FEMENINO";
                    break;
                case 3:
                value = "PREFIERO NO DECIRLO";
                    break;
            }
            return value;
        }

        private void Btn_CloseForm_Click(object sender, EventArgs e) => Close();

        private void BtnActCliente(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Cliente cl = new Cliente
                {
                    Cedula = decimal.Parse(txt_Cedula.Texts.Trim()),
                    Nombres = txt_Nombres.Text.Trim(),
                    Apellidos = txt_Apellidos.Text.Trim(),
                    Correo = txt_Correo.Text.Trim(),
                    Direccion = txt_Direccion.Text.Trim(),
                    Telefono = decimal.Parse(txt_Telefono.Text.Trim()),
                    Genero = Get_Item_ComboBox(),
                    Estado = (rbn_Activo.Checked ? "ACTIVO" : "INACTIVO"),
                    Fecha = DateTime.Today
                };
                objCapaNegocio.CN_ActualizarCliente(cl);
                Close();
            }
        }

        //Mapea una lista con Linq y rellena los textbox-combobox 
        private void RetornarDatosCliente(int indice)
        {
            var nombreCliente = objCapaNegocio.CN_DevolverCliente()
                .Where(cl => cl.Cedula==indice)
                .Select(cl => new
                {
                    cl.Id,
                    cl.Nombres,
                    cl.Apellidos,
                    cl.Cedula,
                    cl.Genero,
                    cl.Correo,
                    cl.Direccion,
                    cl.Telefono
                }).FirstOrDefault();
            if (nombreCliente != null)
            {
                txt_Codigo_Cliente.Texts = nombreCliente.Id.ToString();
                txt_Cedula.Texts = "0" + nombreCliente.Cedula.ToString();
                txt_Nombres.Text = nombreCliente.Nombres.ToString();
                txt_Apellidos.Text = nombreCliente.Apellidos.ToString();
                txt_Direccion.Text = nombreCliente.Direccion.ToString();
                txt_Correo.Text = nombreCliente.Correo.ToString();
                txt_Telefono.Text = "0" + nombreCliente.Telefono.ToString();
                Set_Item_ComboBox(nombreCliente.Genero.ToString());
            }
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Cedula.Texts))
            {
                if (txt_Cedula.Texts.Length < 10)
                {
                    mensajeValidacion += "\n\t- La C\u00e9dula no contiene 10 d\u00edgitos";
                    confirm++;
                }
                mensajeValidacion += "\n\t- C\u00e9dula del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Apellidos.Text))
            {
                mensajeValidacion += "\n\t- Apellidos del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Nombres.Text))
            {
                mensajeValidacion += "\n\t- Nombres del Cliente";
                confirm++;
            }
            if (cmb_Genero.SelectedIndex <= 0)
            {
                mensajeValidacion += "\n\t- G\u00e9nero del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Correo.Text))
            {
                mensajeValidacion += "\n\t- Correo del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
            {
                mensajeValidacion += "\n\t- Direcci\u00f3n del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Telefono.Text))
            {
                mensajeValidacion += "\n\t- Tel\u00e9fono del Cliente";
                confirm++;
            }
            if (txt_Telefono.Text.Length < 10)
            {
                mensajeValidacion += "\n\t- El Tel\u00e9fono no contiene 10 d\u00edgitos";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) && txt_Correo.Text.Length <= 35)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Correo.Text.Length > 35 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El correo solo puede contener 35 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Apellidos.Text.Length <= 25)
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
            if (txt_Apellidos.Text.Length > 25 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El campo 'Apellidos' solo puede contener 25 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Nombres.Text.Length <= 25)
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
            if (txt_Nombres.Text.Length > 25 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El campo 'Nombres' solo puede contener 25 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Telefono.Text.Length <= 9)
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
            if (txt_Telefono.Text.Length > 9 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El t\u00e9lefono solo puede contener 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) && txt_Direccion.Text.Length <= 35)
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
            if (txt_Direccion.Text.Length > 35 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("La direcci\u00f3n domiciliaria solo puede contener 35 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
