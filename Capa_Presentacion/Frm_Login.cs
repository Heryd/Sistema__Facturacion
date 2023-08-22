using Capa_Negocio;
using System;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion
{
    public partial class Frm_Login : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Login()
        {
            InitializeComponent();
        }

        #region Password_Hide
        //Muestra la contraseña
        private void btn_eye_close_Click(object sender, EventArgs e)
        {
            btn_eye_close.Visible = false;
            btn_eye_open.Visible = true;
            txt_password.PasswordChar = true;
        }
        //Oculta la contraseña
        private void btn_eye_open_Click(object sender, EventArgs e)
        {
            btn_eye_close.Visible = true;
            btn_eye_open.Visible = false;
            txt_password.PasswordChar = false;
        }
        #endregion
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MinForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_user.Texts = "";
            txt_password.Texts = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Texts.Trim();
            string clave = txt_password.Texts.Trim();
            //Si se encontró al usuario y la clave de acceso fue correcta entonces permite el acceso al sistema
            if (objCapaNegocio.Set_Login(usuario, clave))
            {
                Close();
                //Envía las credenciales al menú
                Frm_Menu frm_mn = new Frm_Menu(usuario, clave);
                frm_mn.ShowDialog();
            }
        }
    }
}
