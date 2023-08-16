using System;
using static System.Net.WebRequestMethods;

namespace Capa_Datos.Entidades
{
    #region Resumen del contenido de la clase Factura
    /// <summary>
    /// Clase que unifica las entidades: 
    /// <list type="bullet">
    /// <item><term>Servicio</term><description>Entidad de la tabla Servicio con sus campos <c>[Id, Descripción, Valor/Unidad]</c></description></item>
    /// <item><term>Cuerpo de la Factura</term><description>Entidad de la tabla DetalleFactura con sus campos 
    /// <c>[Id, IdFactura, IdServicio, Encargado, Cantidad, Total]</c>
    /// </description></item>
    /// <item><term>Cabecera</term><description>Entidad de la tabla Factura con sus campos<c>[Id, IdEmpresa, IdCliente, Fecha, IdPago]</c></description></item>
    /// </list>
    /// </summary>
    /// <remarks>Esta clase unifica las campos de las tablas como una sola que sirve para comprender los atributos de nuestra factura.</remarks>
    #endregion
    public class Factura
    {
        #region Propiedad Código de la Factura
        /// <summary> Propiedad 
        /// <c>Id</c> 
        /// que sirve para representar el código de la cabecera de la factura
        /// </summary>
        /// <returns> Esta propiedad retorna un valor de tipo  <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns>
        #endregion
        public int? Id { get; set; }
        #region Propiedad Código de la Empresa
        /// <summary> Propiedad 
        /// <c>IdEmpresa</c> 
        /// que permite obtener los datos de la empresa <c>AC. REDES</c> 
        /// y representarlos en la cabecera de la factura.
        /// </summary>
        /// <returns>Esta propiedad retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdEmpresa { get; set; }
        #region Propiedad Código del Cliente
        /// <summary>
        /// Propiedad <c>IdCliente</c> 
        /// que sirve para representar los datos del cliente en la cabecera de la factura.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdCliente { get; set; }
        #region Propiedad Cédula del Cliente
        /// <summary> 
        /// Propiedad <c> CedulaCliente </c> 
        /// que representa a la cédula de identidad del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0">decimal</see>
        /// </returns> 
        #endregion
        public decimal? CedulaCliente { get; set; }
        #region Propiedad Fecha de la Facturación
        /// <summary>
        /// Propiedad <c>Fecha</c> 
        /// que representa la fecha en la que se generó la factura.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-7.0">DateTime</see>
        /// </returns> 
        #endregion
        public DateTime Fecha { get; set; }
        #region Propiedad Código del Cuerpo de la Factura
        /// <summary>
        /// Propiedad <c>IdDetalleFactura</c> 
        /// que obtiene los datos del cuerpo de la factura por su código.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdDetalleFactura { get; set; }
        #region Propiedad Código del Servicio Realizado
        ///<summary> 
        ///Propiedad <c>IdServicio</c> 
        ///que sirve para representar el código de la cabecera de la factura.
        ///</summary>
        ///<returns>
        ///Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        ///</returns> 
        #endregion
        public int? IdServicio { get; set; }
        #region Propiedad Nombre del Encargado de realizar la facturación
        /// <summary>
        /// Propiedad <c>IdEncargado</c> 
        /// que obtiene los nombres del Encargado que realizó la factura a partir de su Identificador.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo  <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Encargado { get; set; }
        #region Propiedad Cantidad de productos ligados a un Servicio
        /// <summary>
        /// Propiedad <c>Cantidad</c> 
        /// que representa al número de objetos que se agregaron al servicio.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? Cantidad { get; set; }
        #region Propiedad Total a Pagar de la factura
        /// <summary>
        /// Propiedad <c>Total</c> 
        /// que representa el Total a Pagar y que es parte del cuerpo de la factura.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see>
        /// </returns> 
        #endregion
        public float Total { get; set; }
        #region Propiedad Descripción del Servicio por el que se realiza la Factura
        /// <summary>
        /// Propiedad <c>Descripcion</c> 
        /// que representa la descripción a detalle del servicio que se está realizando.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo  <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Descripcion { get; set; }
        #region Propiedad Valor Unitario de cada producto hecho en el Servicio
        /// <summary>
        /// Propiedad <c>ValorUnitario</c> 
        /// que representa el Valor por Unidad del producto descrito en el Servicio.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types">float</see>
        /// </returns> 
        #endregion
        public float ValorUnitario { get; set; }
        #region Propiedad Estado actual de la Factura
        /// <summary>
        /// Propiedad <c>Estado</c> 
        /// que representa el estado actual de la Factura := <c>[Pagada, Pendiente, Anulada]</c>
        /// </summary>
        /// 
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0">string</see>
        /// </returns> 
        #endregion
        public string Estado { get; set; }
        #region Propiedad Código del Pago del Cliente
        /// <summary>
        /// Propiedad <c>IdPago</c> 
        /// que obtiene los datos del pago realizado por el cliente, a partir del código.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">int</see>
        /// </returns> 
        #endregion
        public int? IdPago { get; set; }
        #region Propiedad Impuesto del valor agregado
        /// <summary>
        /// Propiedad <c>Iva</c> 
        /// que representa el .12 % del adicional que se debe pagar, en caso de haberlo añadido.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <see href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">Boolean</see>
        /// </returns> 
        #endregion
        public Boolean Iva { get; set; }
    }
}
