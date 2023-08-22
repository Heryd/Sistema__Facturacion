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
            this.Txt_Id_Pago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Valor_Pago = new Capa_Presentacion.user_controls.TextBox_Control();
            this.Txt_Fecha_Emision = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Search_Factura = new Capa_Presentacion.user_controls.RJButton();
            this.txt_Nombres_Cliente = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.Label();
            this.lbl_Motivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Metodo_Pago = new System.Windows.Forms.ComboBox();
            this.txt_Motivo_Reembolso = new System.Windows.Forms.RichTextBox();
            this.txt_Codigo_Factura = new Capa_Presentacion.user_controls.TextBox_Control();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Registrar = new Capa_Presentacion.user_controls.RJButton();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
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
            this.pn_Container_border.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_Container_border.Name = "pn_Container_border";
            this.pn_Container_border.Size = new System.Drawing.Size(1430, 725);
            this.pn_Container_border.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Id_Pago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Valor_Pago);
            this.panel1.Controls.Add(this.Txt_Fecha_Emision);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.lbl_Fecha);
            this.panel1.Controls.Add(this.btn_Search_Factura);
            this.panel1.Controls.Add(this.txt_Nombres_Cliente);
            this.panel1.Controls.Add(this.txt_Cedula);
            this.panel1.Controls.Add(this.lbl_Motivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_Metodo_Pago);
            this.panel1.Controls.Add(this.txt_Motivo_Reembolso);
            this.panel1.Controls.Add(this.txt_Codigo_Factura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.lbl_Nombres);
            this.panel1.Controls.Add(this.lbl_Apellidos);
            this.panel1.Controls.Add(this.lbl_Cedula);
            this.panel1.Location = new System.Drawing.Point(18, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 554);
            this.panel1.TabIndex = 14;
            // 
            // Txt_Id_Pago
            // 
            this.Txt_Id_Pago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_Id_Pago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Id_Pago.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id_Pago.Location = new System.Drawing.Point(248, 22);
            this.Txt_Id_Pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Id_Pago.Name = "Txt_Id_Pago";
            this.Txt_Id_Pago.Size = new System.Drawing.Size(302, 31);
            this.Txt_Id_Pago.TabIndex = 59;
            this.Txt_Id_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Id_Pago.TextChanged += new System.EventHandler(this.Txt_Id_Pago_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Código del Pago:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Valor_Pago
            // 
            this.Txt_Valor_Pago.BackColor = System.Drawing.Color.White;
            this.Txt_Valor_Pago.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Valor_Pago.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.Txt_Valor_Pago.BorderRadius = 0;
            this.Txt_Valor_Pago.BorderSize = 2;
            this.Txt_Valor_Pago.Enabled = false;
            this.Txt_Valor_Pago.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor_Pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Valor_Pago.Location = new System.Drawing.Point(885, 220);
            this.Txt_Valor_Pago.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Valor_Pago.Multiline = false;
            this.Txt_Valor_Pago.Name = "Txt_Valor_Pago";
            this.Txt_Valor_Pago.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.Txt_Valor_Pago.PasswordChar = false;
            this.Txt_Valor_Pago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Valor_Pago.PlaceholderText = "";
            this.Txt_Valor_Pago.Size = new System.Drawing.Size(302, 46);
            this.Txt_Valor_Pago.TabIndex = 56;
            this.Txt_Valor_Pago.TextBox1_Changed = null;
            this.Txt_Valor_Pago.Texts = "";
            this.Txt_Valor_Pago.UnderlinedStyle = true;
            // 
            // Txt_Fecha_Emision
            // 
            this.Txt_Fecha_Emision.BackColor = System.Drawing.Color.White;
            this.Txt_Fecha_Emision.BorderColor = System.Drawing.Color.Silver;
            this.Txt_Fecha_Emision.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.Txt_Fecha_Emision.BorderRadius = 0;
            this.Txt_Fecha_Emision.BorderSize = 2;
            this.Txt_Fecha_Emision.Enabled = false;
            this.Txt_Fecha_Emision.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fecha_Emision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Fecha_Emision.Location = new System.Drawing.Point(248, 162);
            this.Txt_Fecha_Emision.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Fecha_Emision.Multiline = false;
            this.Txt_Fecha_Emision.Name = "Txt_Fecha_Emision";
            this.Txt_Fecha_Emision.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.Txt_Fecha_Emision.PasswordChar = false;
            this.Txt_Fecha_Emision.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txt_Fecha_Emision.PlaceholderText = "";
            this.Txt_Fecha_Emision.Size = new System.Drawing.Size(302, 46);
            this.Txt_Fecha_Emision.TabIndex = 55;
            this.Txt_Fecha_Emision.TextBox1_Changed = null;
            this.Txt_Fecha_Emision.Texts = "";
            this.Txt_Fecha_Emision.UnderlinedStyle = true;
            // 
            // txt_fecha
            // 
            this.txt_fecha.AutoSize = true;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(880, 29);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(145, 25);
            this.txt_fecha.TabIndex = 54;
            this.txt_fecha.Text = "Esta es la Fecha";
            this.txt_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(666, 28);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(64, 23);
            this.lbl_Fecha.TabIndex = 53;
            this.lbl_Fecha.Text = "Fecha:";
            this.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Search_Factura
            // 
            this.btn_Search_Factura.BackColor = System.Drawing.Color.White;
            this.btn_Search_Factura.BackgroundImage = global::Capa_Presentacion.Properties.Resources.search_file_svgrepo_com;
            this.btn_Search_Factura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search_Factura.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Search_Factura.BorderRadius = 5;
            this.btn_Search_Factura.BorderSize = 0;
            this.btn_Search_Factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Factura.Enabled = false;
            this.btn_Search_Factura.FlatAppearance.BorderSize = 0;
            this.btn_Search_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Factura.ForeColor = System.Drawing.Color.White;
            this.btn_Search_Factura.Location = new System.Drawing.Point(566, 89);
            this.btn_Search_Factura.Name = "btn_Search_Factura";
            this.btn_Search_Factura.Size = new System.Drawing.Size(46, 46);
            this.btn_Search_Factura.TabIndex = 52;
            this.btn_Search_Factura.UseVisualStyleBackColor = false;
            this.btn_Search_Factura.Click += new System.EventHandler(this.btn_Search_Factura_Click);
            // 
            // txt_Nombres_Cliente
            // 
            this.txt_Nombres_Cliente.AutoSize = true;
            this.txt_Nombres_Cliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombres_Cliente.Location = new System.Drawing.Point(880, 112);
            this.txt_Nombres_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Nombres_Cliente.Name = "txt_Nombres_Cliente";
            this.txt_Nombres_Cliente.Size = new System.Drawing.Size(59, 23);
            this.txt_Nombres_Cliente.TabIndex = 49;
            this.txt_Nombres_Cliente.Text = "-------";
            this.txt_Nombres_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.AutoSize = true;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cedula.Location = new System.Drawing.Point(880, 82);
            this.txt_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(110, 23);
            this.txt_Cedula.TabIndex = 48;
            this.txt_Cedula.Text = "0000000000";
            this.txt_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Motivo
            // 
            this.lbl_Motivo.AutoSize = true;
            this.lbl_Motivo.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Motivo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Motivo.Location = new System.Drawing.Point(28, 285);
            this.lbl_Motivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Motivo.Name = "lbl_Motivo";
            this.lbl_Motivo.Size = new System.Drawing.Size(195, 22);
            this.lbl_Motivo.TabIndex = 47;
            this.lbl_Motivo.Text = "Motivo del Reembolso:";
            this.lbl_Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Método de Pago:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Metodo_Pago
            // 
            this.cmb_Metodo_Pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Metodo_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Metodo_Pago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_Metodo_Pago.Enabled = false;
            this.cmb_Metodo_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Metodo_Pago.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Metodo_Pago.FormattingEnabled = true;
            this.cmb_Metodo_Pago.Items.AddRange(new object[] {
            "Seleccionar...",
            "Credito",
            "Debito",
            "Efectivo"});
            this.cmb_Metodo_Pago.Location = new System.Drawing.Point(885, 152);
            this.cmb_Metodo_Pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Metodo_Pago.Name = "cmb_Metodo_Pago";
            this.cmb_Metodo_Pago.Size = new System.Drawing.Size(300, 37);
            this.cmb_Metodo_Pago.TabIndex = 44;
            // 
            // txt_Motivo_Reembolso
            // 
            this.txt_Motivo_Reembolso.DetectUrls = false;
            this.txt_Motivo_Reembolso.Enabled = false;
            this.txt_Motivo_Reembolso.Location = new System.Drawing.Point(33, 312);
            this.txt_Motivo_Reembolso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Motivo_Reembolso.Name = "txt_Motivo_Reembolso";
            this.txt_Motivo_Reembolso.Size = new System.Drawing.Size(1292, 173);
            this.txt_Motivo_Reembolso.TabIndex = 42;
            this.txt_Motivo_Reembolso.Text = "";
            this.txt_Motivo_Reembolso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Motivo_Reembolso_KeyPress);
            // 
            // txt_Codigo_Factura
            // 
            this.txt_Codigo_Factura.BackColor = System.Drawing.Color.White;
            this.txt_Codigo_Factura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Codigo_Factura.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Codigo_Factura.BorderRadius = 0;
            this.txt_Codigo_Factura.BorderSize = 2;
            this.txt_Codigo_Factura.Enabled = false;
            this.txt_Codigo_Factura.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Codigo_Factura.Location = new System.Drawing.Point(248, 89);
            this.txt_Codigo_Factura.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Codigo_Factura.Multiline = false;
            this.txt_Codigo_Factura.Name = "txt_Codigo_Factura";
            this.txt_Codigo_Factura.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txt_Codigo_Factura.PasswordChar = false;
            this.txt_Codigo_Factura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo_Factura.PlaceholderText = "Ingrese el ID de su Factura";
            this.txt_Codigo_Factura.Size = new System.Drawing.Size(302, 46);
            this.txt_Codigo_Factura.TabIndex = 40;
            this.txt_Codigo_Factura.TextBox1_Changed = null;
            this.txt_Codigo_Factura.Texts = "";
            this.txt_Codigo_Factura.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Código de Factura:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Limpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Limpiar.BorderRadius = 5;
            this.btn_Limpiar.BorderSize = 0;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(686, 497);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(639, 48);
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
            this.btn_Registrar.Enabled = false;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Location = new System.Drawing.Point(33, 497);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(645, 48);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(666, 240);
            this.lbl_Nombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(72, 23);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Monto:";
            this.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(666, 95);
            this.lbl_Apellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(74, 23);
            this.lbl_Apellidos.TabIndex = 3;
            this.lbl_Apellidos.Text = "Cliente:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(28, 175);
            this.lbl_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(161, 23);
            this.lbl_Cedula.TabIndex = 2;
            this.lbl_Cedula.Text = "Fecha de emisión:";
            this.lbl_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(1316, 54);
            this.btn_CloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(52, 54);
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
            this.lbl_TOP.Location = new System.Drawing.Point(33, 31);
            this.lbl_TOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.lbl_TOP.Size = new System.Drawing.Size(1354, 95);
            this.lbl_TOP.TabIndex = 0;
            this.lbl_TOP.Text = "      NUEVO REEMBOLSO";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Nuevo_Reembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 725);
            this.Controls.Add(this.pn_Container_border);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Nuevo_Reembolso";
            this.Text = "Frm_Nuevo_Reembolso";
            this.Load += new System.EventHandler(this.Frm_Nuevo_Reembolso_Load);
            this.pn_Container_border.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container_border;
        private System.Windows.Forms.Panel panel1;
        private user_controls.RJButton btn_Limpiar;
        private user_controls.RJButton btn_Registrar;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private user_controls.TextBox_Control txt_Codigo_Factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Metodo_Pago;
        private System.Windows.Forms.RichTextBox txt_Motivo_Reembolso;
        private System.Windows.Forms.Label lbl_Motivo;
        private System.Windows.Forms.Label txt_Nombres_Cliente;
        private System.Windows.Forms.Label txt_Cedula;
        private user_controls.RJButton btn_Search_Factura;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private user_controls.TextBox_Control Txt_Valor_Pago;
        private user_controls.TextBox_Control Txt_Fecha_Emision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Id_Pago;
    }
}