using Capa_Negocio;
using System;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Nuevo_Cliente : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Nuevo_Cliente()
        {
            InitializeComponent();
            CargarElementos();
            CargarRegistrosDataGridView();
        }

        private void CargarElementos()
        {
            txt_fecha.Text=Get_Date();
            cmb_Genero.SelectedIndex = 0;
        }

        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }

        private void Limpiar_Campos()
        {
            txt_Cedula.Texts = "";
            txt_Apellidos.Texts = "";
            txt_Nombres.Texts = "";
            cmb_Genero.SelectedIndex = 0;
            txt_Correo.Texts = "";
            txt_Direccion.Texts = "";
            txt_Telefono.Texts = "";
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Correo_Load(object sender, EventArgs e)
        {

        }

        private void CargarRegistrosDataGridView()
        {
            dtgV_Clientes.DataSource = objCapaNegocio.CN_CONSULTAR_CLIENTES();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string cedula = txt_Cedula.Texts.Trim();
                string apellidos = txt_Apellidos.Texts.ToUpper().Trim();
                string nombres = txt_Nombres.Texts.ToUpper().Trim();
                string genero = cmb_Genero.SelectedItem.ToString().ToUpper();
                string correo = txt_Correo.Texts.Trim();
                string direccion = txt_Direccion.Texts.Trim();
                string telefono = txt_Telefono.Texts.Trim();
                DateTime fechaRegistro = DateTime.Today;
                objCapaNegocio.CN_Nuevo_Cliente(cedula,apellidos,nombres,genero,correo,direccion,telefono, fechaRegistro);
                Limpiar_Campos();
                CargarRegistrosDataGridView();
                Get_Codigo_Cliente();
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
            if (string.IsNullOrWhiteSpace(txt_Apellidos.Texts))
            {
                mensajeValidacion += "\n\t- Apellidos del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Nombres.Texts))
            {
                mensajeValidacion += "\n\t- Nombres del Cliente";
                confirm++;
            }
            if (cmb_Genero.SelectedIndex <= 0) 
            {
                mensajeValidacion += "\n\t- G\u00e9nero del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Correo.Texts))
            {
                mensajeValidacion += "\n\t- Correo del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Direccion.Texts))
            {
                mensajeValidacion += "\n\t- Direcci\u00f3n del Cliente";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Telefono.Texts))
            {
                if (txt_Telefono.Texts.Length<10)
                {
                    mensajeValidacion += "\n\t- El Tel\u00e9fono no contiene 10 d\u00edgitos";
                    confirm++;
                }
                mensajeValidacion += "\n\t- Tel\u00e9fono del Cliente";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        private void txt_Codigo_Cliente_Load(object sender, EventArgs e)
        {
            Get_Codigo_Cliente();
        }

        private void Get_Codigo_Cliente()
        {
            txt_Codigo_Cliente.Texts = objCapaNegocio.CN_GET_CODIGO_CLIENTE();
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Cedula.Texts.Length <= 9)
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
            if (txt_Cedula.Texts.Length > 9 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("La c\u00e9dula solo puede contener 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Telefono.Texts.Length <= 9)
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
            if (txt_Telefono.Texts.Length > 9 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El t\u00e9lefono solo puede contener 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Apellidos.Texts.Length <= 25)
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
            if (txt_Apellidos.Texts.Length > 25 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El campo 'Apellidos' solo puede contener 25 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) && txt_Nombres.Texts.Length <= 25)
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
            if (txt_Nombres.Texts.Length > 25 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El campo 'Nombres' solo puede contener 25 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) && txt_Correo.Texts.Length <= 35)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back||e.KeyChar == '.'|| e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Correo.Texts.Length > 35 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("El correo solo puede contener 35 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetterOrDigit(c) && txt_Direccion.Texts.Length <= 35)
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
            if (txt_Direccion.Texts.Length > 35 && e.KeyChar != ((char)Keys.Back))
            {
                MessageBox.Show("La direcci\u00f3n domiciliaria solo puede contener 35 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
