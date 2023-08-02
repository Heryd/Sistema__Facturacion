using System;

namespace Capa_Datos.Entidades
{
    public class Pago
    {
        public int? Id { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha{ get; set; }
        public string MetodoPago { get; set; }
        public float Valor { get; set; }
        public string Estado { get; set; }
    }
}
