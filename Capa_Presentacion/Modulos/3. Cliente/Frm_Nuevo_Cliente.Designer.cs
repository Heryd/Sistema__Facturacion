namespace Capa_Presentacion.Modulos._3._Cliente
{
    partial class Frm_Nuevo_Cliente
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
            this.pn_Container_border = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.txt_Telefono = new Capa_Presentacion.user_controls.TextBox_Control();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txt_Direccion = new Capa_Presentacion.user_controls.TextBox_Control();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Codigo_Cliente = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Correo = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Nombres = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Apellidos = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Cedula = new Capa_Presentacion.user_controls.TextBox_Control();
            this.btn_Limpiar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Registrar = new Capa_Presentacion.user_controls.RJButton();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgV_Registro_Factura = new System.Windows.Forms.DataGridView();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.pn_Container_border.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Registro_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Container_border
            // 
            this.pn_Container_border.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Container_border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Container_border.Controls.Add(this.panel1);
            this.pn_Container_border.Controls.Add(this.btn_CloseForm);
            this.pn_Container_border.Controls.Add(this.lbl_TOP);
            this.pn_Container_border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container_border.Location = new System.Drawing.Point(0, 0);
            this.pn_Container_border.Name = "pn_Container_border";
            this.pn_Container_border.Size = new System.Drawing.Size(950, 471);
            this.pn_Container_border.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_Genero);
            this.panel1.Controls.Add(this.txt_Telefono);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.txt_Direccion);
            this.panel1.Controls.Add(this.lbl_Direccion);
            this.panel1.Controls.Add(this.txt_Codigo_Cliente);
            this.panel1.Controls.Add(this.txt_Correo);
            this.panel1.Controls.Add(this.txt_Nombres);
            this.panel1.Controls.Add(this.txt_Apellidos);
            this.panel1.Controls.Add(this.txt_Cedula);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.lbl_Fecha);
            this.panel1.Controls.Add(this.lbl_Correo);
            this.panel1.Controls.Add(this.lbl_Nombres);
            this.panel1.Controls.Add(this.lbl_Apellidos);
            this.panel1.Controls.Add(this.lbl_Cedula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgV_Registro_Factura);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 351);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 38;
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
            this.cmb_Genero.Location = new System.Drawing.Point(125, 172);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(180, 21);
            this.cmb_Genero.TabIndex = 37;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Telefono.BorderColor = System.Drawing.Color.Silver;
            this.txt_Telefono.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Telefono.BorderRadius = 0;
            this.txt_Telefono.BorderSize = 2;
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Telefono.Location = new System.Drawing.Point(125, 291);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono.Multiline = false;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Telefono.PasswordChar = false;
            this.txt_Telefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Telefono.PlaceholderText = "Ingrese los 10 dígitos";
            this.txt_Telefono.Size = new System.Drawing.Size(180, 31);
            this.txt_Telefono.TabIndex = 36;
            this.txt_Telefono.Texts = "";
            this.txt_Telefono.UnderlinedStyle = true;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(32, 299);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(56, 15);
            this.lbl_Telefono.TabIndex = 35;
            this.lbl_Telefono.Text = "Teléfono:";
            this.lbl_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Direccion.BorderColor = System.Drawing.Color.Silver;
            this.txt_Direccion.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Direccion.BorderRadius = 0;
            this.txt_Direccion.BorderSize = 2;
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Direccion.Location = new System.Drawing.Point(125, 248);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Direccion.Multiline = false;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Direccion.PasswordChar = false;
            this.txt_Direccion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Direccion.PlaceholderText = "Dirección domiciliaria";
            this.txt_Direccion.Size = new System.Drawing.Size(180, 31);
            this.txt_Direccion.TabIndex = 33;
            this.txt_Direccion.Texts = "";
            this.txt_Direccion.UnderlinedStyle = true;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(32, 256);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(58, 15);
            this.lbl_Direccion.TabIndex = 26;
            this.lbl_Direccion.Text = "Dirección:";
            this.lbl_Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txt_Codigo_Cliente.Location = new System.Drawing.Point(125, 4);
            this.txt_Codigo_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Cliente.Multiline = false;
            this.txt_Codigo_Cliente.Name = "txt_Codigo_Cliente";
            this.txt_Codigo_Cliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Codigo_Cliente.PasswordChar = false;
            this.txt_Codigo_Cliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo_Cliente.PlaceholderText = "";
            this.txt_Codigo_Cliente.Size = new System.Drawing.Size(180, 31);
            this.txt_Codigo_Cliente.TabIndex = 25;
            this.txt_Codigo_Cliente.Texts = "----";
            this.txt_Codigo_Cliente.UnderlinedStyle = true;
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Correo.BorderColor = System.Drawing.Color.Silver;
            this.txt_Correo.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Correo.BorderRadius = 0;
            this.txt_Correo.BorderSize = 2;
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Correo.Location = new System.Drawing.Point(125, 205);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Multiline = false;
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Correo.PasswordChar = false;
            this.txt_Correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Correo.PlaceholderText = "Ingrese su email";
            this.txt_Correo.Size = new System.Drawing.Size(180, 31);
            this.txt_Correo.TabIndex = 24;
            this.txt_Correo.Texts = "";
            this.txt_Correo.UnderlinedStyle = true;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nombres.BorderColor = System.Drawing.Color.Silver;
            this.txt_Nombres.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Nombres.BorderRadius = 0;
            this.txt_Nombres.BorderSize = 2;
            this.txt_Nombres.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombres.Location = new System.Drawing.Point(125, 129);
            this.txt_Nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombres.Multiline = false;
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Nombres.PasswordChar = false;
            this.txt_Nombres.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Nombres.PlaceholderText = "Ingrese sus 2 nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(180, 31);
            this.txt_Nombres.TabIndex = 23;
            this.txt_Nombres.Texts = "";
            this.txt_Nombres.UnderlinedStyle = true;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Apellidos.BorderColor = System.Drawing.Color.Silver;
            this.txt_Apellidos.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Apellidos.BorderRadius = 0;
            this.txt_Apellidos.BorderSize = 2;
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Apellidos.Location = new System.Drawing.Point(125, 86);
            this.txt_Apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Apellidos.Multiline = false;
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Apellidos.PasswordChar = false;
            this.txt_Apellidos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Apellidos.PlaceholderText = "Ingrese sus 2 apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(180, 31);
            this.txt_Apellidos.TabIndex = 22;
            this.txt_Apellidos.Texts = "";
            this.txt_Apellidos.UnderlinedStyle = true;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cedula.BorderColor = System.Drawing.Color.Silver;
            this.txt_Cedula.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Cedula.BorderRadius = 0;
            this.txt_Cedula.BorderSize = 2;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cedula.Location = new System.Drawing.Point(125, 43);
            this.txt_Cedula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cedula.Multiline = false;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Cedula.PasswordChar = false;
            this.txt_Cedula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Cedula.PlaceholderText = "Ingrese los 10 dígitos";
            this.txt_Cedula.Size = new System.Drawing.Size(180, 31);
            this.txt_Cedula.TabIndex = 21;
            this.txt_Cedula.Texts = "";
            this.txt_Cedula.UnderlinedStyle = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Limpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Limpiar.BorderRadius = 5;
            this.btn_Limpiar.BorderSize = 0;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(786, 6);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(124, 31);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_Registrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Registrar.BorderRadius = 5;
            this.btn_Registrar.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Location = new System.Drawing.Point(656, 6);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(124, 31);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            // 
            // txt_fecha
            // 
            this.txt_fecha.AutoSize = true;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(403, 9);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(87, 14);
            this.txt_fecha.TabIndex = 7;
            this.txt_fecha.Text = "Esta es la Fecha";
            this.txt_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(326, 9);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(40, 15);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha:";
            this.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(32, 213);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(45, 15);
            this.lbl_Correo.TabIndex = 5;
            this.lbl_Correo.Text = "Correo:";
            this.lbl_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(32, 137);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(58, 15);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Nombres:";
            this.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(32, 94);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(59, 15);
            this.lbl_Apellidos.TabIndex = 3;
            this.lbl_Apellidos.Text = "Apellidos:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(32, 51);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(43, 15);
            this.lbl_Cedula.TabIndex = 2;
            this.lbl_Cedula.Text = "Cédula";
            this.lbl_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgV_Registro_Factura
            // 
            this.dtgV_Registro_Factura.AllowUserToAddRows = false;
            this.dtgV_Registro_Factura.AllowUserToDeleteRows = false;
            this.dtgV_Registro_Factura.AllowUserToResizeColumns = false;
            this.dtgV_Registro_Factura.AllowUserToResizeRows = false;
            this.dtgV_Registro_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgV_Registro_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Registro_Factura.Location = new System.Drawing.Point(329, 43);
            this.dtgV_Registro_Factura.Name = "dtgV_Registro_Factura";
            this.dtgV_Registro_Factura.ReadOnly = true;
            this.dtgV_Registro_Factura.RowHeadersWidth = 62;
            this.dtgV_Registro_Factura.RowTemplate.Height = 28;
            this.dtgV_Registro_Factura.Size = new System.Drawing.Size(581, 279);
            this.dtgV_Registro_Factura.TabIndex = 0;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(877, 35);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 13;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // lbl_TOP
            // 
            this.lbl_TOP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TOP.BorderRadius = 10;
            this.lbl_TOP.BorderSize = 0;
            this.lbl_TOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TOP.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TOP.ForeColor = System.Drawing.Color.White;
            this.lbl_TOP.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(154)))));
            this.lbl_TOP.Location = new System.Drawing.Point(22, 20);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.lbl_TOP.Size = new System.Drawing.Size(903, 62);
            this.lbl_TOP.TabIndex = 0;
            this.lbl_TOP.Text = "      NUEVO CLIENTE";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 471);
            this.Controls.Add(this.pn_Container_border);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Nuevo_Cliente";
            this.Text = "Frm_Nuevo_Cliente";
            this.pn_Container_border.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Registro_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container_border;
        private System.Windows.Forms.Panel panel1;
        private user_controls.TextBox_Control txt_Direccion;
        private System.Windows.Forms.Label lbl_Direccion;
        private user_controls.TextBox_Control txt_Codigo_Cliente;
        private user_controls.TextBox_Control txt_Correo;
        private user_controls.TextBox_Control txt_Nombres;
        private user_controls.TextBox_Control txt_Apellidos;
        private user_controls.TextBox_Control txt_Cedula;
        private user_controls.RJButton btn_Limpiar;
        private user_controls.RJButton btn_Registrar;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgV_Registro_Factura;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private user_controls.TextBox_Control txt_Telefono;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Genero;
    }
}