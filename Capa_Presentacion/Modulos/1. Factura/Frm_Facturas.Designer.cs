namespace Capa_Presentacion.Modulos._1._Factura
{
    partial class Frm_Facturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.gradient_Label_Bounds1 = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.dtgV_Facturas = new System.Windows.Forms.DataGridView();
            this.cmb_Filtro_Facturas = new System.Windows.Forms.ComboBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.textBox_Control1 = new Capa_Presentacion.user_controls.TextBox_Control();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pn_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Container.Controls.Add(this.lbl_Error);
            this.pn_Container.Controls.Add(this.txt_Busqueda);
            this.pn_Container.Controls.Add(this.gradient_Label_Bounds1);
            this.pn_Container.Controls.Add(this.dtgV_Facturas);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Facturas);
            this.pn_Container.Controls.Add(this.btn_CloseForm);
            this.pn_Container.Controls.Add(this.lbl_TOP);
            this.pn_Container.Controls.Add(this.textBox_Control1);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 0);
            this.pn_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(1300, 725);
            this.pn_Container.TabIndex = 16;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.Location = new System.Drawing.Point(182, 163);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(496, 31);
            this.txt_Busqueda.TabIndex = 24;
            this.txt_Busqueda.TextChanged += new System.EventHandler(this.txt_Busqueda_TextChanged);
            this.txt_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Busqueda_KeyPress);
            // 
            // gradient_Label_Bounds1
            // 
            this.gradient_Label_Bounds1.BackColor = System.Drawing.Color.Transparent;
            this.gradient_Label_Bounds1.BorderRadius = 7;
            this.gradient_Label_Bounds1.BorderSize = 1;
            this.gradient_Label_Bounds1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradient_Label_Bounds1.Font = new System.Drawing.Font("Recursive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient_Label_Bounds1.ForeColor = System.Drawing.Color.Black;
            this.gradient_Label_Bounds1.LeftColor = System.Drawing.Color.White;
            this.gradient_Label_Bounds1.Location = new System.Drawing.Point(38, 148);
            this.gradient_Label_Bounds1.Name = "gradient_Label_Bounds1";
            this.gradient_Label_Bounds1.RightColor = System.Drawing.Color.WhiteSmoke;
            this.gradient_Label_Bounds1.Size = new System.Drawing.Size(662, 62);
            this.gradient_Label_Bounds1.TabIndex = 25;
            this.gradient_Label_Bounds1.Text = "Buscar";
            this.gradient_Label_Bounds1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgV_Facturas
            // 
            this.dtgV_Facturas.AllowUserToAddRows = false;
            this.dtgV_Facturas.AllowUserToDeleteRows = false;
            this.dtgV_Facturas.AllowUserToResizeColumns = false;
            this.dtgV_Facturas.AllowUserToResizeRows = false;
            this.dtgV_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgV_Facturas.BackgroundColor = System.Drawing.Color.White;
            this.dtgV_Facturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgV_Facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgV_Facturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgV_Facturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Facturas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgV_Facturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Facturas.EnableHeadersVisualStyles = false;
            this.dtgV_Facturas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Facturas.Location = new System.Drawing.Point(42, 274);
            this.dtgV_Facturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgV_Facturas.Name = "dtgV_Facturas";
            this.dtgV_Facturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Facturas.RowHeadersVisible = false;
            this.dtgV_Facturas.RowHeadersWidth = 62;
            this.dtgV_Facturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Facturas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgV_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Facturas.Size = new System.Drawing.Size(1346, 404);
            this.dtgV_Facturas.TabIndex = 23;
            this.dtgV_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Facturas_CellContentClick);
            this.dtgV_Facturas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Facturas_CellPainting);
            // 
            // cmb_Filtro_Facturas
            // 
            this.cmb_Filtro_Facturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Facturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Facturas.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Filtro_Facturas.FormattingEnabled = true;
            this.cmb_Filtro_Facturas.Items.AddRange(new object[] {
            "Servicio",
            "Código",
            "Fecha",
            "Monto",
            "Cédula"});
            this.cmb_Filtro_Facturas.Location = new System.Drawing.Point(729, 162);
            this.cmb_Filtro_Facturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Filtro_Facturas.Name = "cmb_Filtro_Facturas";
            this.cmb_Filtro_Facturas.Size = new System.Drawing.Size(309, 45);
            this.cmb_Filtro_Facturas.TabIndex = 20;
            this.cmb_Filtro_Facturas.SelectedIndexChanged += new System.EventHandler(this.cmb_Filtro_Facturas_SelectedIndexChanged);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btn_CloseForm.Location = new System.Drawing.Point(1320, 52);
            this.btn_CloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(52, 54);
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
            this.lbl_TOP.Location = new System.Drawing.Point(33, 31);
            this.lbl_TOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.lbl_TOP.Size = new System.Drawing.Size(1354, 95);
            this.lbl_TOP.TabIndex = 14;
            this.lbl_TOP.Text = "      FACTURAS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Control1
            // 
            this.textBox_Control1.BackColor = System.Drawing.Color.White;
            this.textBox_Control1.BorderColor = System.Drawing.Color.Khaki;
            this.textBox_Control1.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.textBox_Control1.BorderRadius = 5;
            this.textBox_Control1.BorderSize = 4;
            this.textBox_Control1.Enabled = false;
            this.textBox_Control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Control1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_Control1.Location = new System.Drawing.Point(42, 169);
            this.textBox_Control1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Control1.Multiline = false;
            this.textBox_Control1.Name = "textBox_Control1";
            this.textBox_Control1.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.textBox_Control1.PasswordChar = false;
            this.textBox_Control1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_Control1.PlaceholderText = "Buscar";
            this.textBox_Control1.Size = new System.Drawing.Size(658, 47);
            this.textBox_Control1.TabIndex = 26;
            this.textBox_Control1.TextBox1_Changed = null;
            this.textBox_Control1.Texts = "";
            this.textBox_Control1.UnderlinedStyle = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(38, 220);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(52, 21);
            this.lbl_Error.TabIndex = 37;
            this.lbl_Error.Text = "label1";
            this.lbl_Error.Visible = false;
            // 
            // Frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.Controls.Add(this.pn_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Facturas";
            this.Text = "Frm_Facturas";
            this.Load += new System.EventHandler(this.Frm_Facturas_Load);
            this.pn_Container.ResumeLayout(false);
            this.pn_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.ComboBox cmb_Filtro_Facturas;
        private System.Windows.Forms.DataGridView dtgV_Facturas;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private user_controls.Gradient_Label_Bounds gradient_Label_Bounds1;
        private user_controls.TextBox_Control textBox_Control1;
        private System.Windows.Forms.Label lbl_Error;
    }
}