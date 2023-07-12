using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
