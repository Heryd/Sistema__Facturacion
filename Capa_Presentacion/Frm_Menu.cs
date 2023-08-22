using Capa_Negocio;
using Capa_Datos.Entidades;
using Capa_Presentacion.Modulos._1._Factura;
using Capa_Presentacion.Modulos._2._Pago;
using Capa_Presentacion.Modulos._3._Cliente;
using Capa_Presentacion.Modulos._4._Reembolso;
using Capa_Presentacion.Properties;
using Capa_Presentacion.user_controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion
{
    public partial class Frm_Menu : Form
    {
        #region Fields
        //Paneles contenedores de las opciones CRUD
        private bool showPanelFactura;
        private bool showPanelPago;
        private bool showPanelCliente;
        private bool showPanelReembolso;

        //Confirmaciones de los botones del CRUD
        private bool confirm_button_Create;
        private bool confirm_button_Read;
        private bool confirm_button_Update;
        private bool confirm_button_Delete;

        private RJButton current_Button;
        private Form active_Form = null;
        private List<Form> formulariosAbiertos = new List<Form>();

        //Imagenes de las opciones de Modulo
        private Image icon_new_Register = Resources.btn_nuevo_registro_background;
        private Image icon_Records= Resources.btn_lista_entidades_background;

        CN_GetData objCapaNegocio = new CN_GetData();
        public string usuario = "", clave = "";
        private string[] array;
        private string datosUser;
        #endregion

        #region Descripción del constructor del Formulario Menú
        /// <summary>
        /// Recibe las credenciales y las asigna a unas variables
        /// </summary>
        /// <param name="user">El identificador del usuario</param>
        /// <param name="password">La clave de acceso</param> 
        #endregion
        public Frm_Menu(string user, string password)
        {
            InitializeComponent();
            hidePanels();
            Add_Icon_Background();
            usuario = user;
            clave = password;
            //Llama a un método para obtener el nombre del usuario y su rol, y lo guarda en una variable de tipo string
            datosUser=objCapaNegocio.CN_Get_User_ROL(usuario, clave);
            //Separa los valores de la cadena mediante el método split, separados por una ','
            array = datosUser.Split(',');
            //Envía los valores de cada posición del arreglo, a cada label correspondiente
            lbl_Name_User.Text = array[0];
            lbl_Rol_User.Text = array[1];
        }


        private void hidePanels()
        {
            pnDown_Factura.Height = 0;
            pnDown_Pago.Height = 0;
            pnDown_Cliente.Height = 0;
            pnDown_Reembolso.Height = 0;
        }

        #region Confirms de CRUD
        private void confirm_Create()
        {
            confirm_button_Read = false;
            confirm_button_Update = false;
            confirm_button_Delete = false;
            confirm_button_Create = !confirm_button_Create;
        }
        private void confirm_Read()
        {
            confirm_button_Create = false;
            confirm_button_Update = false;
            confirm_button_Delete = false;
            confirm_button_Read = !confirm_button_Read;
        }
        private void confirm_Update()
        {
            confirm_button_Create = false;
            confirm_button_Read = false;
            confirm_button_Delete = false;
            confirm_button_Update = !confirm_button_Update;
        }
        private void confirm_Delete()
        {
            confirm_button_Create = false;
            confirm_button_Read = false;
            confirm_button_Update = false;
            confirm_button_Delete = !confirm_button_Delete;
        }

        #endregion

        #region Asignar Colores a variables estaticas
        private struct Colores_RGB
        {
            public static Color oro = Color.FromArgb(253, 173, 21);
            public static Color gris = Color.FromArgb(191, 191, 191);
            public static Color smoke_gray = Color.FromArgb(64, 64, 64);
            public static Color mostaza = Color.FromArgb(247, 106, 10);
            public static Color gray_blue_sky = Color.FromArgb(81, 128, 179);
            public static Color blue_gray = Color.FromArgb(88, 114, 128);
        }
        #endregion

        #region Metodos Click de los botones de Modulo
        private void btn_MFactura_Click(object sender, EventArgs e)
        {
            showPanelPago = false;
            showPanelCliente = false;
            showPanelReembolso = false;

            showPanelFactura = !showPanelFactura;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }

        private void btn_MPago_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelCliente = false;
            showPanelReembolso = false;

            showPanelPago = !showPanelPago;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }

        private void btn_MCliente_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelPago = false;
            showPanelReembolso = false;

            showPanelCliente = !showPanelCliente;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }

        private void btn_MReembolso_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelPago = false;
            showPanelCliente = false;

            showPanelReembolso = !showPanelReembolso;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }
        #endregion

        #region Metodo para desplazarnos entre los crud
        private void DeslizarMenus()
        {
            if (showPanelFactura)
            {
                btn_MFactura.Image = Resources.btn_MFactura_Background_White;
                btn_MFactura.BackColor = Colores_RGB.gris;
                pnDown_Factura.Height = 125;
            }
            else
            {
                btn_MFactura.Image = Resources.btn_MFactura_Background;
                btn_MFactura.BackColor = Color.Transparent;
                pnDown_Factura.Height = 0;
            }
            if (showPanelPago)
            {
                btn_MPago.Image = Resources.Group_6;
                btn_MPago.BackColor = Colores_RGB.gris;
                pnDown_Pago.Height = 125;
            }
            else
            {
                btn_MPago.Image = Resources.Group_5;
                btn_MPago.BackColor = Color.Transparent;
                pnDown_Pago.Height = 0;
            }
            if (showPanelCliente)
            {
                btn_MCliente.Image = Resources.Group_12__1_;
                btn_MCliente.BackColor = Colores_RGB.gris;
                pnDown_Cliente.Height = 125;
            }
            else
            {
                btn_MCliente.Image = Resources.Group_10;
                btn_MCliente.BackColor = Color.Transparent;
                pnDown_Cliente.Height = 0;
            }
            if (showPanelReembolso)
            {
                btn_MReembolso.Image = Resources.Group_11__1_;
                btn_MReembolso.BackColor = Colores_RGB.gris;
                pnDown_Reembolso.Height = 125;
            }
            else
            {
                btn_MReembolso.Image = Resources.Group_11;
                btn_MReembolso.BackColor = Color.Transparent;
                pnDown_Reembolso.Height = 0;
            }
        }
        #endregion

        #region Cambia el color e icono a botones de CRUD
        private void Atenuar_Opc_Modulo(RJButton button)
        {
            Reset_Colors_Buttons();
            Paint_Colors_Buttons(button);
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            Frm_Login frm = new Frm_Login();
            frm.Show();
        }

        #region Atenua botones de CRUD para el Módulo Factura
        private void btn_Registro_Factura_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registro_Factura);
            Close_Active_Form();
            AbrirFormulario<Frm_Nueva_Factura>();
        }

        private void btn_Consulta_Factura_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Factura);
            Close_Active_Form();
            if (objCapaNegocio.CN_DevolverFactura().Any())
            {
                //Llama al formulario 
                AbrirFormulario<Frm_Facturas>();
            }
            else
            {
                MessageBox.Show("No se encontraron registros de facturas.\nRegistre una nueva factura", "Obtener Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Restaura el color e icono a su estado pasivo
        private void Reset_Colors_Buttons()
        {
            if (current_Button != null)
            {
                switch (current_Button.Name)
                {
                    case "btn_Registro_Factura":
                    case "btn_Registro_Pago":
                    case "btn_Registrar_Cliente":
                    case "btn_Registrar_Reembolso":
                        current_Button.Image = Resources.btn_nuevo_registro_background;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                    case "btn_Consultar_Factura":
                    case "btn_Consultar_Pago":
                    case "btn_Consultar_Cliente":
                    case "btn_Consultar_Reembolso":
                        current_Button.Image = Resources.btn_lista_entidades_background;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                }
            }
        }
        #endregion

        #region Se encarga de pintar el boton del CRUD
        private void Paint_Colors_Buttons(object sender)
        {
            var button = (RJButton)sender;
            switch (button.Name)
            {
                case "btn_Registro_Factura":
                case "btn_Registro_Pago":
                case "btn_Registrar_Cliente":
                case "btn_Registrar_Reembolso":
                    button.Image = Resources.btn_nuevo_registro_background_white;
                    button.BackColor = Colores_RGB.blue_gray;
                    button.ForeColor = Color.White;
                    break;
                case "btn_Consultar_Factura":
                case "btn_Consultar_Pago":
                case "btn_Consultar_Cliente":
                case "btn_Consultar_Reembolso":
                    button.Image = Resources.btn_lista_entidades_background_white__1_;
                    button.BackColor = Colores_RGB.blue_gray;
                    button.ForeColor = Color.White;
                    break;
            }
            current_Button = button;
        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Pago
        private void btn_Registro_Pago_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registro_Pago);
            Close_Active_Form();
            AbrirFormulario<Frm_Nuevo_Pago>();
        }
        private void btn_Consulta_Pago_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Pago);
            Close_Active_Form();
            if (objCapaNegocio.CN_DevolverPago().Any())
            {
                //Llama al formulario 
                AbrirFormulario<FrmPagos>();
            }
            else
            {
                MessageBox.Show("No se encontraron registros de Pagos.\nRegistre un nuevo pago", "Obtener Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Cliente
        private void btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registrar_Cliente);
            //Cierra el formulario activo en ese momento
            Close_Active_Form();
            //Llama al formulario 
            AbrirFormulario<Frm_Nuevo_Cliente>();
        }

        private void btn_Consultar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Cliente);
            //Cierra el formulario activo en ese momento
            Close_Active_Form();

            if (objCapaNegocio.CN_DevolverCliente().Any())
            {
                //Llama al formulario 
                AbrirFormulario<Frm_Clientes>();
            }
            else
            {
                MessageBox.Show("No se encontraron registros de clientes.\nRegistre un nuevo cliente", "Obtener Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Reembolso
        private void btn_Registrar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registrar_Reembolso);
            Close_Active_Form();
            AbrirFormulario<Frm_Nuevo_Reembolso>();

        }
        private void btn_Consultar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Reembolso);
            Close_Active_Form();
            //Verifica si existen registros, de lo contrario arroja un mensaje de error
            if (objCapaNegocio.CN_DevolverReembolso().Any())
            {
                //Llama al formulario 
                AbrirFormulario<Frm_Reembolsos>();
            }
            else
            {
                MessageBox.Show("No se encontraron registros de reembolsos.\nRegistre un reembolso", "Obtener Reembolsos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Minimizar_Ventana
        private void btn_Minimizar_Ventana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Llama a un formulario hijo, dentro del formulario actual (Padre)
        private void AbrirFormularioHijo(Form hijo)
        {
            //Cuando se lllama al método, si hay un formulario ejecutandose en ese momento, entonces lo cierra.
            if (active_Form != null)
            {
                active_Form.Close();
            }
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pn_Form_Hijo.Controls.Add(hijo);
            pn_Form_Hijo.Tag = hijo;
            hijo.Show();
        }
        #endregion

        //Metodo para abrir formularios dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = formulariosAbiertos.FirstOrDefault(f => f.GetType() == typeof(MiForm));

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.FormClosed += (s, args) => formulariosAbiertos.Remove(formulario);

                formulariosAbiertos.Add(formulario);
            }

            Close_Active_Form(); // Cierra el formulario actual si existe

            active_Form = formulario;

            formulario.TopLevel = false;
            pn_Form_Hijo.Controls.Add(formulario);
            pn_Form_Hijo.Tag = formulario;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            formulario.BringToFront();
        }

        #region Asignacion del Boton Home
        //Se encarga de cerrar el resto de formularios y regresa los Modulos a su tamaño/color/icono predeterminado
        private void btn_HOME_Click(object sender, EventArgs e)
        {
            //Cierra los forms
            Cerrar_Forms();
            //Regresa los modulos a su tamaño predeterminado
            Restore_Paneles_Modulos();
            //Regresa los iconos predeterminados
            DeslizarMenus();
            Reset_Colors_Buttons();
            hidePanels();
        }
        #endregion

        private void Restore_Paneles_Modulos()
        {
            if (showPanelFactura)
            {
                showPanelFactura = !showPanelFactura;
            } else if (showPanelPago)
            {
                showPanelPago = !showPanelPago;
            }
            else if (showPanelCliente)
            {
                showPanelCliente = !showPanelCliente;
            }
            else if (showPanelReembolso)
            {
                showPanelReembolso = !showPanelReembolso;
            }
        }

        //Cierra todos los formularios abiertos dentro del menu
        private void Cerrar_Forms()
        {
            Close_Active_Form(); // Cierra el formulario actual si existe
            foreach (Form formulario in formulariosAbiertos)
            {
                formulario.Close();
            }
            formulariosAbiertos.Clear();
        }
        
        //Cierra el Formulario Hijo que se encuentra Activo en ese momento
        private void Close_Active_Form()
        {
            active_Form?.Close();
        }
        
        //Añade iconos a los botones de CRUD de cada modulo
        private void Add_Icon_Background() {
            //Botones de Nuevos Registros
            btn_Registro_Factura.Image = icon_new_Register;
            btn_Registro_Pago.Image = icon_new_Register;
            btn_Registrar_Cliente.Image = icon_new_Register;
            btn_Registrar_Reembolso.Image = icon_new_Register;

            //Botones de Consulta Registros
            btn_Consultar_Factura.Image = icon_Records;
            btn_Consultar_Pago.Image = icon_Records;
            btn_Consultar_Cliente.Image = icon_Records;
            btn_Consultar_Reembolso.Image=icon_Records;
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Grupo 03 - Sistema de Facturación" +
                "\nIntegrantes:" +
                "\n- Morla Gordillo Heryd Xavier (L\u00edder)."+
                "\n- S\u00e1nchez Vargas Bryan Jonas." +
                "\n- Solorzano Terán Petter Max." +
                "\n- Valencia Quintero Angelo Jardel." +
                "\n\nCurso: SOF - S - VE - 6 -2" +
                "\nDocente: Ing. Johanna Zumba Gamboa" +
                "\n\n\n      Universidad de Guayaquil" +
                "\n\t  2023 - 2024 CI",
                "Contactos ...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
                );
        }
    }
}
