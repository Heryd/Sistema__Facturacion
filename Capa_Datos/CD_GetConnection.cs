using System;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class CD_GetConnection
    {
        /*Se asigna la conexion con el nombre del Server y la BD*/
        private SqlConnection db_connection = new SqlConnection("Server=Heryd_Notebook; Database=GS_FAC_03_DB; Integrated Security=true");

        public SqlConnection OpenConnection()
        {
            if (db_connection.State == ConnectionState.Closed)
                db_connection.Open();
            return db_connection;
        }

        public void CloseConnection()
        {
            if (db_connection.State == ConnectionState.Open)
                db_connection.Close();
        }
    }
}
