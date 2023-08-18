using System;

namespace Capa_Datos.Entidades
{
    #region Descripción de la Clase Pago
    /// <summary>
    /// Clase que representa a la entidad Pago y sus atributos
    /// </summary>
    /// <remarks>
    /// Las propiedades de esta clase son referencia a las columnas de nuestra tabla en la Base de Datos.
    /// </remarks> 
    #endregion
    public class Pago
    {
        #region Propiedad Identificador del Pago
        /// <summary> 
        /// Propiedad <c> ID </c> 
        /// que representa al identificador del pago.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? Id { get; set; }
        #region Propiedad Código del Cliente
        /// <summary> 
        /// Propiedad <c> IdCliente </c> 
        /// que obtiene los datos del cliente a partir de su Identificador.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdCliente { get; set; }
        #region Propiedad fecha del pago
        /// <summary> 
        /// Propiedad <c> Fecha </c> 
        /// que representa la fecha en la que se realizó el pago.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-7.0">DateTime</see>
        /// </returns> 
        #endregion
        public DateTime Fecha{ get; set; }
        #region Propiedad método de realización del pago
        /// <summary> 
        /// Propiedad <c> MetodoPago </c> 
        /// que representa al método con el que realizó el pago el Cliente
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string MetodoPago { get; set; }
        #region Propiedad valor del pago
        /// <summary> 
        /// Propiedad <c> ID </c> 
        /// que representa al valor con el que paga el Cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see>
        /// </returns> 
        #endregion
        public float Valor { get; set; }
        #region Propiedad estado actual del pago
        /// <summary> 
        /// Propiedad <c> ID </c> 
        /// que representa al estado del pago := <c>[Pagado, En Proceso, Reembolsado]</c>
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Estado { get; set; }
    }
}
