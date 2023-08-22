using Capa_Datos.Conexion.DBExceptions;
using Capa_Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Datos
{
    #region Descripción de la Clase Get_Data
    /// <summary>
    /// Administra los métodos CRUD que nos ayudarán a interactuar con nuestra Base de Datos
    /// </summary> 
    /// <remarks>
    /// <c>Esta clase solo administra solo sirve para administrar los registros de la Base de Datos.</c>
    /// </remarks>
    #endregion
    public class CD_GetData
    {
        private readonly CD_GetConnection db_connection = new CD_GetConnection();

        #region Método para setear registros a un DataTable
        /// <summary>
        /// Se encarga de obtener los registros mediante un Store Procedure que
        /// se encuentra en nuestra Base de Datos.
        /// </summary>
        /// <param name="sql_Text">Recibe el nombre de un Store Procedure</param>
        /// <returns>
        /// Retorna un objeto de tipo <![CDATA[DataTable]]>
        /// </returns> 
        #endregion
        public DataTable GetData(string sql_Text)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter;
            try
            {
                sqlCommand.Connection = db_connection.OpenConnection();
                sqlCommand.CommandText = sql_Text;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                db_connection.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ha habido algun problema/conflicto con la base de datos!" + Environment.NewLine +
                                "Intentelo de nuevo o pongase en contacto con el DBA", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        #region Login
        /// <summary>
        /// <para>Este método se encarga de validar el inicio de sesión cuando alguien intenta logearse por medio de sus credenciales.</para>
        /// Si estas existen entonces el inicio de sesión será exitoso.
        /// </summary>
        /// <param name="usuario">Identificador del Usuario</param>
        /// <param name="password">Contraseña del Usuario</param>
        /// <returns>
        /// Retorna un boolean
        /// <list type="bullet">
        /// <item>
        /// <term>True</term>
        /// <description>Si el inicio fue exitoso.</description>
        /// </item>
        /// <item>
        /// <term>False</term>
        /// <description>Si las credenciales fueron incorrectas o si el usuario ingresado no se encuentra registrado</description>
        /// </item>
        /// </list>
        /// </returns>
        public bool Login_Validation(string usuario, string password)
        {
            bool bandera = true;
            SqlCommand comando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "Login_Validation",
                CommandType = CommandType.StoredProcedure,
            };
            comando.Parameters.AddWithValue("@USER_NAME", usuario);
            comando.Parameters.AddWithValue("@PASSWORD", password);
            //Obtiene el resultado del 'Select' y lo guarda en una variable de tipo String 
            string resultado = Convert.ToString(comando.ExecuteScalar().ToString());
            //Si el retorno del Select comienza con 'Error' entonces devuelve un mensaje de inicio de sesión fallido
            if (resultado.StartsWith("ERROR: USUARIO"))
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = false;
            }
            //De lo contrario devuelve un mensaje de inicio de sesión exitoso e ingresa al Formulario del Menú
            else
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Por último cierra la conexión
            db_connection.CloseConnection();
            return bandera;
        }

        /// <summary>
        /// SP DE USUARIO Y VENTANA DE LOGIN, verifica si las credenciales son correctas
        /// </summary>
        /// <param name="usuario">El identificador del usuario</param>
        /// <param name="password">La clave de acceso</param>
        /// <returns></returns>
        public bool ValidarUsuario(string usuario, string password)
        {
            bool bandera = true;
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_connection.OpenConnection();
            comando.CommandText = "Validar_Login_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@USER_NAME", usuario);
            comando.Parameters.AddWithValue("@PASSWORD", password);
            string resultado = Convert.ToString(comando.ExecuteScalar().ToString());
            if (resultado.StartsWith("ERROR: USUARIO"))
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = false;
            }
            else
            {
                MessageBox.Show(resultado, "INICIO DE SESI\u00d3N EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db_connection.CloseConnection();
            return bandera;
        }

        /// <summary>
        /// Este método se encarga de obtener el nombre de usuario y rol
        /// </summary>
        /// <param name="user">Identificador del usuario</param>
        /// <param name="clave">Clave de acceso</param>
        /// <returns>Devuelve el nombre del usuario y su rol asignado</returns>
        public string Set_User_Rol(string user, string clave)
        {
            string nombreUsuario = "";
            string nombreRol = "";
            SqlCommand command = new SqlCommand();
            command.Connection = db_connection.OpenConnection();
            command.CommandText = "OBTENER_USUARIO_Y_ROL";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@USERNAME", user);
            command.Parameters.AddWithValue("@PASSWORD", clave);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nombreUsuario = reader["NOMBRE_USUARIO"].ToString();
                nombreRol = reader["NOMBRE_ROL"].ToString();
            }
            db_connection.CloseConnection();
            return "USUARIO: " + nombreUsuario + ", ROL: " + nombreRol;
        }
        #endregion

        //Registros
        #region Modulo Factura
        /// <summary>
        /// Método que se encarga de registrar una factura haciendo uso de un Stored Procedure.
        /// </summary>
        public void CD_NuevaFactura(Factura f)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "NUEVA_FACTURA",
                CommandType = CommandType.StoredProcedure
            };

            //Envía los campos del objeto factura al sp de la base de datos para su correspondiente asignación a los parámetros
            sqlComando.Parameters.AddWithValue("@idCliente", f.IdCliente);
            sqlComando.Parameters.AddWithValue("@descripcionServ", f.Descripcion);
            sqlComando.Parameters.AddWithValue("@cantidad", f.Cantidad);
            sqlComando.Parameters.AddWithValue("@valorUnitario", f.ValorUnitario);
            sqlComando.Parameters.AddWithValue("@nombreEncargado", f.Encargado);
            sqlComando.Parameters.AddWithValue("@fecha", f.Fecha);
            sqlComando.Parameters.AddWithValue("@total", f.Total);

            //Toma el valor que devuelve el sp
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());

            //Mensaje que se presenta al registrar la factura
            if (resultado.StartsWith("Factura"))
                MessageBox.Show(resultado, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultado, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Pago
        /// <summary>
        /// Método para registrar el nuevo pago que realiza un cliente
        /// </summary>
        /// <param name="p"> Objeto de tipo Pago</param>
        public void CD_NuevoPago(Pago p)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "NUEVO_PAGO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@CODIGO_CLIENTE", p.IdCliente);
            sqlComando.Parameters.AddWithValue("@FECHA", p.Fecha);
            sqlComando.Parameters.AddWithValue("@METODO_PAGO", p.MetodoPago);
            sqlComando.Parameters.AddWithValue("@EFECTIVO", p.Valor);

            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            if (resultado.StartsWith("Pago"))
                MessageBox.Show(resultado, "Nuevo Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(resultado, "Nuevo Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        public void CD_Nuevo_Cliente(Cliente c)
        {
            try
            {
                SqlCommand sqlComando = new SqlCommand
                {
                    Connection = db_connection.OpenConnection(),
                    CommandText = "NUEVO_CLIENTE",
                    CommandType = CommandType.StoredProcedure
                };

                sqlComando.Parameters.AddWithValue("@NOMBRES", c.Nombres);
                sqlComando.Parameters.AddWithValue("@APELLIDOS", c.Apellidos);
                sqlComando.Parameters.AddWithValue("@CEDULA", c.Cedula);
                sqlComando.Parameters.AddWithValue("@CORREO", c.Correo);
                sqlComando.Parameters.AddWithValue("@DIRECCION", c.Direccion);
                sqlComando.Parameters.AddWithValue("@TELEFONO", c.Telefono);
                sqlComando.Parameters.AddWithValue("@GENERO", c.Genero);
                sqlComando.Parameters.AddWithValue("@FECHA_REGISTRO", c.Fecha);

                string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
                // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
                if (resultado.StartsWith("ERROR: El cliente ya se encuentra registrado."))
                {
                    MessageBox.Show(resultado, "Fallo al crear registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Registro creado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                db_connection.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ha habido algun problema/conflicto con la base de datos!" + Environment.NewLine +
                "Intentelo de nuevo o pongase en contacto con el DBA", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Modulo Reembolso
        /// <summary>
        /// Método que envía ciertos atributos de la clase reembolso al sp de Nuevo_Reembolso y genera el registro.
        /// </summary>
        /// <param name="r">Objeto de tipo Reembolso con los datos a registrar.</param> 
        public void CD_NuevoReembolso(Reembolso r)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "NUEVO_REEMBOLSO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@codigoFactura", r.IdFactura);
            sqlComando.Parameters.AddWithValue("@cedula", r.Cedula);
            sqlComando.Parameters.AddWithValue("@codigoPago", r.IdPago);
            sqlComando.Parameters.AddWithValue("@motivoReembolso", r.Motivo);
            sqlComando.Parameters.AddWithValue("@fecha", r.Fecha);

            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());

            if (resultado.Contains("Esta factura ya fue anulada y el pago del cliente reembolsado"))
                MessageBox.Show(resultado, "Fallo del reembolso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(resultado, "Registro del Reembolso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion

        //Consultas
        #region Modulo Factura
        #region Descripción de Consulta de Facturas
        /// <summary>
        /// Devuelve los registros de la Tabla Factura y los guarda en una lista para luego poder mapearlos
        /// </summary>
        /// <returns>Retorna una <see href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0">lista</see> de facturas</returns> 
        #endregion
        public List<Factura> DevolverListaFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            SqlCommand comando = new SqlCommand()
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "FACTURAS",
                CommandType = CommandType.StoredProcedure
            };
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Factura factura = new Factura()
                    {
                        //Factura
                        Id = (int)reader["ID_FACTURA"],
                        CedulaCliente = (decimal)reader["CEDULA"],
                        IdEmpresa = (int)reader["ID_EMPRESA"],
                        IdCliente = (int)reader["ID_CLIENTE"],
                        Fecha = (DateTime)reader["FECHA_FACTURACION"],
                        //Detalle de la 
                        IdDetalleFactura = (int)reader["ID_DETALLE_FACTURA"],
                        IdServicio = (int)reader["ID_SERVICIO"],
                        Encargado = reader["NOMBRE_ENCARGADO"].ToString(),
                        Cantidad = (int)reader["CANTIDAD"],
                        Total = Convert.ToSingle(reader["TOTAL_PAGAR"], CultureInfo.InvariantCulture),
                        //Servicio
                        Descripcion = reader["DESCRIPCION_SERVICIO"].ToString(),
                        ValorUnitario = (float)Convert.ToSingle(reader["VALOR_UNITARIO"], CultureInfo.InvariantCulture),
                        Estado = reader["ESTADO"].ToString()
                    };
                    facturas.Add(factura);
                }
            }
            db_connection.CloseConnection();
            return facturas;
        }
        #endregion
        #region Modulo Pago
        public DataTable Consulta_Pago() => GetData("CONSULTAR_PAGOS");

        #region Descripción de la consulta de Pagos
        /// <summary>
        /// Devuelve los registros de la Tabla Pago y los guarda en una lista para luego poder mapearlos con Linq.
        /// </summary>
        /// <returns>Retorna una <see href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0">lista</see> de pagos.</returns> 
        #endregion
        public List<Pago> DevolverListaPagos()
        {
            List<Pago> pagos = new List<Pago>();
            try
            {
                SqlCommand comando = new SqlCommand()
                {
                    Connection = db_connection.OpenConnection(),
                    CommandText = "SELECT * FROM PAGO",
                    CommandType = CommandType.Text
                };

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pago pago = new Pago()
                        {
                            Id = (int)reader["ID_PAGO"],
                            Fecha = (DateTime)reader["FECHA_PAGO"],
                            MetodoPago = reader["METODO_PAGO"].ToString().ToUpper(),
                            // Convertir el valor de EFECTIVO a float usando CultureInfo
                            Valor = Convert.ToSingle(reader["EFECTIVO"], CultureInfo.InvariantCulture),
                            IdCliente = (int)reader["ID_CLIENTE"],
                            Estado = reader["ESTADO"].ToString()
                        };
                        pagos.Add(pago);
                    }
                }

                db_connection.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ha habido algun problema/conflicto con la base de datos!" + Environment.NewLine +
                "Intentelo de nuevo o pongase en contacto con el DBA", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pagos;
        }
        #endregion
        #region Modulo Cliente
        /// <summary>
        /// Devuelve los registros de la Tabla cliente y los guarda en una lista para luego poder mapearlos
        /// </summary>
        /// <returns>Una lista de Clientes</returns>
        /// <exception cref="DBErrorException"></exception>
        public List<Cliente> DevolverListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = db_connection.OpenConnection(),
                    CommandText = "SELECT * FROM CLIENTE",
                    CommandType = CommandType.Text
                };

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Crea el objeto
                        Cliente cliente = new Cliente()
                        {
                            //Asigna los valores de las columnas a los atributos del objeto
                            Id = (int)reader["ID_CLIENTE"],
                            Cedula = (decimal)reader["CEDULA"],
                            Nombres = reader["NOMBRES"].ToString().ToUpper(),
                            Apellidos = reader["APELLIDOS"].ToString().ToUpper(),
                            Correo = reader["CORREO"].ToString(),
                            Telefono = (decimal)reader["TELEFONO"],
                            Direccion = reader["DIRECCION"].ToString().ToUpper(),
                            Genero = reader["GENERO"].ToString().ToUpper(),
                            Fecha = (DateTime)reader["FECHA_REGISTRO"],
                            Estado = reader["ESTADO"].ToString().ToUpper(),
                        };
                        //Añade el objeto a la lista
                        clientes.Add(cliente);
                    }
                }
                //Cierra la conexión
                db_connection.CloseConnection();
            }
            catch
            {
                throw new DBErrorException();
            }
            return clientes;
        }
        /// <summary>
        /// Obtiene los registros de la tabla cliente en orden
        /// <list type="bullet">
        /// <item>Id</item>
        /// <item>Nombres + Apellidos</item>
        /// <item>Teléfono</item>
        /// <item>Correo</item>
        /// <item>Fecha</item>
        /// </list>
        /// </summary>
        /// <returns></returns>
        public DataTable Consulta_Cliente() => GetData("GET_CLIENTES");

        /// <summary>
        /// Obtiene los registros de la tabla cliente en orden:
        /// <list type="bullet">
        /// <item>Id</item>
        /// <item>Cédula</item>
        /// <item>Nombres + Apellidos</item>
        /// <item>Correo</item>
        /// <item>Género</item>
        /// <item>Fecha</item>
        /// <item>Estado</item>
        /// </list>
        /// </summary>
        /// <returns></returns>
        public DataTable Clientes() => GetData("CLIENTES");
        #endregion
        #region Modulo Reembolso
        public DataTable Consulta_Reembolos() => GetData("CONSULTAR_REEMBOLSOS");
        //Devuelve los registros obtenidos de la Tabla Reembolso para luego poder mapearlos con linq
        public List<Reembolso> DevolverListaReembolsos()
        {
            List<Reembolso> reembolsos = new List<Reembolso>();
            SqlCommand comando = new SqlCommand()
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "SELECT * FROM REEMBOLSO",
                CommandType = CommandType.Text
            };

            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Reembolso reembolso = new Reembolso
                    {
                        Id = (int)reader["ID_REEMBOLSO"],
                        IdFactura = (int)reader["ID_FACTURA"],
                        IdServicio = (int)reader["ID_SERVICIO"],
                        Motivo = reader["MOTIVO_REEMBOLSO"].ToString(),
                        Fecha = (DateTime)reader["FECHA"],
                    };
                    reembolsos.Add(reembolso);
                }
            }

            db_connection.CloseConnection();
            return reembolsos;
        }

        #endregion

        //Ediciones
        #region Modulo Factura
        /// <summary>
        /// Actualiza el registro existente de una Factura, a partir de ciertos datos que le llegan como atributos
        /// </summary>
        /// <param name="f"></param>
        public void CD_ActualizarFactura(Factura f)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_FACTURA",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@idFact", f.Id);
            sqlComando.Parameters.AddWithValue("@descripcionServ", f.Descripcion);
            sqlComando.Parameters.AddWithValue("@cantidad", f.Cantidad);
            sqlComando.Parameters.AddWithValue("@valorUnitario", f.ValorUnitario);
            sqlComando.Parameters.AddWithValue("@nombreEncargado", f.Encargado);
            sqlComando.Parameters.AddWithValue("@fecha", f.Fecha);
            sqlComando.Parameters.AddWithValue("@total", f.Total);

            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Pago
        /// <summary>
        /// Actualiza el registro existente de un Pago, a partir de ciertos datos que le llegan como atributos
        /// </summary>
        /// <param name="p"></param>
        public void CD_ActualizarPago(Pago p)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_PAGO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@ID_PAGO", p.Id);
            sqlComando.Parameters.AddWithValue("@FECHA", p.Fecha);
            sqlComando.Parameters.AddWithValue("@METODO_PAGO", p.MetodoPago);
            sqlComando.Parameters.AddWithValue("@VALOR", p.Valor);
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        //Actualiza el registro existente de un Cliente
        /// <summary>
        /// Actualiza el registro existente de un Cliente, a partir de ciertos datos que le llegan como atributos
        /// </summary>
        /// <param name="c"></param>
        public void CD_ActualizarCliente(Cliente c)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_CLIENTE",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@NOMBRES", c.Nombres);
            sqlComando.Parameters.AddWithValue("@APELLIDOS", c.Apellidos);
            sqlComando.Parameters.AddWithValue("@CEDULA", c.Cedula);
            sqlComando.Parameters.AddWithValue("@CORREO", c.Correo);
            sqlComando.Parameters.AddWithValue("@DIRECCION", c.Direccion);
            sqlComando.Parameters.AddWithValue("@TELEFONO", c.Telefono);
            sqlComando.Parameters.AddWithValue("@GENERO", c.Genero);
            sqlComando.Parameters.AddWithValue("@FECHA_REGISTRO", c.Fecha);
            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Reembolso
        //Actualiza el registro existente de un Cliente
        /// <summary>
        /// Actualiza el registro existente de un Cliente, a partir de ciertos datos que le llegan como atributos
        /// </summary>
        /// <param name="r">Objeto con datos de tipo Reembolso</param>
        public void CD_ActualizarReembolso(Reembolso r)
        {
            SqlCommand sqlComando = new SqlCommand
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ACTUALIZAR_REEMBOLSO",
                CommandType = CommandType.StoredProcedure
            };

            sqlComando.Parameters.AddWithValue("@codigoReembolso", r.Id);
            sqlComando.Parameters.AddWithValue("@Motivo", r.Motivo);

            string resultado = Convert.ToString(sqlComando.ExecuteScalar().ToString());
            // Verificar si el resultado contiene algún mensaje de error y mostrarlo en un MessageBox si es necesario
            MessageBox.Show(resultado, "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion

        //Eliminaciones
        #region Modulo Factura
        #endregion
        #region Modulo Pago
        /// <summary>
        /// Elimina un Pago que ha registrado un Cliente, si se elimina el cliente relacionado al pago, se eliminarán todos los pagos relacionados al cliente
        /// </summary>
        /// <param name="id"></param>
        public void CD_EliminarPago(int id)
        {
            SqlCommand comando = new SqlCommand()
            {
                Connection = db_connection.OpenConnection(),
                CommandText = "ELIMINAR_PAGO",
                CommandType = CommandType.StoredProcedure
            };

            comando.Parameters.AddWithValue("@ID_PAGO", id);
            comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

            MessageBox.Show("Pago Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db_connection.CloseConnection();
        }
        #endregion
        #region Modulo Cliente
        /// <summary>
        /// Método que elimina un registro de un cliente, así como todas las facturas y pagos relacionados a ese cliente.
        /// </summary>
        /// <param name="codigo_cliente">Recibe como parámetro la cédula</param>
        /// <exception cref="DBErrorException">Excepción que aparece si no se puede conectar con la Base de Datos</exception>
        public void CD_EliminarCliente(int codigo_cliente)
        {
            try
            {
                //Estableciendo la conexión
                SqlCommand comando = new SqlCommand
                {
                    Connection = db_connection.OpenConnection(),
                    CommandText = "ELIMINAR_CLIENTE",
                    CommandType = CommandType.StoredProcedure
                };
                //Envía la cédula como parámetro al Stored Procedure de nombre "ELIMINAR_CLIENTE"
                comando.Parameters.AddWithValue("@ID_CLIENTE", codigo_cliente);
                comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

                MessageBox.Show("Cliente Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cierra la conexión
                db_connection.CloseConnection();
            }
            catch
            {
                throw new DBErrorException();
            }
        }
        #endregion
        #region Modulo Reembolso
        /// <summary>
        /// Este método elimina un reembolso registrado a partir de su ID 
        /// </summary>
        /// <param name="codigo_reembolso">El código/ID del reembolso</param>
        /// <exception cref="DBErrorException">Excepción que aparece si no se puede conectar con la Base de Datos</exception>
        public void CD_EliminarReembolso(int codigo_reembolso)
        {
            try
            {
                //Estableciendo la conexión
                SqlCommand comando = new SqlCommand
                {
                    Connection = db_connection.OpenConnection(),
                    CommandText = "ELIMINAR_REEMBOLSO",
                    CommandType = CommandType.StoredProcedure
                };
                //Envía la cédula como parámetro al Stored Procedure de nombre "ELIMINAR_CLIENTE"
                comando.Parameters.AddWithValue("@codigoReembolso",codigo_reembolso);
                comando.ExecuteNonQuery(); // Ejecutar la consulta de actualización

                MessageBox.Show("Reembolso Eliminado", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cierra la conexión
                db_connection.CloseConnection();
            }
            catch
            {
                throw new DBErrorException();
            }
        }
        #endregion
    }
}
