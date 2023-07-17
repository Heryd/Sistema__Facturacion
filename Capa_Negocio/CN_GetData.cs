using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public object CN_CONSULTAR_CLIENTES() => objectCD.Consulta_Cliente();
        public object CN_CLIENTES() => objectCD.Clientes();

        public DataTable CN_ShowData(string sql_text) => objectCD.GetData(sql_text);

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

        public void CN_Show_Buttons_DTGV(DataGridViewCellPaintingEventArgs e, DataGridView dataGridView, Bitmap edit_min_20x20, Bitmap delete_min_20x20)
          {
               if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
               {
                    return;
               }
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

          public string ObtenerFechaActual() => DateTime.Today.ToString("D");

        public string CN_GET_CODIGO_CLIENTE() => objectCD.CD_GET_CODIGO_CLIENTE();

        public void CN_Nuevo_Cliente(string cedula, string apellidos, string nombres, string genero, string correo, string direccion, string telefono,DateTime fecha)
        {
            objectCD.CD_Nuevo_Cliente(Int32.Parse(cedula),apellidos,nombres,genero,correo,direccion,Int32.Parse(telefono),fecha);
        }

        public void CN_EliminarCliente(string indice)
        {
            objectCD.CD_EliminarCliente(Int32.Parse(indice));
        }
    }
}
