using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Drawing;
using System.Windows.Forms;
using Capa_Datos.Entidades;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Negocio
{
    public class CN_GetData
    {
        private CD_GetData objectCD = new CD_GetData();

        //Métodos de que retornan valores de Tipo Cliente de la Clase CD_GetData 
        public object CN_CONSULTAR_CLIENTES() => objectCD.Consulta_Cliente();
        public object CN_CLIENTES() => objectCD.Clientes();

        public object CN_ConsultaPagos() => objectCD.Consulta_Pago();

        public DataTable CN_ShowData(string sql_text) => objectCD.GetData(sql_text);
        
        //Método para añadir botones de editar y eliminar a las tablas de consultas
        public void CN_Add_Buttons_DTGV(DataGridView dataGridView)
        {
            DataGridViewButtonColumn btn_Editar_Factura = new DataGridViewButtonColumn();
            btn_Editar_Factura.Name = "Editar";
            DataGridViewButtonColumn btn_Eliminar_Factura = new DataGridViewButtonColumn();
            btn_Eliminar_Factura.Name = "Eliminar";
            btn_Editar_Factura.HeaderText = "";
            btn_Eliminar_Factura.HeaderText = "";
            dataGridView.Columns.Add(btn_Editar_Factura);
            dataGridView.Columns.Add(btn_Eliminar_Factura);
        }

        //Método para ajustar las imagenes de los botones 'Editar' y 'Eliminar' del DataGridView
        public void CN_Show_Buttons_DTGV(DataGridViewCellPaintingEventArgs e, DataGridView dataGridView, Bitmap edit_min_20x20, Bitmap delete_min_20x20)
          {
               if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
               {
                    return;
               }
               //Si el encabezado de la columna es <Eliminar>, asigna el icono correspondiente
               if (e.ColumnIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
               {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell cellButton = dataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                    cellButton.FlatStyle = FlatStyle.Popup;
                    cellButton.Style.BackColor = Color.White;
                    var image = delete_min_20x20;
                    e.Graphics.DrawImage(image, e.CellBounds.Left + 8, e.CellBounds.Top + 10);
                    dataGridView.Rows[e.RowIndex].Height = image.Height + 30;
                    dataGridView.Columns[e.ColumnIndex].Width = image.Width + 30;
                    e.Handled = true;
               }
               //Si el encabezado de la columna es <Editar>, asigna el icono correspondiente
               if (e.ColumnIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "Editar")
               {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell cellButton = dataGridView.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                    cellButton.FlatStyle = FlatStyle.Popup;
                    cellButton.Style.BackColor = Color.White;
                    var image = edit_min_20x20;
                    e.Graphics.DrawImage(image, e.CellBounds.Left + 8, e.CellBounds.Top + 10);
                    dataGridView.Rows[e.RowIndex].Height = image.Height + 30;
                    dataGridView.Columns[e.ColumnIndex].Width = image.Width + 30;
                    e.Handled = true;
               }
          }

        //´Método que retorna la fecha actual en un formato específico. Ej -> <Jueves, Septiembre 28, 2023>
        public string ObtenerFechaActual() => DateTime.Today.ToString("D");

        //Método que envia los valores obtenidos del Nuevo Cliente para su correspondiente registro en la BD
        public void CN_Nuevo_Cliente(Cliente cl)
        {
            //Envia los parámetros a la clase CD_GetData y castea aquellos de tipo numerico o fecha
            objectCD.CD_Nuevo_Cliente(cl);
        }
        public void CN_ActualizarCliente(Cliente cl)=>objectCD.CD_ActualizarCliente(cl);

        public void CN_ActualizarPago(Pago p) => objectCD.CD_ActualizarPago(p);

        public void CN_Nuevo_Pago(Pago p) => objectCD.CD_NuevoPago(p);
        //Método que toma el ID del cliente para su correspondiente cambio de estado
        public void CN_EliminarCliente(string indice)
        {
            //Envia el parámetro ID a la clase CD_GetData y castea la cadena a un tipo numerico
            objectCD.CD_EliminarCliente(int.Parse(indice));
        }

        public void CN_EliminarPago(string indice) => objectCD.CD_EliminarPago(int.Parse(indice));

        //Retorna las listas obtenidas de la Clase CD_GetData y las retorna a cada Modulo correspondiente para mapearlo con linq
        //Lista de Clientes
        public List<Cliente> CN_DevolverCliente() => objectCD.DevolverListaClientes();
        //Lista de Pagos
        public List<Pago> CN_DevolverPago() => objectCD.DevolverListaPagos();
        //Lista de Facturas
        public List<Factura> CN_DevolverFactura() => objectCD.DevolverListaFacturas();
        //Lista de Reembolsos
        public List<Reembolso> CN_DevolverReembolso() => objectCD.DevolverListaReembolsos();



    }
}
