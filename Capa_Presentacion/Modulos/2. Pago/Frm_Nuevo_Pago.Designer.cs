namespace Capa_Presentacion.Modulos._2._Pago
{
    partial class Frm_Nuevo_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nuevo_Pago));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Valor_Pago = new System.Windows.Forms.Label();
            this.lbl_Metodo_Pago = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txt_Fecha_Pago = new System.Windows.Forms.Label();
            this.radioVisa = new System.Windows.Forms.RadioButton();
            this.radioDinners = new System.Windows.Forms.RadioButton();
            this.radioMaster = new System.Windows.Forms.RadioButton();
            this.radioAmerican = new System.Windows.Forms.RadioButton();
            this.pcb_Tarjetas_Bg = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCloseNuevoPago = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_Valor_Pago = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new Capa_Presentacion.user_controls.TextBox_Control();
            this.btn_Limpiar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Nuevo_Pago = new Capa_Presentacion.user_controls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Tarjetas_Bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseNuevoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Pago";
            // 
            // lbl_Valor_Pago
            // 
            this.lbl_Valor_Pago.AutoSize = true;
            this.lbl_Valor_Pago.BackColor = System.Drawing.Color.White;
            this.lbl_Valor_Pago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_Pago.Location = new System.Drawing.Point(64, 288);
            this.lbl_Valor_Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Valor_Pago.Name = "lbl_Valor_Pago";
            this.lbl_Valor_Pago.Size = new System.Drawing.Size(144, 26);
            this.lbl_Valor_Pago.TabIndex = 8;
            this.lbl_Valor_Pago.Text = "Valor a pagar:";
            // 
            // lbl_Metodo_Pago
            // 
            this.lbl_Metodo_Pago.AutoSize = true;
            this.lbl_Metodo_Pago.BackColor = System.Drawing.Color.White;
            this.lbl_Metodo_Pago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Metodo_Pago.Location = new System.Drawing.Point(64, 351);
            this.lbl_Metodo_Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Metodo_Pago.Name = "lbl_Metodo_Pago";
            this.lbl_Metodo_Pago.Size = new System.Drawing.Size(168, 26);
            this.lbl_Metodo_Pago.TabIndex = 9;
            this.lbl_Metodo_Pago.Text = "Metodo de Pago";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.BackColor = System.Drawing.Color.White;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(64, 225);
            this.lbl_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(78, 26);
            this.lbl_Cliente.TabIndex = 10;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Seleccionar...",
            "Credito",
            "Debito",
            "Efectivo"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(286, 348);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(241, 38);
            this.cmbMetodoPago.TabIndex = 14;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // txt_Fecha_Pago
            // 
            this.txt_Fecha_Pago.AutoSize = true;
            this.txt_Fecha_Pago.Location = new System.Drawing.Point(1005, 194);
            this.txt_Fecha_Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Fecha_Pago.Name = "txt_Fecha_Pago";
            this.txt_Fecha_Pago.Size = new System.Drawing.Size(99, 20);
            this.txt_Fecha_Pago.TabIndex = 15;
            this.txt_Fecha_Pago.Text = "------------------";
            // 
            // radioVisa
            // 
            this.radioVisa.AutoSize = true;
            this.radioVisa.Location = new System.Drawing.Point(363, 468);
            this.radioVisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioVisa.Name = "radioVisa";
            this.radioVisa.Size = new System.Drawing.Size(21, 20);
            this.radioVisa.TabIndex = 20;
            this.radioVisa.TabStop = true;
            this.radioVisa.UseVisualStyleBackColor = true;
            // 
            // radioDinners
            // 
            this.radioDinners.AutoSize = true;
            this.radioDinners.Location = new System.Drawing.Point(764, 468);
            this.radioDinners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioDinners.Name = "radioDinners";
            this.radioDinners.Size = new System.Drawing.Size(21, 20);
            this.radioDinners.TabIndex = 21;
            this.radioDinners.TabStop = true;
            this.radioDinners.UseVisualStyleBackColor = true;
            // 
            // radioMaster
            // 
            this.radioMaster.AutoSize = true;
            this.radioMaster.Location = new System.Drawing.Point(363, 582);
            this.radioMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioMaster.Name = "radioMaster";
            this.radioMaster.Size = new System.Drawing.Size(21, 20);
            this.radioMaster.TabIndex = 22;
            this.radioMaster.TabStop = true;
            this.radioMaster.UseVisualStyleBackColor = true;
            // 
            // radioAmerican
            // 
            this.radioAmerican.AutoSize = true;
            this.radioAmerican.Location = new System.Drawing.Point(764, 582);
            this.radioAmerican.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioAmerican.Name = "radioAmerican";
            this.radioAmerican.Size = new System.Drawing.Size(21, 20);
            this.radioAmerican.TabIndex = 23;
            this.radioAmerican.TabStop = true;
            this.radioAmerican.UseVisualStyleBackColor = true;
            // 
            // pcb_Tarjetas_Bg
            // 
            this.pcb_Tarjetas_Bg.BackColor = System.Drawing.Color.White;
            this.pcb_Tarjetas_Bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_Tarjetas_Bg.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Tarjetas_Bg.Image")));
            this.pcb_Tarjetas_Bg.Location = new System.Drawing.Point(326, 432);
            this.pcb_Tarjetas_Bg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcb_Tarjetas_Bg.Name = "pcb_Tarjetas_Bg";
            this.pcb_Tarjetas_Bg.Size = new System.Drawing.Size(648, 207);
            this.pcb_Tarjetas_Bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Tarjetas_Bg.TabIndex = 19;
            this.pcb_Tarjetas_Bg.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pictureBox4.Location = new System.Drawing.Point(32, 160);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1287, 518);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnCloseNuevoPago
            // 
            this.btnCloseNuevoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(5)))));
            this.btnCloseNuevoPago.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btnCloseNuevoPago.Location = new System.Drawing.Point(1227, 48);
            this.btnCloseNuevoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseNuevoPago.Name = "btnCloseNuevoPago";
            this.btnCloseNuevoPago.Size = new System.Drawing.Size(57, 65);
            this.btnCloseNuevoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseNuevoPago.TabIndex = 2;
            this.btnCloseNuevoPago.TabStop = false;
            this.btnCloseNuevoPago.Click += new System.EventHandler(this.btnCloseNuevoPago_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1287, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(18, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1314, 686);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // txt_Valor_Pago
            // 
            this.txt_Valor_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt_Valor_Pago.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor_Pago.Location = new System.Drawing.Point(286, 278);
            this.txt_Valor_Pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Valor_Pago.Name = "txt_Valor_Pago";
            this.txt_Valor_Pago.Size = new System.Drawing.Size(241, 38);
            this.txt_Valor_Pago.TabIndex = 16;
            this.txt_Valor_Pago.Text = "0,00";
            this.txt_Valor_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Valor_Pago.TextChanged += new System.EventHandler(this.txt_Valor_Pago_TextChanged);
            this.txt_Valor_Pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImportePago_KeyPress);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cliente.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_Cliente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Cliente.BorderRadius = 0;
            this.txt_Cliente.BorderSize = 2;
            this.txt_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cliente.Location = new System.Drawing.Point(286, 214);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Cliente.Multiline = false;
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txt_Cliente.PasswordChar = false;
            this.txt_Cliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Cliente.PlaceholderText = "Cédula o ID";
            this.txt_Cliente.Size = new System.Drawing.Size(243, 47);
            this.txt_Cliente.TabIndex = 24;
            this.txt_Cliente.TextBox1_Changed = null;
            this.txt_Cliente.Texts = "";
            this.txt_Cliente.UnderlinedStyle = true;
            this.txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cliente_KeyPress);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Gray;
            this.btn_Limpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Limpiar.BorderRadius = 5;
            this.btn_Limpiar.BorderSize = 0;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(1041, 322);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(225, 62);
            this.btn_Limpiar.TabIndex = 18;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Nuevo_Pago
            // 
            this.btn_Nuevo_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_Nuevo_Pago.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Nuevo_Pago.BorderRadius = 5;
            this.btn_Nuevo_Pago.BorderSize = 0;
            this.btn_Nuevo_Pago.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo_Pago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo_Pago.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo_Pago.Location = new System.Drawing.Point(1041, 251);
            this.btn_Nuevo_Pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Nuevo_Pago.Name = "btn_Nuevo_Pago";
            this.btn_Nuevo_Pago.Size = new System.Drawing.Size(225, 62);
            this.btn_Nuevo_Pago.TabIndex = 17;
            this.btn_Nuevo_Pago.Text = "REGISTRAR";
            this.btn_Nuevo_Pago.UseVisualStyleBackColor = false;
            this.btn_Nuevo_Pago.Click += new System.EventHandler(this.btn_Nuevo_Pago_Click);
            // 
            // Frm_Nuevo_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 715);
            this.Controls.Add(this.radioAmerican);
            this.Controls.Add(this.radioMaster);
            this.Controls.Add(this.radioDinners);
            this.Controls.Add(this.radioVisa);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.pcb_Tarjetas_Bg);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Nuevo_Pago);
            this.Controls.Add(this.txt_Valor_Pago);
            this.Controls.Add(this.txt_Fecha_Pago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.lbl_Metodo_Pago);
            this.Controls.Add(this.lbl_Valor_Pago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCloseNuevoPago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Nuevo_Pago";
            this.Text = "Frm_Nuevo_Pago";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Tarjetas_Bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseNuevoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCloseNuevoPago;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Valor_Pago;
        private System.Windows.Forms.Label lbl_Metodo_Pago;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label txt_Fecha_Pago;
        private user_controls.RJButton btn_Nuevo_Pago;
        private user_controls.RJButton btn_Limpiar;
        private System.Windows.Forms.PictureBox pcb_Tarjetas_Bg;
        private System.Windows.Forms.RadioButton radioVisa;
        private System.Windows.Forms.RadioButton radioDinners;
        private System.Windows.Forms.RadioButton radioMaster;
        private System.Windows.Forms.RadioButton radioAmerican;
        private System.Windows.Forms.TextBox txt_Valor_Pago;
        private user_controls.TextBox_Control txt_Cliente;
    }
}