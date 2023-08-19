using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Entidades
{
    /// <summary>
    /// Esta clase es un ejemplo para verificar el trabajo colaborativo mediante 
    /// el uso de la herramienta git, para mantener un control de versiones del proyecto
    /// </summary>
    public class Transaccion
    {
        #region Descripción del identificador de la transacción
        /// <summary>
        /// Método <b>bId</b> obtiene el identificador de la transacción.
        /// </summary> 
        #endregion
        public int Id { get; set; }
        #region Descripción del identificador del pago
        /// <summary>
        /// Método <b>bIdPago</b> obtiene el identificador del pago realizado.
        /// </summary> 
        #endregion
        public int IdPago { get; set; }
        #region Descripción del método del pago
        /// <summary>
        /// Método <b>MetodoPago</b> obtiene el métod de pago con el que se realizó la transacción.
        /// </summary> 
        #endregion
    
    }

    /// <summary>
    /// Clase Gerente
    /// </summary>
    public class Gerente
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Cedula { get; set; }
    }
}
