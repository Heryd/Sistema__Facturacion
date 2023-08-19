using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Entidades
{
    internal class Transaccion
    {
        public int Id { get; set; }
        public int IdPago { get; set; }
        public string MetodoPago { get; set; }
    }
}
