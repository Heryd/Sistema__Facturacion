using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            sqlCommand.Connection = db_connection.OpenConnection();
            sqlCommand.CommandText = sql_Text;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataTable);
            db_connection.CloseConnection();
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
        public void Registro_Pago()
        {

        }
        #endregion
        #region Modulo Cliente
        public void Registro_Cliente()
        {

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
        #endregion
        #region Modulo Pago
        public DataTable Consulta_Pago() => GetData("CONSULTAR_PAGOS");
        #endregion
        #region Modulo Cliente
        public void CD_Nuevo_Cliente(int cedula,string apellidos,string nombres,string genero,string correo, string direccion,int telefono, DateTime fecha)
        {
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = db_connection.OpenConnection();
            sqlComando.CommandText = "NUEVO_CLIENTE";
            sqlComando.CommandType = CommandType.StoredProcedure;

            sqlComando.Parameters.AddWithValue("@NOMBRES", nombres);
            sqlComando.Parameters.AddWithValue("@APELLIDOS", apellidos);
            sqlComando.Parameters.AddWithValue("@CEDULA", cedula);
            sqlComando.Parameters.AddWithValue("@CORREO", correo);
            sqlComando.Parameters.AddWithValue("@DIRECCION", direccion);
            sqlComando.Parameters.AddWithValue("@TELEFONO", telefono);
            sqlComando.Parameters.AddWithValue("@GENERO",genero);
            sqlComando.Parameters.AddWithValue("@FECHA_REGISTRO", fecha);
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
        public DataTable Consulta_Cliente() => GetData("GET_CLIENTES");
        public DataTable Clientes() => GetData("CLIENTES");
        public string CD_GET_CODIGO_CLIENTE()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "GET_CODIGO_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            return Convert.ToString(comando.ExecuteScalar().ToString());
        }

        public void CD_EliminarCliente(int codigo_cliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "ELIMINAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_CLIENTE", codigo_cliente);
            comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

            MessageBox.Show("Cliente Eliminado","Eliminación Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Reembolso
        public DataTable Consulta_Reembolos() => GetData("CONSULTAR_REEMBOLSOS");
        #endregion

        //Stored Procedure - Update
        #region Modulo Factura
        #endregion
        #region Modulo Pago
        #endregion
        #region Modulo Cliente
        #endregion
        #region Modulo Reembolso
        #endregion

        //Stored Procedure - Delete
        #region Modulo Factura
        #endregion
        #region Modulo Pago
        #endregion
        #region Modulo Cliente
        #endregion
        #region Modulo Reembolso
        #endregion
    }
}
