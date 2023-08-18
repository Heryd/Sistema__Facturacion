using Capa_Datos;
using Capa_Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Negocio
{
    #region Descripcion clase CN_GetData
    /// <summary>
    /// Se encarga de servir como mediador entre la Capa Presentación y Capa Datos. 
    /// Envía datos de registros y obtiene las listas para mapearlas con linq.
    /// </summary>
    /// <remarks><b>Solo sirve para envíar registros, obtener listas y castear tipos de datos.</b></remarks> 
    #endregion
    public class CN_GetData
    {
        #region Atributos
        /// <summary>
        /// Objeto de solo lectura que sirve para acceder a los métodos de la clase <b>CD_GetData</b>.
        /// </summary> 
        #endregion
        private readonly CD_GetData objectCD = new CD_GetData();

        #region Descripción Método 1 para consular clientes
        /// <summary>
        /// Método 1 para obtener campos específicos de una tabla de registros de clientes
        /// </summary>
        /// <returns>Retorna un DataTable</returns> 
        #endregion
        public object CN_CONSULTAR_CLIENTES() => objectCD.Consulta_Cliente();
        #region Descripción Método 2 para consular clientes
        /// <summary>
        /// Método 2 para obtener campos específicos de una tabla de registros de clientes
        /// </summary>
        /// <returns>Retorna un DataTable</returns> 
        #endregion
        public object CN_CLIENTES() => objectCD.Clientes();

        public object CN_ConsultaPagos() => objectCD.Consulta_Pago();

        public DataTable CN_ShowData(string sql_text) => objectCD.GetData(sql_text);

        #region Método para añadir botones al DataGridView
        /// <summary>
        /// Método para añadir botones de editar y eliminar a las tablas de consultas
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <remarks><b>Este método no retorna ningún valor</b></remarks> 
        #endregion
        public void CN_Add_Buttons_DTGV(DataGridView dataGridView)
        {
            //Crea el botón para Editar
            DataGridViewButtonColumn btn_Editar_Factura = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = ""
            };
            //Crear el botón para Eliminar
            DataGridViewButtonColumn btn_Eliminar_Factura = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = ""
            };
            //Los añade al DataGridView de origen
            dataGridView.Columns.Add(btn_Editar_Factura);
            dataGridView.Columns.Add(btn_Eliminar_Factura);
        }

        #region Método para asignar iconos y estilo a los botones
        /// <summary>
        /// Método para ajustar las imagenes de los botones 'Editar' y 'Eliminar' del DataGridView
        /// </summary>
        /// <param name="e">La instancia actual del objeto</param>
        /// <param name="dataGridView">El DataGridView de origen</param>
        /// <param name="edit_min_20x20">El icono para el botón editar</param>
        /// <param name="delete_min_20x20">El icono para el botón eliminar</param> 
        #endregion
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

        #region Método para obtener la Fecha Actual en un formato específico
        /// <summary>
        /// Método que retorna la fecha actual en un formato específico. Ejemplo -> <b>Jueves, Septiembre 28, 2023</b>
        /// </summary>
        /// <returns>Retorna el valor de la fecha actual <b>[día de la Semana, Mes - Día, Año]</b> como string.</returns> 
        #endregion
        public string ObtenerFechaActual() => DateTime.Today.ToString("D");

        #region Método para ingresar un nuevo registro de cliente a la Base de Datos
        /// <summary>
        /// Método que envia los valores obtenidos del Nuevo Cliente para su correspondiente registro en la BD
        /// </summary>
        /// <param name="cl">Objeto de tipo Cliente.</param>
        /// <remarks><b>Este método no retorna ningún valor</b></remarks> 
        #endregion
        public void CN_Nuevo_Cliente(Cliente cl)=> objectCD.CD_Nuevo_Cliente(cl);
        
        #region Método que envía un registro de un Pago y lo actualiza 
        /// <summary>
        /// Método para registrar un Pago 
        /// <paramref name="p"/>.
        /// </summary>
        /// <param name="p">Objeto de tipo Pago.</param> 
        #endregion
        public void CN_Nuevo_Pago(Pago p) => objectCD.CD_NuevoPago(p);

        #region Método que envía un registro de un Pago y lo actualiza 
        /// <summary>
        /// Método para registrar una Factura de un cliente
        /// <paramref name="f"/>.
        /// </summary>
        /// <param name="p">Objeto de tipo Factura.</param> 
        #endregion
        public void CN_Nueva_Factura(Factura f) => objectCD.CD_NuevaFactura(f);
        
        #region Método que realiza el reembolso de un pago y anula la factura relacionada a ese pago
        /// <summary>
        /// Método para registrar un Reembolso
        /// <paramref name="r"/>.
        /// </summary>
        /// <param name="r">Objeto de tipo Reembolso.</param> 
        #endregion
        public void CN_Nuevo_Reembolso(Reembolso r) => objectCD.CD_NuevoReembolso(r);

        #region Método que envía un registro de un Cliente y lo actualiza 
        /// <summary>
        /// Método para actualizar el registro existente de un Cliente
        /// <paramref name="cl"/>, existente a partir de nuevos datos.
        /// </summary>
        /// <param name="cl">Objeto de tipo Cliente.</param> 
        #endregion
        public void CN_ActualizarCliente(Cliente cl) => objectCD.CD_ActualizarCliente(cl);

        #region Método que envía un registro de un Pago y lo actualiza 
        /// <summary>
        /// Método para actualizar el registro existente de un Pago
        /// <paramref name="p"/>, existente a partir de nuevos datos.
        /// </summary>
        /// <param name="p">Objeto de tipo Pago.</param> 
        #endregion
        public void CN_ActualizarPago(Pago p) => objectCD.CD_ActualizarPago(p);

        #region Método que envía un registro de una Factura y lo actualiza 
        /// <summary>
        /// Método para actualizar el registro existente de una Factura
        /// <paramref name="f"/>, existente a partir de nuevos datos.
        /// </summary>
        /// <param name="f">Objeto de tipo Factura.</param> 
        #endregion
        public void CN_ActualizarFactura(Factura f) => objectCD.CD_ActualizarFactura(f);

        #region Método que envía un registro de un Reembolso y lo actualiza 
        /// <summary>
        /// Método para actualizar el registro existente de un Reembolso
        /// <paramref name="r"/>, existente a partir de nuevos datos.
        /// </summary>
        /// <param name="r">Objeto de tipo Reembolso.</param> 
        #endregion
        public void CN_ActualizarReembolso(Reembolso r) => objectCD.CD_ActualizarReembolso(r);

        #region Método para eliminar un registro existente de un cliente de la Base de Datos
        /// <summary>
        /// Método que toma el ID del cliente para su correspondiente eliminación
        /// </summary>
        /// <param name="indice">Código del Cliente := Cédula</param> 
        #endregion
        public void CN_EliminarCliente(string indice)=>objectCD.CD_EliminarCliente(int.Parse(indice));
        
        #region Método para eliminar un registro existente de un pago de la Base de Datos
        /// <summary>
        /// Método que toma el ID del pago para su correspondiente eliminación
        /// </summary>
        /// <param name="indice">Código del Pago := IdPago</param> 
        #endregion
        public void CN_EliminarPago(string indice) => objectCD.CD_EliminarPago(int.Parse(indice));

        public void CN_EliminarReembolso(string indice)=> objectCD.CD_EliminarReembolso(int.Parse(indice));
        #region Listas de cada módulo para poder mapear con Linq.
        #region Método para obtener una Lista de Clientes
        /// <summary>
        /// Método que obtiene una lista con registros de tipo Cliente para su correspondiente mapeo.
        /// </summary>
        /// <returns>Retorna una Lista de clientes</returns> 
        #endregion
        public List<Cliente> CN_DevolverCliente() => objectCD.DevolverListaClientes();
        #region Método para obtener una Lista de Pagos
        /// <summary>
        /// Método que obtiene una lista con registros de tipo Pago para su correspondiente mapeo.
        /// </summary>
        /// <returns>Retorna una Lista de pagos</returns> 
        #endregion
        public List<Pago> CN_DevolverPago() => objectCD.DevolverListaPagos();
        #region Método para obtener una Lista de Facturas
        /// <summary>
        /// Método que obtiene una lista con registros de tipo Factura para su correspondiente mapeo.
        /// </summary>
        /// <returns>Retorna una Lista de facturas</returns> 
        #endregion
        public List<Factura> CN_DevolverFactura() => objectCD.DevolverListaFacturas();
        #region Método para obtener una Lista de Reembolsos
        /// <summary>
        /// Método que obtiene una lista con registros de tipo Reembolso para su correspondiente mapeo.
        /// </summary>
        /// <returns>Retorna una Lista de reembolsos</returns> 
        #endregion
        public List<Reembolso> CN_DevolverReembolso() => objectCD.DevolverListaReembolsos();
        #endregion
    }
}
