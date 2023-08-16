using System.Data;
using System.Data.SqlClient;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Datos
{

    #region Descripción de la Clase CD_GetConnection
    /// <summary>
    /// Esta clase se encarga de establecer y cerrar la conexión con la Base de Datos
    /// <list type="bullet">
    /// <item>
    /// <term>OppenConnection</term>
    /// <description>Abre la conexión con la Base de Datos</description>
    /// </item>
    /// <item>
    /// <term>CloseConnection</term>
    /// <description>Cierra la conexión con la Base de Datos</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>Esta clase solo sirve para establecer la conexión de nuestra Base de Datos</remarks> 
    #endregion
    public class CD_GetConnection
    {
        //IMPORTANTE CAMBIAR RUTA A LA RUTA DE "TU" BASE DE DATOS

        //Ruta de Conexion
        private readonly SqlConnection db_connection = new SqlConnection("Server=DESKTOP-57GF6Q7\\SQLEXPRESS; Database=GS_FACT_03; Trusted_Connection=True; Integrated Security=true");

        #region Método para abrir la conexión
        /// <summary>
        /// Abre la conexión con la Base de Datos, si está cerrada.
        /// </summary>
        /// <returns>
        /// Devuelve el objeto de la conexión a la Base de Datos.
        /// </returns> 
        #endregion
        public SqlConnection OpenConnection()
        {
            if (db_connection.State == ConnectionState.Closed)
                db_connection.Open();
            return db_connection;
        }

        #region Método para cerrar la conexión
        /// <summary>
        /// Cierra la conexión con la Base de Datos.
        /// </summary> 
        #endregion
        public void CloseConnection() => db_connection.Close();
    }
}
