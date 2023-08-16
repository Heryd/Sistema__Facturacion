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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.gradient_Label_Bounds1 = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.dtgV_Facturas = new System.Windows.Forms.DataGridView();
            this.cmb_Filtro_Facturas = new System.Windows.Forms.ComboBox();
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
            this.pn_Container.Controls.Add(this.txt_Busqueda);
            this.pn_Container.Controls.Add(this.gradient_Label_Bounds1);
            this.pn_Container.Controls.Add(this.dtgV_Facturas);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Facturas);
            this.pn_Container.Controls.Add(this.btn_CloseForm);
            this.pn_Container.Controls.Add(this.lbl_TOP);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 0);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(867, 471);
            this.pn_Container.TabIndex = 16;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.Location = new System.Drawing.Point(121, 106);
            this.txt_Busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(331, 21);
            this.txt_Busqueda.TabIndex = 24;
            this.txt_Busqueda.TextChanged += new System.EventHandler(this.txt_Busqueda_TextChanged);
            // 
            // gradient_Label_Bounds1
            // 
            this.gradient_Label_Bounds1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gradient_Label_Bounds1.BorderRadius = 7;
            this.gradient_Label_Bounds1.BorderSize = 1;
            this.gradient_Label_Bounds1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradient_Label_Bounds1.Font = new System.Drawing.Font("Recursive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient_Label_Bounds1.ForeColor = System.Drawing.Color.Black;
            this.gradient_Label_Bounds1.LeftColor = System.Drawing.Color.AliceBlue;
            this.gradient_Label_Bounds1.Location = new System.Drawing.Point(25, 96);
            this.gradient_Label_Bounds1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gradient_Label_Bounds1.Name = "gradient_Label_Bounds1";
            this.gradient_Label_Bounds1.RightColor = System.Drawing.Color.AliceBlue;
            this.gradient_Label_Bounds1.Size = new System.Drawing.Size(441, 40);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Facturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgV_Facturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Facturas.EnableHeadersVisualStyles = false;
            this.dtgV_Facturas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Facturas.Location = new System.Drawing.Point(28, 147);
            this.dtgV_Facturas.Name = "dtgV_Facturas";
            this.dtgV_Facturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Facturas.RowHeadersVisible = false;
            this.dtgV_Facturas.RowHeadersWidth = 62;
            this.dtgV_Facturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Facturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgV_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Facturas.Size = new System.Drawing.Size(897, 294);
            this.dtgV_Facturas.TabIndex = 23;
            this.dtgV_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Facturas_CellContentClick);
            this.dtgV_Facturas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Facturas_CellPainting);
            // 
            // cmb_Filtro_Facturas
            // 
            this.cmb_Filtro_Facturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Facturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Facturas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Filtro_Facturas.FormattingEnabled = true;
            this.cmb_Filtro_Facturas.Items.AddRange(new object[] {
            "Servicio",
            "Código",
            "Fecha",
            "Monto",
            "Cédula"});
            this.cmb_Filtro_Facturas.Location = new System.Drawing.Point(486, 105);
            this.cmb_Filtro_Facturas.Name = "cmb_Filtro_Facturas";
            this.cmb_Filtro_Facturas.Size = new System.Drawing.Size(149, 24);
            this.cmb_Filtro_Facturas.TabIndex = 20;
            this.cmb_Filtro_Facturas.SelectedIndexChanged += new System.EventHandler(this.cmb_Filtro_Facturas_SelectedIndexChanged);
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
            this.lbl_TOP.Text = "      FACTURAS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 471);
            this.Controls.Add(this.pn_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}