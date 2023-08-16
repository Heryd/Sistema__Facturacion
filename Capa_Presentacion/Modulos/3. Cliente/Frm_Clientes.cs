using Capa_Negocio;
using System;
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
        private void CargarRegistrosDataGridView()
        {
            dtgV_Clientes.DataSource = objCapaNegocio.CN_CLIENTES();
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
            CargarRegistrosDataGridView();
            objCapaNegocio.CN_Add_Buttons_DTGV(dtgV_Clientes);
        }

        private void cmb_Filtro_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_object = cmb_Filtro_Cliente.SelectedIndex + 1;
        }
    }
}
