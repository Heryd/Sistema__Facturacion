using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Datos
{
    public class CD_GetConnection
    {
        //IMPORTANTE CAMBIAR RUTA A LA RUTA DE "TU" BASE DE DATOS

        //Ruta de Conexion
        private SqlConnection db_connection = new SqlConnection("Server=DESKTOP-57GF6Q7\\SQLEXPRESS; Database=GS_FACT_03; Trusted_Connection=True; Integrated Security=true");

        public SqlConnection OpenConnection()
        {
            if (db_connection.State == ConnectionState.Closed)
                db_connection.Open();
            return db_connection;
        }

        public void CloseConnection()=>db_connection.Close();
    }
}
