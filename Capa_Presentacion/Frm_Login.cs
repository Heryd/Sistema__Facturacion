using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_eye_close_Click(object sender, EventArgs e)
        {
            btn_eye_close.Visible = false;
            btn_eye_open.Visible = true;
            txt_password.PasswordChar = true;
        }

        private void btn_eye_open_Click(object sender, EventArgs e)
        {
            btn_eye_close.Visible = true;
            btn_eye_open.Visible = false;
            txt_password.PasswordChar = false;
        }

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
    }
}
