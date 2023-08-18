namespace Capa_Datos.Entidades
{
    #region Resumen del contenido de la Clase Empresa
    /// <summary>
    /// Clase que representa a la entidad Empresa y sus atributos
    /// </summary>
    /// <remarks>Las propiedades de esta clase son referencia a las columnas de nuestra tabla en la Base de Datos.</remarks> 
    #endregion
    public class Empresa
    {
        #region Propiedad Código de la Empresa
        /// <summary> Propiedad 
        /// <c>Id</c> 
        /// que representa al Identificador de la Empresa
        /// </summary>
        /// <returns> Esta propiedad retorna un valor de tipo  <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns>
        #endregion
        public int? Id { get; set; }
        #region Propiedad Estado actual de la Factura
        /// <summary>
        /// Propiedad <c>Descripcion</c> 
        /// que representa una breve descripción de la empresa AC. REDES.
        /// </summary>
        /// 
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Descripcion { get; set; }
        #region Propiedad Estado actual de la Factura
        /// <summary>
        /// Propiedad <c>Nombre</c> 
        /// que representa a la empresa 'AC. REDES'
        /// </summary>
        /// 
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Nombre { get; set; }
        
    }
}
