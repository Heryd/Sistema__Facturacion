namespace Capa_Presentacion.Modulos._4._Reembolso
{
    partial class Frm_Actualizar_Reembolso
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
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Cedula = new System.Windows.Forms.Label();
            this.lbl_Separator = new System.Windows.Forms.Label();
            this.txt_Nombres_Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Motivo = new System.Windows.Forms.Label();
            this.txt_Motivo_Reembolso = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Actualizar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.White;
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(651, 12);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 15;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.lbl_TOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 481);
            this.panel1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Controls.Add(this.lbl_Fecha);
            this.flowLayoutPanel1.Controls.Add(this.txt_fecha);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Apellidos);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cmb_Estado);
            this.flowLayoutPanel1.Controls.Add(this.lbl_Motivo);
            this.flowLayoutPanel1.Controls.Add(this.txt_Motivo_Reembolso);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btn_Actualizar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 95);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 353);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(3, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(40, 15);
            this.lbl_Fecha.TabIndex = 43;
            this.lbl_Fecha.Text = "Fecha:";
            this.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(3, 15);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(223, 50);
            this.txt_fecha.TabIndex = 44;
            this.txt_fecha.Text = "Esta es la Fecha";
            this.txt_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(3, 65);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(75, 29);
            this.lbl_Apellidos.TabIndex = 52;
            this.lbl_Apellidos.Text = "Cliente:";
            this.lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Cedula);
            this.panel2.Controls.Add(this.lbl_Separator);
            this.panel2.Controls.Add(this.txt_Nombres_Cliente);
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 62);
            this.panel2.TabIndex = 53;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.AutoSize = true;
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cedula.Location = new System.Drawing.Point(0, 10);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(67, 16);
            this.txt_Cedula.TabIndex = 55;
            this.txt_Cedula.Text = "0000000000";
            this.txt_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Separator
            // 
            this.lbl_Separator.AutoSize = true;
            this.lbl_Separator.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Separator.Location = new System.Drawing.Point(88, 10);
            this.lbl_Separator.Name = "lbl_Separator";
            this.lbl_Separator.Size = new System.Drawing.Size(12, 16);
            this.lbl_Separator.TabIndex = 54;
            this.lbl_Separator.Text = "-";
            this.lbl_Separator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Nombres_Cliente
            // 
            this.txt_Nombres_Cliente.AutoSize = true;
            this.txt_Nombres_Cliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombres_Cliente.Location = new System.Drawing.Point(121, 10);
            this.txt_Nombres_Cliente.Name = "txt_Nombres_Cliente";
            this.txt_Nombres_Cliente.Size = new System.Drawing.Size(42, 16);
            this.txt_Nombres_Cliente.TabIndex = 56;
            this.txt_Nombres_Cliente.Text = "-------";
            this.txt_Nombres_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Estado:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.cmb_Estado.Location = new System.Drawing.Point(3, 192);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(178, 21);
            this.cmb_Estado.TabIndex = 50;
            // 
            // lbl_Motivo
            // 
            this.lbl_Motivo.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Motivo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Motivo.Location = new System.Drawing.Point(3, 216);
            this.lbl_Motivo.Name = "lbl_Motivo";
            this.lbl_Motivo.Size = new System.Drawing.Size(259, 28);
            this.lbl_Motivo.TabIndex = 49;
            this.lbl_Motivo.Text = "Motivo del Reembolso:";
            this.lbl_Motivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Motivo_Reembolso
            // 
            this.txt_Motivo_Reembolso.Location = new System.Drawing.Point(3, 247);
            this.txt_Motivo_Reembolso.Name = "txt_Motivo_Reembolso";
            this.txt_Motivo_Reembolso.Size = new System.Drawing.Size(259, 90);
            this.txt_Motivo_Reembolso.TabIndex = 48;
            this.txt_Motivo_Reembolso.Text = "";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(268, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 334);
            this.panel3.TabIndex = 54;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualizar.BorderRadius = 8;
            this.btn_Actualizar.BorderSize = 0;
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(370, 2);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(112, 38);
            this.btn_Actualizar.TabIndex = 17;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_Close.Location = new System.Drawing.Point(456, 32);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 14;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_TOP
            // 
            this.lbl_TOP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_TOP.BorderRadius = 10;
            this.lbl_TOP.BorderSize = 0;
            this.lbl_TOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TOP.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TOP.ForeColor = System.Drawing.Color.White;
            this.lbl_TOP.LeftColor = System.Drawing.Color.LightGreen;
            this.lbl_TOP.Location = new System.Drawing.Point(16, 20);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.RightColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_TOP.Size = new System.Drawing.Size(488, 62);
            this.lbl_TOP.TabIndex = 15;
            this.lbl_TOP.Text = "   ACTUALIZAR REEMBOLSO";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Actualizar_Reembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Actualizar_Reembolso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Actualizar_Reembolso";
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_CloseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label txt_fecha;
        private user_controls.RJButton btn_Actualizar;
        private System.Windows.Forms.PictureBox btn_Close;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private System.Windows.Forms.Label lbl_Motivo;
        private System.Windows.Forms.RichTextBox txt_Motivo_Reembolso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_Cedula;
        private System.Windows.Forms.Label lbl_Separator;
        private System.Windows.Forms.Label txt_Nombres_Cliente;
        private System.Windows.Forms.Panel panel3;
    }
}