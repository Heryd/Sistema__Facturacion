namespace Capa_Presentacion
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.btn_MinForm = new System.Windows.Forms.PictureBox();
            this.btn_eye_open = new System.Windows.Forms.PictureBox();
            this.btn_eye_close = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_login = new Capa_Presentacion.user_controls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_user = new Capa_Presentacion.user_controls.TextBox_Control();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "SISTEMA DE FACTURACION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_CloseForm);
            this.panel1.Controls.Add(this.btn_MinForm);
            this.panel1.Controls.Add(this.btn_eye_open);
            this.panel1.Controls.Add(this.btn_eye_close);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 467);
            this.panel1.TabIndex = 5;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(437, 12);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 12;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // btn_MinForm
            // 
            this.btn_MinForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinForm.Image = global::Capa_Presentacion.Properties.Resources.minimizar;
            this.btn_MinForm.Location = new System.Drawing.Point(400, 11);
            this.btn_MinForm.Name = "btn_MinForm";
            this.btn_MinForm.Size = new System.Drawing.Size(37, 37);
            this.btn_MinForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MinForm.TabIndex = 11;
            this.btn_MinForm.TabStop = false;
            this.btn_MinForm.Click += new System.EventHandler(this.btn_MinForm_Click);
            // 
            // btn_eye_open
            // 
            this.btn_eye_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eye_open.Image = global::Capa_Presentacion.Properties.Resources.eye_open;
            this.btn_eye_open.Location = new System.Drawing.Point(148, 288);
            this.btn_eye_open.Name = "btn_eye_open";
            this.btn_eye_open.Size = new System.Drawing.Size(25, 25);
            this.btn_eye_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_eye_open.TabIndex = 9;
            this.btn_eye_open.TabStop = false;
            this.btn_eye_open.Click += new System.EventHandler(this.btn_eye_open_Click);
            // 
            // btn_eye_close
            // 
            this.btn_eye_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eye_close.Image = global::Capa_Presentacion.Properties.Resources.ezgif_1_144b164ee3;
            this.btn_eye_close.Location = new System.Drawing.Point(148, 288);
            this.btn_eye_close.Name = "btn_eye_close";
            this.btn_eye_close.Size = new System.Drawing.Size(25, 25);
            this.btn_eye_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_eye_close.TabIndex = 10;
            this.btn_eye_close.TabStop = false;
            this.btn_eye_close.Click += new System.EventHandler(this.btn_eye_close_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.BorderRadius = 8;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(72, 403);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(341, 31);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.Color.Orange;
            this.btn_login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_login.BorderRadius = 8;
            this.btn_login.BorderSize = 0;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(72, 372);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(341, 31);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "INICIAR SESION";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ingresa las credenciales para inciar sesión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOGIN";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txt_password.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_password.BorderFocusColor = System.Drawing.Color.Gold;
            this.txt_password.BorderRadius = 5;
            this.txt_password.BorderSize = 1;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_password.Location = new System.Drawing.Point(72, 321);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = true;
            this.txt_password.PlaceholderColor = System.Drawing.Color.Goldenrod;
            this.txt_password.PlaceholderText = "Ingresa tu contraseña";
            this.txt_password.Size = new System.Drawing.Size(341, 31);
            this.txt_password.TabIndex = 3;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = true;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txt_user.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_user.BorderFocusColor = System.Drawing.Color.Gold;
            this.txt_user.BorderRadius = 5;
            this.txt_user.BorderSize = 1;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_user.Location = new System.Drawing.Point(72, 230);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_user.PasswordChar = false;
            this.txt_user.PlaceholderColor = System.Drawing.Color.Goldenrod;
            this.txt_user.PlaceholderText = "Ingresa tu usuario/email";
            this.txt_user.Size = new System.Drawing.Size(341, 31);
            this.txt_user.TabIndex = 2;
            this.txt_user.Texts = "";
            this.txt_user.UnderlinedStyle = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 467);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eye_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private user_controls.TextBox_Control txt_user;
        private user_controls.TextBox_Control txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private user_controls.RJButton btn_cancelar;
        private user_controls.RJButton btn_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_eye_close;
        private System.Windows.Forms.PictureBox btn_eye_open;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private System.Windows.Forms.PictureBox btn_MinForm;
    }
}

