using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Capa_Datos.Entidades;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Globalization;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Datos
{
    public class CD_GetData
    {
        private CD_GetConnection db_connection = new CD_GetConnection();

        public DataTable GetData(string sql_Text)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter;
            try
            {
                sqlCommand.Connection = db_connection.OpenConnection();
                sqlCommand.CommandText = sql_Text;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                db_connection.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo establecer la conexión a la Base de Datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        //Stored Procedure - Login Validation
        #region Login
        public bool Login_Validation(string usuario, string password)
        {
            bool bandera = true;
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "Login_Validation";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@USER_NAME", usuario);
            comando.Parameters.AddWithValue("@PASSWORD", password);
            string resultado = Convert.ToString(comando.ExecuteScalar().ToString());
            if (resultado.StartsWith("ERROR: USUARIO"))
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = false;
            }
            else
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db_connection.CloseConnection();
            return bandera;
        }
        #endregion

        //Stored Procedure - Register
        #region Modulo Factura
        public void Registro_Factura()
        {

        }
        #endregion
        #region Modulo Pago
        //Registra un nuevo Pago
        public void CD_NuevoPago(Pago p)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "NUEVO_PAGO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@CODIGO_CLIENTE",p.IdCliente);
            sqlComando.Parameters.AddWithValue("@FECHA",p.Fecha);
            sqlComando.Parameters.AddWithValue("@METODO_PAGO", p.MetodoPago);
            sqlComando.Parameters.AddWithValue("@EFECTIVO", p.Valor);

            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            if(resultado.StartsWith("Pago"))
                MessageBox.Show(resultado, "Nuevo Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultado, "Nuevo Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        public void CD_Nuevo_Cliente(Cliente c)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "NUEVO_CLIENTE";
            sqlComando.CommandType = CommandType.StoredProcedure;

            sqlComando.Parameters.AddWithValue("@NOMBRES", c.Nombres);
            sqlComando.Parameters.AddWithValue("@APELLIDOS", c.Apellidos);
            sqlComando.Parameters.AddWithValue("@CEDULA", c.Cedula);
            sqlComando.Parameters.AddWithValue("@CORREO", c.Correo);
            sqlComando.Parameters.AddWithValue("@DIRECCION", c.Direccion);
            sqlComando.Parameters.AddWithValue("@TELEFONO", c.Telefono);
            sqlComando.Parameters.AddWithValue("@GENERO", c.Genero);
            sqlComando.Parameters.AddWithValue("@FECHA_REGISTRO", c.Fecha);
            sqlComando.Parameters.AddWithValue("@ESTADO", c.Estado);
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            if (resultado.StartsWith("ERROR: El cliente ya se encuentra registrado."))
            {
                MessageBox.Show(resultado, "Fallo al crear registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(resultado, "Registro creado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Reembolso
        public void Registro_Reembolso()
        {

        }
        #endregion

        //Stored Procedure - Queries
        #region Modulo Factura
        public DataTable Consulta_Facturas() => GetData("CONSULTAR_FACTURAS");
        //Devuelve los registros de la Tabla Factura y los guarda en una lista para luego poder mapearlos
        public List<Factura> DevolverListaFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "FACTURAS";
            comando.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Factura factura = new Factura();
                    //Factura
                    factura.Id = (int)reader["ID_FACTURA"];
                    factura.IdEmpresa = (int)reader["ID_EMPRESA"];
                    factura.IdCliente= (int)reader["ID_CLIENTE"];
                    //Detalle de la Factura
                    factura.IdDetalleFactura = (int)reader["ID_DETALLE_FACTURA"];
                    factura.IdServicio = (int)reader["ID_SERVICIO"];
                    factura.Encargado = reader["NOMBRE_ENCARGADO"].ToString();
                    factura.Cantidad = (int)reader["CANTIDAD"];
                    factura.Total = (decimal)reader["TOTAL_PAGAR"];
                    //Servicio
                    factura.Descripcion = reader["DESCRIPCION_SERVICIO"].ToString();
                    factura.ValorUnitario = (decimal)reader["VALOR_UNITARIO"];
                    facturas.Add(factura);
                }
            }
            db_connection.CloseConnection();
            return facturas;
        }
        #endregion
        #region Modulo Pago
        public DataTable Consulta_Pago() => GetData("CONSULTAR_PAGOS");
        //Devuelve los registros de la Tabla Pago y los guarda en una lista para luego poder mapearlos con Linq
        public List<Pago> DevolverListaPagos()
        {
            List<Pago> pagos = new List<Pago>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "SELECT * FROM PAGO";
            comando.CommandType = CommandType.Text;

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Pago pago = new Pago();
                    pago.Id = (int)reader["ID_PAGO"];
                    pago.Fecha = (DateTime)reader["FECHA_PAGO"];
                    pago.MetodoPago = reader["METODO_PAGO"].ToString().ToUpper();
                    // Convertir el valor de EFECTIVO a float usando CultureInfo
                    pago.Valor = Convert.ToSingle(reader["EFECTIVO"], CultureInfo.InvariantCulture);
                    pago.IdCliente = (int)reader["ID_CLIENTE"];

                    pagos.Add(pago);
                }
            }
            db_connection.CloseConnection();
            return pagos;
        }
        #endregion
        #region Modulo Cliente
        //Devuelve los registros de la Tabla cliente y los guarda en una lista para luego poder mapearlos
        public List<Cliente> DevolverListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "SELECT * FROM CLIENTE";
            comando.CommandType = CommandType.Text;

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)reader["ID_CLIENTE"];
                    cliente.Cedula = (decimal)reader["CEDULA"];
                    cliente.Nombres = reader["NOMBRES"].ToString().ToUpper();
                    cliente.Apellidos = reader["APELLIDOS"].ToString().ToUpper();
                    cliente.Correo = reader["CORREO"].ToString();
                    cliente.Telefono = (decimal)reader["TELEFONO"];
                    cliente.Direccion = reader["DIRECCION"].ToString().ToUpper();
                    cliente.Genero = reader["GENERO"].ToString().ToUpper();
                    cliente.Fecha = (DateTime)reader["FECHA_REGISTRO"];
                    cliente.Estado = reader["ESTADO"].ToString().ToUpper();

                    clientes.Add(cliente);
                }
            }
            db_connection.CloseConnection();
            return clientes;
        }
        //Obtiene los registros de la tabla cliente en orden [Id,Cedula,Nombres+Apellidos,Telefono,Correo,Fecha]
        public DataTable Consulta_Cliente() => GetData("GET_CLIENTES");
        //Obtiene los registros de la tabla cliente en orden [Id,Cedula,Nombres+Apellidos,Correo,Genero,Fecha,Estado]
        public DataTable Clientes() => GetData("CLIENTES");
        #endregion
        #region Modulo Reembolso
        public DataTable Consulta_Reembolos() => GetData("CONSULTAR_REEMBOLSOS");
        #endregion

        //Stored Procedure - Update
        #region Modulo Factura
        #endregion
        #region Modulo Pago
        //Actualiza el registro existente de un Cliente
        public void CD_ActualizarPago(Pago p)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_PAGO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@ID_PAGO", p.Id);
            sqlComando.Parameters.AddWithValue("@FECHA", p.Fecha);
            sqlComando.Parameters.AddWithValue("@METODO_PAGO", p.MetodoPago);
            sqlComando.Parameters.AddWithValue("@VALOR", p.Valor);
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        //Actualiza el registro existente de un Cliente
        public void CD_ActualizarCliente(Cliente c)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_CLIENTE",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@NOMBRES", c.Nombres);
            sqlComando.Parameters.AddWithValue("@APELLIDOS", c.Apellidos);
            sqlComando.Parameters.AddWithValue("@CEDULA", c.Cedula);
            sqlComando.Parameters.AddWithValue("@CORREO", c.Correo);
            sqlComando.Parameters.AddWithValue("@DIRECCION", c.Direccion);
            sqlComando.Parameters.AddWithValue("@TELEFONO", c.Telefono);
            sqlComando.Parameters.AddWithValue("@GENERO", c.Genero);
            sqlComando.Parameters.AddWithValue("@FECHA_REGISTRO", c.Fecha);
            sqlComando.Parameters.AddWithValue("@ESTADO", c.Estado);
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Reembolso
        #endregion

        //Stored Procedure - Delete
        #region Modulo Factura
        #endregion
        #region Modulo Pago
        //Elimina un registro de pago
        public void CD_EliminarPago(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "ELIMINAR_PAGO";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_PAGO", id);
            comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

            MessageBox.Show("Pago Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        //Eliminar el cliente a través de su Cédula
        public void CD_EliminarCliente(int codigo_cliente)
        {
            SqlCommand comando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ELIMINAR_CLIENTE",
                CommandType = CommandType.StoredProcedure
            };

            comando.Parameters.AddWithValue("@ID_CLIENTE", codigo_cliente);
            comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

            MessageBox.Show("Cliente Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Reembolso
        #endregion
    }
}
