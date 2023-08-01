using System;

namespace Capa_Datos.Entidades
{
    public class Reembolso
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdServicio { get; set; }
        public string Motivo { get; set; }
    }
}
