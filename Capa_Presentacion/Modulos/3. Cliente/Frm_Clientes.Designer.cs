namespace Capa_Presentacion.Modulos._3._Cliente
{
    partial class Frm_Clientes
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
            this.dtgV_Clientes = new System.Windows.Forms.DataGridView();
            this.cmb_Filtro_Pago = new System.Windows.Forms.ComboBox();
            this.cmb_Filtro_Cliente = new System.Windows.Forms.ComboBox();
            this.txt_Busqueda = new Capa_Presentacion.user_controls.TextBox_Control();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.pn_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Container.Controls.Add(this.dtgV_Clientes);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Pago);
            this.pn_Container.Controls.Add(this.cmb_Filtro_Cliente);
            this.pn_Container.Controls.Add(this.txt_Busqueda);
            this.pn_Container.Controls.Add(this.btn_CloseForm);
            this.pn_Container.Controls.Add(this.lbl_TOP);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 0);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(957, 471);
            this.pn_Container.TabIndex = 18;
            // 
            // dtgV_Clientes
            // 
            this.dtgV_Clientes.AllowUserToAddRows = false;
            this.dtgV_Clientes.AllowUserToDeleteRows = false;
            this.dtgV_Clientes.AllowUserToResizeColumns = false;
            this.dtgV_Clientes.AllowUserToResizeRows = false;
            this.dtgV_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgV_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgV_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgV_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgV_Clientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgV_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgV_Clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Clientes.EnableHeadersVisualStyles = false;
            this.dtgV_Clientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Clientes.Location = new System.Drawing.Point(28, 137);
            this.dtgV_Clientes.Name = "dtgV_Clientes";
            this.dtgV_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Clientes.RowHeadersVisible = false;
            this.dtgV_Clientes.RowHeadersWidth = 62;
            this.dtgV_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Clientes.Size = new System.Drawing.Size(897, 304);
            this.dtgV_Clientes.TabIndex = 22;
            this.dtgV_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Clientes_CellContentClick);
            this.dtgV_Clientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Clientes_CellPainting);
            // 
            // cmb_Filtro_Pago
            // 
            this.cmb_Filtro_Pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Pago.FormattingEnabled = true;
            this.cmb_Filtro_Pago.Items.AddRange(new object[] {
            "Pago (all)",
            "Estado de Cuenta",
            "Método de Pago",
            "Monto"});
            this.cmb_Filtro_Pago.Location = new System.Drawing.Point(488, 109);
            this.cmb_Filtro_Pago.Name = "cmb_Filtro_Pago";
            this.cmb_Filtro_Pago.Size = new System.Drawing.Size(116, 21);
            this.cmb_Filtro_Pago.TabIndex = 21;
            // 
            // cmb_Filtro_Cliente
            // 
            this.cmb_Filtro_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Filtro_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Filtro_Cliente.FormattingEnabled = true;
            this.cmb_Filtro_Cliente.Items.AddRange(new object[] {
            "Cliente (all)",
            "Código",
            "Fecha de Registro"});
            this.cmb_Filtro_Cliente.Location = new System.Drawing.Point(366, 109);
            this.cmb_Filtro_Cliente.Name = "cmb_Filtro_Cliente";
            this.cmb_Filtro_Cliente.Size = new System.Drawing.Size(116, 21);
            this.cmb_Filtro_Cliente.TabIndex = 20;
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
            this.lbl_TOP.Text = "      CLIENTES";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 471);
            this.Controls.Add(this.pn_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Clientes";
            this.Text = "Frm_Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.pn_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.ComboBox cmb_Filtro_Pago;
        private System.Windows.Forms.ComboBox cmb_Filtro_Cliente;
        private user_controls.TextBox_Control txt_Busqueda;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private user_controls.Gradient_Label_Bounds lbl_TOP;
        private System.Windows.Forms.DataGridView dtgV_Clientes;
    }
}