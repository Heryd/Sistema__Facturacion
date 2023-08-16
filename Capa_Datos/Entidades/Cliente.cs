using System;

namespace Capa_Datos.Entidades
{
    #region Descripción de la Clase Cliente
    /// <summary>
    /// Clase que representa a la entidad Cliente y sus atributos
    /// </summary>
    /// <remarks>
    /// Las propiedades de esta clase son referencia a las columnas de nuestra tabla en la Base de Datos.
    /// </remarks> 
    #endregion
    public class Cliente
    {
        #region Propiedad Código del Cliente
        /// <summary> 
        /// Propiedad <c> ID </c> 
        /// que representa al identificador del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo  <b>int</b>
        /// </returns> 
        #endregion
        public int Id { get; set; }
        #region Propiedad Cédula del Cliente
        /// <summary> 
        /// Propiedad <c> Cedula </c> 
        /// que representa a la cédula de identidad del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <b>decimal</b>
        /// </returns> 
        #endregion
        public decimal Cedula { get; set; }
        #region Propiedad Nombres del Cliente
        /// <summary> 
        /// Propiedad <c> Nombres</c> 
        /// que representa los 2 nombres del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Nombres { get; set; }
        #region Propiedad Apellidos del Cliente
        /// <summary> 
        /// Propiedad <c> Apellidos</c> 
        /// que representa los 2 apellidos del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Apellidos { get; set; }
        #region Propiedad información de contacto del Cliente
        /// <summary> 
        /// Propiedad <c> Correo </c> 
        /// que representa la información de contacto del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Correo { get; set; }
        #region Propiedad dirección del domicilio del Cliente
        /// <summary> 
        /// Propiedad <c> Dirección </c> 
        /// que representa la dirección domiciliaria del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Direccion { get; set; }
        #region Propiedad teléfono que sirve para contactar al Cliente
        /// <summary> 
        /// Propiedad 
        /// <c> Teléfono </c> 
        /// que representa al número de contacto del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[decimal]]>
        /// </returns> 
        #endregion
        public decimal Telefono { get; set; }
        #region Propiedad Género del Cliente
        /// <summary> 
        /// Propiedad 
        /// <c> Género </c> 
        /// que representa el género del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Genero { get; set; }
        #region Propiedad Fecha de registro del Cliente
        /// <summary> 
        /// Propiedad 
        /// <c> Fecha </c> 
        /// que representa la Fecha de creación del registro del cliente.
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[DateTime]]>
        /// </returns> 
        #endregion
        public DateTime Fecha { get; set; }
        #region Propiedad Estado actual del Cliente
        /// <summary> 
        /// Propiedad 
        /// <c> Estado </c> 
        /// que representa el estado actual del cliente. <c>[Activo, Pagando]</c>
        /// </summary>
        /// <returns>
        /// Retorna un valor de tipo <![CDATA[string]]>
        /// </returns> 
        #endregion
        public string Estado { get; set; }
    }
}
