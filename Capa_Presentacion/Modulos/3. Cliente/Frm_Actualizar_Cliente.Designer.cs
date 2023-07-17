namespace Capa_Presentacion.Modulos._3._Cliente
{
    partial class Frm_Actualizar_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Actualizar_Cliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.btn_ActCliente = new Capa_Presentacion.user_controls.RJButton();
            this.txt_Codigo_Cliente = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.Fondo_OPC_Elegida;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código de Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(615, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(583, 45);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 20;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click_1);
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(27, 194);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(43, 15);
            this.lbl_Cedula.TabIndex = 27;
            this.lbl_Cedula.Text = "Cédula";
            this.lbl_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(26, 250);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(59, 15);
            this.lbl_Apellidos.TabIndex = 29;
            this.lbl_Apellidos.Text = "Apellidos:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(27, 306);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(58, 15);
            this.lbl_Nombres.TabIndex = 31;
            this.lbl_Nombres.Text = "Nombres:";
            this.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Género:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Genero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Genero.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Items.AddRange(new object[] {
            "Seleccionar...",
            "Masculino",
            "Femenino",
            "Prefiero no decirlo"});
            this.cmb_Genero.Location = new System.Drawing.Point(137, 357);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(180, 21);
            this.cmb_Genero.TabIndex = 40;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(355, 199);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(45, 15);
            this.lbl_Correo.TabIndex = 41;
            this.lbl_Correo.Text = "Correo:";
            this.lbl_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(355, 257);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(58, 15);
            this.lbl_Direccion.TabIndex = 43;
            this.lbl_Direccion.Text = "Dirección:";
            this.lbl_Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(355, 307);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(56, 15);
            this.lbl_Telefono.TabIndex = 45;
            this.lbl_Telefono.Text = "Teléfono:";
            this.lbl_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ActCliente
            // 
            this.btn_ActCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ActCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ActCliente.BorderRadius = 5;
            this.btn_ActCliente.BorderSize = 0;
            this.btn_ActCliente.FlatAppearance.BorderSize = 0;
            this.btn_ActCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActCliente.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActCliente.ForeColor = System.Drawing.Color.White;
            this.btn_ActCliente.Location = new System.Drawing.Point(358, 346);
            this.btn_ActCliente.Name = "btn_ActCliente";
            this.btn_ActCliente.Size = new System.Drawing.Size(260, 40);
            this.btn_ActCliente.TabIndex = 47;
            this.btn_ActCliente.Text = "Actualizar";
            this.btn_ActCliente.UseVisualStyleBackColor = false;
            this.btn_ActCliente.Click += new System.EventHandler(this.btnActCliente);
            // 
            // txt_Codigo_Cliente
            // 
            this.txt_Codigo_Cliente.BackColor = System.Drawing.Color.White;
            this.txt_Codigo_Cliente.BorderColor = System.Drawing.Color.Silver;
            this.txt_Codigo_Cliente.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Codigo_Cliente.BorderRadius = 0;
            this.txt_Codigo_Cliente.BorderSize = 2;
            this.txt_Codigo_Cliente.Enabled = false;
            this.txt_Codigo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Codigo_Cliente.Location = new System.Drawing.Point(137, 129);
            this.txt_Codigo_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Cliente.Multiline = false;
            this.txt_Codigo_Cliente.Name = "txt_Codigo_Cliente";
            this.txt_Codigo_Cliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Codigo_Cliente.PasswordChar = false;
            this.txt_Codigo_Cliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo_Cliente.PlaceholderText = "";
            this.txt_Codigo_Cliente.Size = new System.Drawing.Size(180, 31);
            this.txt_Codigo_Cliente.TabIndex = 26;
            this.txt_Codigo_Cliente.Texts = "----";
            this.txt_Codigo_Cliente.UnderlinedStyle = true;
            this.txt_Codigo_Cliente.Load += new System.EventHandler(this.txt_Codigo_Cliente_Load);
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.BackColor = System.Drawing.Color.White;
            this.txt_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(137, 194);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(180, 14);
            this.txt_Cedula.TabIndex = 48;
            this.txt_Cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BackColor = System.Drawing.Color.White;
            this.txt_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(137, 250);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(180, 14);
            this.txt_Apellidos.TabIndex = 49;
            this.txt_Apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.BackColor = System.Drawing.Color.White;
            this.txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombres.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.Location = new System.Drawing.Point(137, 306);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(180, 14);
            this.txt_Nombres.TabIndex = 50;
            this.txt_Nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.White;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(417, 199);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(180, 14);
            this.txt_Correo.TabIndex = 51;
            this.txt_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.White;
            this.txt_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(417, 258);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(180, 14);
            this.txt_Direccion.TabIndex = 52;
            this.txt_Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.White;
            this.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(417, 307);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(180, 14);
            this.txt_Telefono.TabIndex = 53;
            this.txt_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Actualizar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 461);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.btn_ActCliente);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Cedula);
            this.Controls.Add(this.txt_Codigo_Cliente);
            this.Controls.Add(this.btn_CloseForm);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Actualizar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Actualizar_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private System.Windows.Forms.Label lbl_Cedula;
        private user_controls.TextBox_Control txt_Codigo_Cliente;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Genero;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private user_controls.RJButton btn_ActCliente;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
    }
}