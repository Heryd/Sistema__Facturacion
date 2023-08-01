namespace Capa_Presentacion.Modulos._2._Pago
{
    partial class Frm_Actualizar_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Actualizar_Pago));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_Tarjetas_Bg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseActPago = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo_Cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.radioVisa = new System.Windows.Forms.RadioButton();
            this.radioDiners = new System.Windows.Forms.RadioButton();
            this.radioMaster = new System.Windows.Forms.RadioButton();
            this.radioAmerican = new System.Windows.Forms.RadioButton();
            this.txt_Valor_Pago = new System.Windows.Forms.TextBox();
            this.btnActualizarPagos = new Capa_Presentacion.user_controls.RJButton();
            this.txt_ID = new System.Windows.Forms.Label();
            this.lbl_ID_Pago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Tarjetas_Bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseActPago)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_Presentacion.Properties.Resources.Fondo_OPC_Elegida;
            this.pictureBox3.Location = new System.Drawing.Point(2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(648, 446);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_Tarjetas_Bg
            // 
            this.pcb_Tarjetas_Bg.BackColor = System.Drawing.Color.White;
            this.pcb_Tarjetas_Bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_Tarjetas_Bg.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Tarjetas_Bg.Image")));
            this.pcb_Tarjetas_Bg.Location = new System.Drawing.Point(103, 287);
            this.pcb_Tarjetas_Bg.Name = "pcb_Tarjetas_Bg";
            this.pcb_Tarjetas_Bg.Size = new System.Drawing.Size(433, 135);
            this.pcb_Tarjetas_Bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Tarjetas_Bg.TabIndex = 20;
            this.pcb_Tarjetas_Bg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseActPago
            // 
            this.btnCloseActPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(5)))));
            this.btnCloseActPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseActPago.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btnCloseActPago.Location = new System.Drawing.Point(550, 48);
            this.btnCloseActPago.Name = "btnCloseActPago";
            this.btnCloseActPago.Size = new System.Drawing.Size(38, 42);
            this.btnCloseActPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseActPago.TabIndex = 22;
            this.btnCloseActPago.TabStop = false;
            this.btnCloseActPago.Click += new System.EventHandler(this.btnCloseActPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo de Cliente:";
            // 
            // txt_Codigo_Cliente
            // 
            this.txt_Codigo_Cliente.AutoSize = true;
            this.txt_Codigo_Cliente.BackColor = System.Drawing.Color.White;
            this.txt_Codigo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Cliente.Location = new System.Drawing.Point(183, 148);
            this.txt_Codigo_Cliente.Name = "txt_Codigo_Cliente";
            this.txt_Codigo_Cliente.Size = new System.Drawing.Size(80, 16);
            this.txt_Codigo_Cliente.TabIndex = 24;
            this.txt_Codigo_Cliente.Text = "------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor del Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Metodo de Pago:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMetodoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMetodoPago.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Seleccionar...",
            "Credito",
            "Debito",
            "Efectivo"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(182, 231);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(140, 29);
            this.cmbMetodoPago.TabIndex = 28;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmb_Metodo_Pago_SelectedIndexChanged);
            // 
            // radioVisa
            // 
            this.radioVisa.AutoSize = true;
            this.radioVisa.Location = new System.Drawing.Point(131, 306);
            this.radioVisa.Name = "radioVisa";
            this.radioVisa.Size = new System.Drawing.Size(14, 13);
            this.radioVisa.TabIndex = 31;
            this.radioVisa.TabStop = true;
            this.radioVisa.UseVisualStyleBackColor = true;
            // 
            // radioDiners
            // 
            this.radioDiners.AutoSize = true;
            this.radioDiners.Location = new System.Drawing.Point(392, 306);
            this.radioDiners.Name = "radioDiners";
            this.radioDiners.Size = new System.Drawing.Size(14, 13);
            this.radioDiners.TabIndex = 32;
            this.radioDiners.TabStop = true;
            this.radioDiners.UseVisualStyleBackColor = true;
            // 
            // radioMaster
            // 
            this.radioMaster.AutoSize = true;
            this.radioMaster.Location = new System.Drawing.Point(131, 381);
            this.radioMaster.Name = "radioMaster";
            this.radioMaster.Size = new System.Drawing.Size(14, 13);
            this.radioMaster.TabIndex = 33;
            this.radioMaster.TabStop = true;
            this.radioMaster.UseVisualStyleBackColor = true;
            // 
            // radioAmerican
            // 
            this.radioAmerican.AutoSize = true;
            this.radioAmerican.Location = new System.Drawing.Point(392, 381);
            this.radioAmerican.Name = "radioAmerican";
            this.radioAmerican.Size = new System.Drawing.Size(14, 13);
            this.radioAmerican.TabIndex = 34;
            this.radioAmerican.TabStop = true;
            this.radioAmerican.UseVisualStyleBackColor = true;
            // 
            // txt_Valor_Pago
            // 
            this.txt_Valor_Pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Valor_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor_Pago.Location = new System.Drawing.Point(182, 191);
            this.txt_Valor_Pago.Name = "txt_Valor_Pago";
            this.txt_Valor_Pago.Size = new System.Drawing.Size(140, 26);
            this.txt_Valor_Pago.TabIndex = 35;
            this.txt_Valor_Pago.TextChanged += new System.EventHandler(this.txt_Valor_Pago_TextChanged);
            // 
            // btnActualizarPagos
            // 
            this.btnActualizarPagos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizarPagos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarPagos.BorderRadius = 4;
            this.btnActualizarPagos.BorderSize = 0;
            this.btnActualizarPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarPagos.FlatAppearance.BorderSize = 0;
            this.btnActualizarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPagos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPagos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPagos.Location = new System.Drawing.Point(457, 172);
            this.btnActualizarPagos.Name = "btnActualizarPagos";
            this.btnActualizarPagos.Size = new System.Drawing.Size(152, 40);
            this.btnActualizarPagos.TabIndex = 29;
            this.btnActualizarPagos.Text = "ACTUALIZAR";
            this.btnActualizarPagos.UseVisualStyleBackColor = false;
            this.btnActualizarPagos.Click += new System.EventHandler(this.btnActualizarPagos_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSize = true;
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(490, 132);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(80, 16);
            this.txt_ID.TabIndex = 37;
            this.txt_ID.Text = "------------------";
            // 
            // lbl_ID_Pago
            // 
            this.lbl_ID_Pago.AutoSize = true;
            this.lbl_ID_Pago.BackColor = System.Drawing.Color.White;
            this.lbl_ID_Pago.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Pago.Location = new System.Drawing.Point(454, 132);
            this.lbl_ID_Pago.Name = "lbl_ID_Pago";
            this.lbl_ID_Pago.Size = new System.Drawing.Size(24, 16);
            this.lbl_ID_Pago.TabIndex = 36;
            this.lbl_ID_Pago.Text = "ID:";
            // 
            // Frm_Actualizar_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID_Pago);
            this.Controls.Add(this.txt_Valor_Pago);
            this.Controls.Add(this.radioAmerican);
            this.Controls.Add(this.radioMaster);
            this.Controls.Add(this.radioDiners);
            this.Controls.Add(this.radioVisa);
            this.Controls.Add(this.btnActualizarPagos);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Codigo_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseActPago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcb_Tarjetas_Bg);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Actualizar_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Actualizar_Pago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Tarjetas_Bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseActPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pcb_Tarjetas_Bg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCloseActPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_Codigo_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private user_controls.RJButton btnActualizarPagos;
        private System.Windows.Forms.RadioButton radioVisa;
        private System.Windows.Forms.RadioButton radioDiners;
        private System.Windows.Forms.RadioButton radioMaster;
        private System.Windows.Forms.RadioButton radioAmerican;
        private System.Windows.Forms.TextBox txt_Valor_Pago;
        private System.Windows.Forms.Label txt_ID;
        private System.Windows.Forms.Label lbl_ID_Pago;
    }
}