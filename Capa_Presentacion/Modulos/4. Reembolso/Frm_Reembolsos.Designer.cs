namespace Capa_Presentacion.Modulos._4._Reembolso
{
    partial class Frm_Reembolsos
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
            this.pn_Container = new System.Windows.Forms.Panel();
            this.cmb_Filtro_Pago = new System.Windows.Forms.ComboBox();
            this.cmb_Filtro_Reembolso = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new Capa_Presentacion.user_controls.RJButton();
            this.btn_Actualizar = new Capa_Presentacion.user_controls.RJButton();
            this.txt_Busqueda = new Capa_Presentacion.user_controls.TextBox_Control();
            this.dtgV_Facturas = new System.Windows.Forms.DataGridView();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.pn_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Container.Controls.Add(this.cmb_Filtro_Pago);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Reembolso);
            this.pn_Container.Controls.Add(this.btn_Eliminar);
            this.pn_Container.Controls.Add(this.btn_Actualizar);
            this.pn_Container.Controls.Add(this.txt_Busqueda);
            this.pn_Container.Controls.Add(this.dtgV_Facturas);
            this.pn_Container.Controls.Add(this.btn_CloseForm);
            this.pn_Container.Controls.Add(this.lbl_TOP);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 0);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(950, 471);
            this.pn_Container.TabIndex = 17;
            // 
            // cmb_Filtro_Pago
            // 
            this.cmb_Filtro_Pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Pago.FormattingEnabled = true;
            this.cmb_Filtro_Pago.Items.AddRange(new object[] {
            "Pago (all)",
            "Monto",
            "Método de Pago"});
            this.cmb_Filtro_Pago.Location = new System.Drawing.Point(488, 109);
            this.cmb_Filtro_Pago.Name = "cmb_Filtro_Pago";
            this.cmb_Filtro_Pago.Size = new System.Drawing.Size(116, 21);
            this.cmb_Filtro_Pago.TabIndex = 21;
            // 
            // cmb_Filtro_Reembolso
            // 
            this.cmb_Filtro_Reembolso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Reembolso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Reembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Reembolso.FormattingEnabled = true;
            this.cmb_Filtro_Reembolso.Items.AddRange(new object[] {
            "Reembolso (all)",
            "Código",
            "Fecha",
            "Estado"});
            this.cmb_Filtro_Reembolso.Location = new System.Drawing.Point(366, 109);
            this.cmb_Filtro_Reembolso.Name = "cmb_Filtro_Reembolso";
            this.cmb_Filtro_Reembolso.Size = new System.Drawing.Size(116, 21);
            this.cmb_Filtro_Reembolso.TabIndex = 20;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Tomato;
            this.btn_Eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Eliminar.BorderRadius = 5;
            this.btn_Eliminar.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(797, 99);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(118, 31);
            this.btn_Eliminar.TabIndex = 19;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualizar.BorderRadius = 5;
            this.btn_Actualizar.BorderSize = 0;
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(673, 99);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(118, 31);
            this.btn_Actualizar.TabIndex = 18;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Busqueda.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_Busqueda.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Busqueda.BorderRadius = 5;
            this.txt_Busqueda.BorderSize = 4;
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Busqueda.Location = new System.Drawing.Point(28, 99);
            this.txt_Busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Busqueda.Multiline = false;
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Busqueda.PasswordChar = false;
            this.txt_Busqueda.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Busqueda.PlaceholderText = "Buscar";
            this.txt_Busqueda.Size = new System.Drawing.Size(322, 31);
            this.txt_Busqueda.TabIndex = 17;
            this.txt_Busqueda.Texts = "";
            this.txt_Busqueda.UnderlinedStyle = true;
            // 
            // dtgV_Facturas
            // 
            this.dtgV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgV_Facturas.Location = new System.Drawing.Point(28, 148);
            this.dtgV_Facturas.Name = "dtgV_Facturas";
            this.dtgV_Facturas.Size = new System.Drawing.Size(887, 283);
            this.dtgV_Facturas.TabIndex = 16;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(880, 34);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 15;
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
            this.lbl_TOP.TabIndex = 14;
            this.lbl_TOP.Text = "      REEMBOLSOS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Reembolsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 471);
            this.Controls.Add(this.pn_Container);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reembolsos";
            this.Text = "Frm_Reembolsos";
            this.pn_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.ComboBox cmb_Filtro_Pago;
        private System.Windows.Forms.ComboBox cmb_Filtro_Reembolso;
        private user_controls.RJButton btn_Eliminar;
        private user_controls.RJButton btn_Actualizar;
        private user_controls.TextBox_Control txt_Busqueda;
        private System.Windows.Forms.DataGridView dtgV_Facturas;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
    }
}