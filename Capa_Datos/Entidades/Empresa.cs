namespace Capa_Datos.Entidades
{
    /// <summary>
    /// Clase que representa a la entidad Empresa y sus atributos
    /// </summary>
    /// <remarks>Las propiedades de esta clase son referencia a las columnas de nuestra tabla en la Base de Datos.</remarks>
    public class Empresa
    {
        /// <value>Propiedad <c>ID</c> que representa al Identificador de la Empresa</value>
        public int? Id { get; set; }
        /// <value>Propiedad <c>Descripción</c> que representa una breve descripción de la empresa AC. REDES</value>
        public string Descripcion { get; set; }
        /// <value>Propiedd <c>Nombre</c> que representa a la empresa 'AC. REDES'</value>
        public string Nombre { get; set; }
        
    }
}
