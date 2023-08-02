using System;

namespace Capa_Datos.Entidades
{
    public class Factura
    {
        public int? Id { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha{ get; set; }
        public int? IdDetalleFactura { get; set; }
        public int? IdServicio { get; set; }
        public string Encargado { get; set; }
        public int? Cantidad { get; set; }
        public float Total { get; set; }
        public string Descripcion { get; set; }
        public float ValorUnitario { get; set; }
        public string Estado { get; set; }
    }
}
