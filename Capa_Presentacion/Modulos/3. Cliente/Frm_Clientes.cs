using Capa_Negocio;
using Capa_Presentacion.Modulos._1._Factura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._3._Cliente
{
    public partial class Frm_Clientes : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();

        public Frm_Clientes()
        {
            InitializeComponent();
            CargarElementos();
        }

        //Establece las posiciones de los comboBox en índice 0 "(Seleccionar...)"
        private void CargarElementos()
        {
            cmb_Filtro_Cliente.SelectedIndex= 0;
            cmb_Filtro_Pago.SelectedIndex= 0;
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
            //Edita una fila seleccionada enviando los valores a otro formulario
            if (dtgV_Clientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                string indice = dtgV_Clientes.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
                Frm_Actualizar_Cliente frm_Update = new Frm_Actualizar_Cliente(indice);
                frm_Update.ShowDialog();
                CargarRegistrosDataGridView();
            }

            //Cambia el estado de un registro a "Eliminado"
            if (dtgV_Clientes.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                string verificar_Estado = dtgV_Clientes.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString();
                DialogResult dg = MessageBox.Show("¿Está seguro de Eliminar a este Cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    //obtienes el valor de la primer columna
                    string indice = dtgV_Clientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value.ToString();
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
    }
}
