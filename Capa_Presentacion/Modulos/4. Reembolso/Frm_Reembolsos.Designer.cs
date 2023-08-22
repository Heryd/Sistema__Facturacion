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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.txtBusquedaReembolso = new System.Windows.Forms.TextBox();
            this.dtgV_Reembolsos = new System.Windows.Forms.DataGridView();
            this.cmb_Filtro_Reembolso = new System.Windows.Forms.ComboBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.gradient_Label_Bounds1 = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.txt_Busqueda = new Capa_Presentacion.user_controls.TextBox_Control();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.pn_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Reembolsos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Container.Controls.Add(this.lbl_Error);
            this.pn_Container.Controls.Add(this.txtBusquedaReembolso);
            this.pn_Container.Controls.Add(this.gradient_Label_Bounds1);
            this.pn_Container.Controls.Add(this.dtgV_Reembolsos);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Reembolso);
            this.pn_Container.Controls.Add(this.txt_Busqueda);
            this.pn_Container.Controls.Add(this.btn_CloseForm);
            this.pn_Container.Controls.Add(this.lbl_TOP);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 0);
            this.pn_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(1425, 725);
            this.pn_Container.TabIndex = 17;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(45, 204);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(52, 21);
            this.lbl_Error.TabIndex = 36;
            this.lbl_Error.Text = "label1";
            this.lbl_Error.Visible = false;
            // 
            // txtBusquedaReembolso
            // 
            this.txtBusquedaReembolso.BackColor = System.Drawing.Color.White;
            this.txtBusquedaReembolso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaReembolso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusquedaReembolso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaReembolso.Location = new System.Drawing.Point(189, 147);
            this.txtBusquedaReembolso.Name = "txtBusquedaReembolso";
            this.txtBusquedaReembolso.Size = new System.Drawing.Size(314, 31);
            this.txtBusquedaReembolso.TabIndex = 34;
            this.txtBusquedaReembolso.TextChanged += new System.EventHandler(this.txtBusquedaReembolso_TextChanged);
            this.txtBusquedaReembolso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaReembolso_KeyPress);
            // 
            // dtgV_Reembolsos
            // 
            this.dtgV_Reembolsos.AllowUserToAddRows = false;
            this.dtgV_Reembolsos.AllowUserToDeleteRows = false;
            this.dtgV_Reembolsos.AllowUserToResizeColumns = false;
            this.dtgV_Reembolsos.AllowUserToResizeRows = false;
            this.dtgV_Reembolsos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgV_Reembolsos.BackgroundColor = System.Drawing.Color.White;
            this.dtgV_Reembolsos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgV_Reembolsos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgV_Reembolsos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgV_Reembolsos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Reembolsos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgV_Reembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Reembolsos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgV_Reembolsos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Reembolsos.EnableHeadersVisualStyles = false;
            this.dtgV_Reembolsos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Reembolsos.Location = new System.Drawing.Point(42, 235);
            this.dtgV_Reembolsos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgV_Reembolsos.Name = "dtgV_Reembolsos";
            this.dtgV_Reembolsos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Reembolsos.RowHeadersVisible = false;
            this.dtgV_Reembolsos.RowHeadersWidth = 62;
            this.dtgV_Reembolsos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Reembolsos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgV_Reembolsos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Reembolsos.Size = new System.Drawing.Size(1346, 444);
            this.dtgV_Reembolsos.TabIndex = 23;
            this.dtgV_Reembolsos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Reembolsos_CellContentClick);
            this.dtgV_Reembolsos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Reembolsos_CellPainting);
            // 
            // cmb_Filtro_Reembolso
            // 
            this.cmb_Filtro_Reembolso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Reembolso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Reembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Reembolso.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Filtro_Reembolso.FormattingEnabled = true;
            this.cmb_Filtro_Reembolso.Items.AddRange(new object[] {
            "Código",
            "Fecha",
            "Identificador de Factura"});
            this.cmb_Filtro_Reembolso.Location = new System.Drawing.Point(558, 147);
            this.cmb_Filtro_Reembolso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Filtro_Reembolso.Name = "cmb_Filtro_Reembolso";
            this.cmb_Filtro_Reembolso.Size = new System.Drawing.Size(383, 45);
            this.cmb_Filtro_Reembolso.TabIndex = 20;
            this.cmb_Filtro_Reembolso.SelectedIndexChanged += new System.EventHandler(this.cmb_Filtro_Reembolso_SelectedIndexChanged);
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
            // gradient_Label_Bounds1
            // 
            this.gradient_Label_Bounds1.BackColor = System.Drawing.Color.Transparent;
            this.gradient_Label_Bounds1.BorderRadius = 7;
            this.gradient_Label_Bounds1.BorderSize = 2;
            this.gradient_Label_Bounds1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradient_Label_Bounds1.Font = new System.Drawing.Font("Recursive", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient_Label_Bounds1.ForeColor = System.Drawing.Color.Black;
            this.gradient_Label_Bounds1.LeftColor = System.Drawing.Color.White;
            this.gradient_Label_Bounds1.Location = new System.Drawing.Point(45, 134);
            this.gradient_Label_Bounds1.Name = "gradient_Label_Bounds1";
            this.gradient_Label_Bounds1.RightColor = System.Drawing.Color.WhiteSmoke;
            this.gradient_Label_Bounds1.Size = new System.Drawing.Size(480, 62);
            this.gradient_Label_Bounds1.TabIndex = 35;
            this.gradient_Label_Bounds1.Text = "Buscar";
            this.gradient_Label_Bounds1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Busqueda.BorderColor = System.Drawing.Color.Khaki;
            this.txt_Busqueda.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.txt_Busqueda.BorderRadius = 5;
            this.txt_Busqueda.BorderSize = 4;
            this.txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Busqueda.Location = new System.Drawing.Point(42, 152);
            this.txt_Busqueda.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Busqueda.Multiline = false;
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txt_Busqueda.PasswordChar = false;
            this.txt_Busqueda.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Busqueda.PlaceholderText = "Buscar";
            this.txt_Busqueda.Size = new System.Drawing.Size(483, 47);
            this.txt_Busqueda.TabIndex = 17;
            this.txt_Busqueda.TextBox1_Changed = null;
            this.txt_Busqueda.Texts = "";
            this.txt_Busqueda.UnderlinedStyle = true;
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
            this.lbl_TOP.Text = "      REEMBOLSOS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Reembolsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 725);
            this.Controls.Add(this.pn_Container);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Reembolsos";
            this.Text = "Frm_Reembolsos";
            this.Load += new System.EventHandler(this.Frm_Reembolsos_Load);
            this.pn_Container.ResumeLayout(false);
            this.pn_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Reembolsos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.ComboBox cmb_Filtro_Reembolso;
        private user_controls.TextBox_Control txt_Busqueda;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private System.Windows.Forms.DataGridView dtgV_Reembolsos;
        private System.Windows.Forms.TextBox txtBusquedaReembolso;
        private user_controls.Gradient_Label_Bounds gradient_Label_Bounds1;
        private System.Windows.Forms.Label lbl_Error;
    }
}