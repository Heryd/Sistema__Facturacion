using System;

namespace Capa_Datos.Entidades
{
    public class Cliente
    {
        public int Id{ get; set; }
        public decimal Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }
        public string Genero{ get; set; }
        public DateTime Fecha{ get; set; }
        public string Estado{ get; set; }
    }
}
