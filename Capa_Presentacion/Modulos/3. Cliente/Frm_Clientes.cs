using Capa_Datos.Entidades;
using Capa_Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Clientes : Form
    {
        #region Atributos
        /// <summary>
        /// Ojbeto de solo lectura para la invocación de los métodos de la clase <b>CN_GetData</b>
        /// </summary> 
        private readonly CN_GetData objCapaNegocio = new CN_GetData();
        /// <summary>
        /// Índice que servirá para la correspondiente aplicación de filtros.
        /// </summary>
        private int index_object = -1;
        #endregion

        #region Inicialización del Constructor
        /// <summary>
        /// Inicializa los componentes y carga los registros de tipo cliente al DataGridView.
        /// </summary> 
        #endregion
        public Frm_Clientes()
        {
            InitializeComponent();
            CargarElementos();
        }

        #region Método para iniciar el index del comboBox al primer elementos
        /// <summary>
        /// Establece las posiciones de los comboBox en índice 0 "(Código)"
        /// </summary> 
        #endregion
        private void CargarElementos()
        {
            cmb_Filtro_Cliente.SelectedIndex = 0;
        }

        //Cierra el Formulario
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Mostrar Registros de Clientes en el DataGridView
        private IEnumerable<Object> CargarRegistrosDataGridView()
        {
            var clientes = objCapaNegocio.CN_DevolverCliente()
                .Select(c => new
                {
                    ID_CLIENTE = c.Id,
                    CEDULA = c.Cedula,
                    NOMBRES = c.Nombres + " " + c.Apellidos,
                    CORREO = c.Correo,
                    GENERO = c.Genero,
                    FECHA_REGISTRO = c.Fecha,
                    ESTADO = c.Estado
                }).AsQueryable();
            return clientes;
        }

        //Método para Editar o Eliminar Filas
        private void dtgV_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string indice = dtgV_Clientes.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            string estado = dtgV_Clientes.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString();
            //Edita una fila seleccionada enviando los valores a otro formulario
            if (dtgV_Clientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                if (!estado.Equals("PAGANDO", StringComparison.OrdinalIgnoreCase))
                {
                    Frm_Actualizar_Cliente frm_Update = new Frm_Actualizar_Cliente(indice);
                    frm_Update.ShowDialog();
                    CargarRegistrosDataGridView();
                }
                else
                {
                    MessageBox.Show("El cliente se encuentra en proceso de pago.\nNo se puede editar el registro.\nPor favor, primero realice el proceso de facturación.", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Envía el código del cliente al método Eliminar Cliente de la Capa negocio
            if (dtgV_Clientes.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                DialogResult dg = MessageBox.Show("¿Está seguro de Eliminar a este Cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    objCapaNegocio.CN_EliminarCliente(indice);
                    CargarRegistrosDataGridView();
                }
            }
        }

        //Muestra imagenes para los botones de Editar y Eliminar
        private void dtgV_Clientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            objCapaNegocio.CN_Show_Buttons_DTGV(e, dtgV_Clientes, Properties.Resources.edit_min_20x20, Properties.Resources.delete_min_20x20);
        }

        //Carga los registros de la Tabla Cliente y añade los botones de editar y eliminar
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            dtgV_Clientes.DataSource = CargarRegistrosDataGridView().ToList();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Clientes);
        }

        private void cmb_Filtro_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_object = cmb_Filtro_Cliente.SelectedIndex + 1;
            txtBusquedaCliente.Text = "";
        }

        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            switch (index_object)
            {
                case 1:
                var clientes = objCapaNegocio.CN_DevolverCliente()
                .Where(c => c.Id.ToString().Contains(txtBusquedaCliente.Text.ToString()))
                    .Select(c => new
                    {
                        ID_CLIENTE = c.Id,
                        CEDULA = c.Cedula,
                        NOMBRES = c.Nombres + " " + c.Apellidos,
                        CORREO = c.Correo,
                        GENERO = c.Genero,
                        FECHA_REGISTRO = c.Fecha,
                        ESTADO = c.Estado
                    }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientes != null && clientes.Any())
                {
                    dtgV_Clientes.DataSource = clientes.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias del código", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 2:
                var clientesXNombres = objCapaNegocio.CN_DevolverCliente()
                    .Where(c => (c.Nombres + " " + c.Apellidos).ToString().Contains(txtBusquedaCliente.Text.ToString()))
                    .Select(c => new
                    {
                        ID_CLIENTE = c.Id,
                        CEDULA = c.Cedula,
                        NOMBRES = c.Nombres + " " + c.Apellidos,
                        CORREO = c.Correo,
                        GENERO = c.Genero,
                        FECHA_REGISTRO = c.Fecha,
                        ESTADO = c.Estado
                    }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientesXNombres != null && clientesXNombres.Any())
                {
                    dtgV_Clientes.DataSource = clientesXNombres.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias del nombre", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 3:
                var clientesXTelefono = objCapaNegocio.CN_DevolverCliente()
                .Where(c => ("0"+c.Telefono).ToString().Contains(txtBusquedaCliente.Text.ToString()))
                .Select(c => new
                {
                    ID_CLIENTE = c.Id,
                    CEDULA = c.Cedula,
                    NOMBRES = c.Nombres + " " + c.Apellidos,
                    CORREO = c.Correo,
                    GENERO = c.Genero,
                    FECHA_REGISTRO = c.Fecha,
                    ESTADO = c.Estado
                }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientesXTelefono != null && clientesXTelefono.Any())
                {
                    dtgV_Clientes.DataSource = clientesXTelefono.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias del teléfono", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 4:
                var clientesXCedula = objCapaNegocio.CN_DevolverCliente()
                .Where(c => ("0"+c.Cedula).ToString().Contains(txtBusquedaCliente.Text.ToString()))
                .Select(c => new
                {
                    ID_CLIENTE = c.Id,
                    CEDULA = c.Cedula,
                    NOMBRES = c.Nombres + " " + c.Apellidos,
                    CORREO = c.Correo,
                    GENERO = c.Genero,
                    FECHA_REGISTRO = c.Fecha,
                    ESTADO = c.Estado
                }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientesXCedula != null && clientesXCedula.Any())
                {
                    dtgV_Clientes.DataSource = clientesXCedula.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias de la cédula", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 5:
                var clientesXFecha = objCapaNegocio.CN_DevolverCliente()
                .Where(c => c.Fecha.ToString().Contains(txtBusquedaCliente.Text.ToString()))
                .Select(c => new
                {
                    ID_CLIENTE = c.Id,
                    CEDULA = c.Cedula,
                    NOMBRES = c.Nombres + " " + c.Apellidos,
                    CORREO = c.Correo,
                    GENERO = c.Genero,
                    FECHA_REGISTRO = c.Fecha,
                    ESTADO = c.Estado
                }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientesXFecha != null && clientesXFecha.Any())
                {
                    dtgV_Clientes.DataSource = clientesXFecha.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias del código", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                case 6:
                var clientesXestado = objCapaNegocio.CN_DevolverCliente()
                .Where(c => c.Estado.ToString().Contains(txtBusquedaCliente.Text.ToString()))
                .Select(c => new
                {
                    ID_CLIENTE = c.Id,
                    CEDULA = c.Cedula,
                    NOMBRES = c.Nombres + " " + c.Apellidos,
                    CORREO = c.Correo,
                    GENERO = c.Genero,
                    FECHA_REGISTRO = c.Fecha,
                    ESTADO = c.Estado
                }).AsQueryable();
                if (txtBusquedaCliente.Text.Equals(""))
                {
                    CargarRegistrosDataGridView();
                }
                if (clientesXestado != null && clientesXestado.Any())
                {
                    dtgV_Clientes.DataSource = clientesXestado.ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias del código", "Búsqueda por filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
                default:
                break;
            }
        }

        /// <summary>
        /// Método KeyPress del textbox, según el índice de filtro del combobox permitirá o ingresar dígitos, o ingresar letras
        /// </summary>
        /// <param name="sender">Foco actual del objeto</param>
        /// <param name="e">El evento KeyPress</param>
        private void txtBusquedaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Asigna lo ingresado a una variable
            char c = e.KeyChar;
            switch (index_object)
            {
                //Si el filtro seleccionado es: 
                //[1]: Fecha,
                //[3]: Teléfono,
                //[4]: Cédula
                //entonces el evento keyPress solo permitirá el ingreso de dígitos, hasta un máximo de 10
                case 1:
                case 3:
                case 4:
                if (Char.IsDigit(c) && txtBusquedaCliente.Text.Length <= 10)
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
                if (txtBusquedaCliente.Text.Length > 10 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[2]: Nombres,
                //[6]: Estado
                //entonces el evento keyPress solo permitirá el ingreso de letras, hasta un máximo de 30 caracteres
                case 2:
                case 6:
                if (Char.IsLetter(c) && txtBusquedaCliente.Text.Length <= 30)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txtBusquedaCliente.Text.Length > 30 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda solo puede incluir 30 caracteres", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                //Si el filtro seleccionado es: 
                //[5]: Fecha del Registro
                //entonces el evento keyPress solo permitirá el ingreso de la fecha en formato dd/MM/YYYY, hasta un máximo de 10 dígitos
                case 5:
                if (Char.IsDigit(c) && txtBusquedaCliente.Text.Length <= 10)
                {
                    e.Handled = false;
                }
                else if (c == (char)Keys.Back || c == '/')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (txtBusquedaCliente.Text.Length > 9 && c != ((char)Keys.Back))
                {
                    MessageBox.Show("La búsqueda del filtro seleccionado solo debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                break;
                default:
                break;
            }
        }
    }
}
