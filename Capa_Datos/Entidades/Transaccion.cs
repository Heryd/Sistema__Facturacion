using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Entidades
{
    /// <summary>
    /// Clase Transaccion
    /// </summary>
    public class Transaccion
    {
        public int Id { get; set; }
        public int IdPago { get; set; }
        public string MetodoPago { get; set; }
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
