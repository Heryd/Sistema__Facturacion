namespace Capa_Presentacion.Modulos._4._Reembolso
{
    partial class Frm_Nuevo_Reembolso
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
            this.txt_Nombres_Cliente = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.Label();
            this.lbl_Motivo = new System.Windows.Forms.Label();
            this.lbl_Separator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Metodo_Pago = new System.Windows.Forms.ComboBox();
            this.txt_Motivo_Reembolso = new System.Windows.Forms.RichTextBox();
            this.txt_Fecha_Emision = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Codigo_Factura = new Capa_Presentacion.user_controls.TextBox_Control();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.txt_Codigo_Reembolso = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_Monto_Pago = new Capa_Presentacion.user_controls.TextBox_Control();
            this.btn_Limpiar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Registrar = new Capa_Presentacion.user_controls.RJButton();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.pn_Container_border.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pn_Container_border.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Nombres_Cliente);
            this.panel1.Controls.Add(this.txt_Cedula);
            this.panel1.Controls.Add(this.lbl_Motivo);
            this.panel1.Controls.Add(this.lbl_Separator);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_Metodo_Pago);
            this.panel1.Controls.Add(this.txt_Motivo_Reembolso);
            this.panel1.Controls.Add(this.txt_Fecha_Emision);
            this.panel1.Controls.Add(this.txt_Codigo_Factura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_Estado);
            this.panel1.Controls.Add(this.txt_Codigo_Reembolso);
            this.panel1.Controls.Add(this.txt_Monto_Pago);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.lbl_Nombres);
            this.panel1.Controls.Add(this.lbl_Apellidos);
            this.panel1.Controls.Add(this.lbl_Cedula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 360);
            this.panel1.TabIndex = 14;
            // 
            // txt_Nombres_Cliente
            // 
            this.txt_Nombres_Cliente.AutoSize = true;
            this.txt_Nombres_Cliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombres_Cliente.Location = new System.Drawing.Point(590, 63);
            this.txt_Nombres_Cliente.Name = "txt_Nombres_Cliente";
            this.txt_Nombres_Cliente.Size = new System.Drawing.Size(42, 16);
            this.txt_Nombres_Cliente.TabIndex = 49;
            this.txt_Nombres_Cliente.Text = "-------";
            this.txt_Nombres_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.AutoSize = true;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cedula.Location = new System.Drawing.Point(489, 63);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(67, 16);
            this.txt_Cedula.TabIndex = 48;
            this.txt_Cedula.Text = "0000000000";
            this.txt_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Motivo
            // 
            this.lbl_Motivo.AutoSize = true;
            this.lbl_Motivo.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Motivo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Motivo.Location = new System.Drawing.Point(19, 209);
            this.lbl_Motivo.Name = "lbl_Motivo";
            this.lbl_Motivo.Size = new System.Drawing.Size(128, 15);
            this.lbl_Motivo.TabIndex = 47;
            this.lbl_Motivo.Text = "Motivo del Reembolso:";
            this.lbl_Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Separator
            // 
            this.lbl_Separator.AutoSize = true;
            this.lbl_Separator.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Separator.Location = new System.Drawing.Point(570, 63);
            this.lbl_Separator.Name = "lbl_Separator";
            this.lbl_Separator.Size = new System.Drawing.Size(12, 16);
            this.lbl_Separator.TabIndex = 46;
            this.lbl_Separator.Text = "-";
            this.lbl_Separator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Método de Pago:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Metodo_Pago
            // 
            this.cmb_Metodo_Pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Metodo_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Metodo_Pago.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Metodo_Pago.Enabled = false;
            this.cmb_Metodo_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Metodo_Pago.FormattingEnabled = true;
            this.cmb_Metodo_Pago.Items.AddRange(new object[] {
            "Seleccionar...",
            "Pagado",
            "Reembolsado",
            "Pendiente"});
            this.cmb_Metodo_Pago.Location = new System.Drawing.Point(492, 159);
            this.cmb_Metodo_Pago.Name = "cmb_Metodo_Pago";
            this.cmb_Metodo_Pago.Size = new System.Drawing.Size(180, 21);
            this.cmb_Metodo_Pago.TabIndex = 44;
            // 
            // txt_Motivo_Reembolso
            // 
            this.txt_Motivo_Reembolso.Location = new System.Drawing.Point(22, 227);
            this.txt_Motivo_Reembolso.Name = "txt_Motivo_Reembolso";
            this.txt_Motivo_Reembolso.Size = new System.Drawing.Size(863, 90);
            this.txt_Motivo_Reembolso.TabIndex = 42;
            this.txt_Motivo_Reembolso.Text = "";
            // 
            // txt_Fecha_Emision
            // 
            this.txt_Fecha_Emision.BackColor = System.Drawing.Color.White;
            this.txt_Fecha_Emision.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fecha_Emision.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Fecha_Emision.BorderRadius = 0;
            this.txt_Fecha_Emision.BorderSize = 2;
            this.txt_Fecha_Emision.Enabled = false;
            this.txt_Fecha_Emision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha_Emision.ForeColor = System.Drawing.Color.Goldenrod;
            this.txt_Fecha_Emision.Location = new System.Drawing.Point(158, 108);
            this.txt_Fecha_Emision.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fecha_Emision.Multiline = false;
            this.txt_Fecha_Emision.Name = "txt_Fecha_Emision";
            this.txt_Fecha_Emision.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Fecha_Emision.PasswordChar = false;
            this.txt_Fecha_Emision.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Fecha_Emision.PlaceholderText = "";
            this.txt_Fecha_Emision.Size = new System.Drawing.Size(202, 31);
            this.txt_Fecha_Emision.TabIndex = 41;
            this.txt_Fecha_Emision.Texts = "";
            this.txt_Fecha_Emision.UnderlinedStyle = true;
            // 
            // txt_Codigo_Factura
            // 
            this.txt_Codigo_Factura.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Codigo_Factura.BorderColor = System.Drawing.Color.PowderBlue;
            this.txt_Codigo_Factura.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Codigo_Factura.BorderRadius = 0;
            this.txt_Codigo_Factura.BorderSize = 2;
            this.txt_Codigo_Factura.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Codigo_Factura.Location = new System.Drawing.Point(158, 56);
            this.txt_Codigo_Factura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Factura.Multiline = false;
            this.txt_Codigo_Factura.Name = "txt_Codigo_Factura";
            this.txt_Codigo_Factura.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Codigo_Factura.PasswordChar = false;
            this.txt_Codigo_Factura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo_Factura.PlaceholderText = "Ingrese el código de su factura";
            this.txt_Codigo_Factura.Size = new System.Drawing.Size(202, 31);
            this.txt_Codigo_Factura.TabIndex = 40;
            this.txt_Codigo_Factura.Texts = "";
            this.txt_Codigo_Factura.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Código de Factura:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Estado.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Seleccionar...",
            "Pagado",
            "Reembolsado",
            "Pendiente"});
            this.cmb_Estado.Location = new System.Drawing.Point(158, 159);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(202, 21);
            this.cmb_Estado.TabIndex = 37;
            // 
            // txt_Codigo_Reembolso
            // 
            this.txt_Codigo_Reembolso.BackColor = System.Drawing.Color.White;
            this.txt_Codigo_Reembolso.BorderColor = System.Drawing.Color.Silver;
            this.txt_Codigo_Reembolso.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Codigo_Reembolso.BorderRadius = 0;
            this.txt_Codigo_Reembolso.BorderSize = 2;
            this.txt_Codigo_Reembolso.Enabled = false;
            this.txt_Codigo_Reembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Reembolso.ForeColor = System.Drawing.Color.Goldenrod;
            this.txt_Codigo_Reembolso.Location = new System.Drawing.Point(158, 4);
            this.txt_Codigo_Reembolso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo_Reembolso.Multiline = false;
            this.txt_Codigo_Reembolso.Name = "txt_Codigo_Reembolso";
            this.txt_Codigo_Reembolso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Codigo_Reembolso.PasswordChar = false;
            this.txt_Codigo_Reembolso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo_Reembolso.PlaceholderText = "";
            this.txt_Codigo_Reembolso.Size = new System.Drawing.Size(202, 31);
            this.txt_Codigo_Reembolso.TabIndex = 25;
            this.txt_Codigo_Reembolso.Texts = "";
            this.txt_Codigo_Reembolso.UnderlinedStyle = true;
            // 
            // txt_Monto_Pago
            // 
            this.txt_Monto_Pago.BackColor = System.Drawing.Color.White;
            this.txt_Monto_Pago.BorderColor = System.Drawing.Color.Silver;
            this.txt_Monto_Pago.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Monto_Pago.BorderRadius = 0;
            this.txt_Monto_Pago.BorderSize = 2;
            this.txt_Monto_Pago.Enabled = false;
            this.txt_Monto_Pago.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto_Pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Monto_Pago.Location = new System.Drawing.Point(492, 108);
            this.txt_Monto_Pago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Monto_Pago.Multiline = false;
            this.txt_Monto_Pago.Name = "txt_Monto_Pago";
            this.txt_Monto_Pago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Monto_Pago.PasswordChar = false;
            this.txt_Monto_Pago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Monto_Pago.PlaceholderText = "";
            this.txt_Monto_Pago.Size = new System.Drawing.Size(180, 31);
            this.txt_Monto_Pago.TabIndex = 23;
            this.txt_Monto_Pago.Texts = "";
            this.txt_Monto_Pago.UnderlinedStyle = true;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(457, 323);
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
            this.btn_Registrar.Location = new System.Drawing.Point(327, 323);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(124, 31);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(388, 116);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(46, 15);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Monto:";
            this.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(388, 64);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(46, 15);
            this.lbl_Apellidos.TabIndex = 3;
            this.lbl_Apellidos.Text = "Cliente:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(13, 116);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(100, 15);
            this.lbl_Cedula.TabIndex = 2;
            this.lbl_Cedula.Text = "Fecha de emisión:";
            this.lbl_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Reembolso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_TOP.Text = "      NUEVO REEMBOLSO";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Nuevo_Reembolso
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
            this.Name = "Frm_Nuevo_Reembolso";
            this.Text = "Frm_Nuevo_Reembolso";
            this.pn_Container_border.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container_border;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private user_controls.TextBox_Control txt_Codigo_Reembolso;
        private user_controls.TextBox_Control txt_Monto_Pago;
        private user_controls.RJButton btn_Limpiar;
        private user_controls.RJButton btn_Registrar;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private user_controls.TextBox_Control txt_Codigo_Factura;
        private System.Windows.Forms.Label label3;
        private user_controls.TextBox_Control txt_Fecha_Emision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Metodo_Pago;
        private System.Windows.Forms.RichTextBox txt_Motivo_Reembolso;
        private System.Windows.Forms.Label lbl_Separator;
        private System.Windows.Forms.Label lbl_Motivo;
        private System.Windows.Forms.Label txt_Nombres_Cliente;
        private System.Windows.Forms.Label txt_Cedula;
    }
}