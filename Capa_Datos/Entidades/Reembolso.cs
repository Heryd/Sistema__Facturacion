using System;

namespace Capa_Datos.Entidades
{
    #region Descripción de la Clase Reembolso
    /// <summary>
    /// Clase que representa a la entidad Reembolso y sus atributos
    /// </summary>
    /// <remarks>
    /// Las propiedades de esta clase son referencia a las columnas de nuestra tabla en la Base de Datos.
    /// </remarks> 
    #endregion
    public class Reembolso
    {
        #region Propiedad Código del Reembolso
        /// <summary> 
        /// Propiedad <c> ID </c> 
        /// que representa al identificador del reembolso.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? Id { get; set; }
        #region Propiedad Código de la Factura
        /// <summary> 
        /// Propiedad <c> IdFactura </c> 
        /// que obtiene los datos de la factura a partir de su identificador.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdFactura { get; set; }
        #region Propiedad Código del Pago
        /// <summary> 
        /// Propiedad <c> IdPago </c> 
        /// que obtiene los datos del pago realizado de la factura a partir de su identificador.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdPago { get; set; }
        #region Propiedad Código del Servicio
        /// <summary> 
        /// Propiedad <c> IdServicio </c> 
        /// que obtiene los detalles del servicio de la factura.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdServicio { get; set; }
        #region Propiedad motivo del reembolso
        /// <summary> 
        /// Propiedad <c> Motivo </c> 
        /// que representa la razón por la que el cliente desea obtener el reembolso de su pago y la anulación de su factura.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Motivo { get; set; }
        #region Propiedad fecha del reembolso
        /// <summary> 
        /// Propiedad <c> Fecha </c> 
        /// que representa a la fecha en la que se realizó el reembolso
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-7.0">DateTime</see>
        /// </returns> 
        #endregion
        public DateTime Fecha { get; set; }
        #region Propiedad Cédula del Cliente
        /// <summary> 
        /// Propiedad <c> Cedula </c> 
        /// que representa a la cédula de identidad del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0">decimal</see>
        /// </returns> 
        #endregion
        public decimal Cedula { get; set; }
    }
}
