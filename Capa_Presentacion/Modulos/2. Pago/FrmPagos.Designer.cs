namespace Capa_Presentacion.Modulos._2._Pago
{
    partial class FrmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbFiltroPagos = new System.Windows.Forms.ComboBox();
            this.btnClosePagos = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtgV_Pagos = new System.Windows.Forms.DataGridView();
            this.txtBusquedaPago = new System.Windows.Forms.TextBox();
            this.gradient_Label_Bounds1 = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.btnBuscar = new Capa_Presentacion.user_controls.RJButton();
            this.textBox_Control1 = new Capa_Presentacion.user_controls.TextBox_Control();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltroPagos
            // 
            this.cmbFiltroPagos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFiltroPagos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFiltroPagos.BackColor = System.Drawing.SystemColors.Control;
            this.cmbFiltroPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFiltroPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroPagos.FormattingEnabled = true;
            this.cmbFiltroPagos.Items.AddRange(new object[] {
            "Estado",
            "Fecha",
            "Monto"});
            this.cmbFiltroPagos.Location = new System.Drawing.Point(500, 211);
            this.cmbFiltroPagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroPagos.Name = "cmbFiltroPagos";
            this.cmbFiltroPagos.Size = new System.Drawing.Size(242, 33);
            this.cmbFiltroPagos.TabIndex = 8;
            this.cmbFiltroPagos.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPagos_SelectedIndexChanged);
            // 
            // btnClosePagos
            // 
            this.btnClosePagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btnClosePagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePagos.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btnClosePagos.Location = new System.Drawing.Point(1202, 63);
            this.btnClosePagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClosePagos.Name = "btnClosePagos";
            this.btnClosePagos.Size = new System.Drawing.Size(57, 65);
            this.btnClosePagos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClosePagos.TabIndex = 6;
            this.btnClosePagos.TabStop = false;
            this.btnClosePagos.Click += new System.EventHandler(this.btnClosePagos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1287, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.minimizar;
            this.pictureBox1.Location = new System.Drawing.Point(226, -46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_Presentacion.Properties.Resources.Fondo_OPC_Elegida;
            this.pictureBox3.Location = new System.Drawing.Point(3, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1338, 717);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // dtgV_Pagos
            // 
            this.dtgV_Pagos.AllowUserToAddRows = false;
            this.dtgV_Pagos.AllowUserToDeleteRows = false;
            this.dtgV_Pagos.AllowUserToResizeColumns = false;
            this.dtgV_Pagos.AllowUserToResizeRows = false;
            this.dtgV_Pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgV_Pagos.BackgroundColor = System.Drawing.Color.White;
            this.dtgV_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgV_Pagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgV_Pagos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgV_Pagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Pagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgV_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Pagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgV_Pagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Pagos.EnableHeadersVisualStyles = false;
            this.dtgV_Pagos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Pagos.Location = new System.Drawing.Point(51, 309);
            this.dtgV_Pagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgV_Pagos.Name = "dtgV_Pagos";
            this.dtgV_Pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Pagos.RowHeadersVisible = false;
            this.dtgV_Pagos.RowHeadersWidth = 62;
            this.dtgV_Pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Pagos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgV_Pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Pagos.Size = new System.Drawing.Size(1244, 377);
            this.dtgV_Pagos.TabIndex = 24;
            this.dtgV_Pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Pagos_CellContentClick);
            this.dtgV_Pagos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Pagos_CellPainting);
            // 
            // txtBusquedaPago
            // 
            this.txtBusquedaPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusquedaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusquedaPago.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPago.Location = new System.Drawing.Point(195, 212);
            this.txtBusquedaPago.Name = "txtBusquedaPago";
            this.txtBusquedaPago.Size = new System.Drawing.Size(276, 31);
            this.txtBusquedaPago.TabIndex = 30;
            this.txtBusquedaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaPago_KeyPress);
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
            this.gradient_Label_Bounds1.Location = new System.Drawing.Point(51, 197);
            this.gradient_Label_Bounds1.Name = "gradient_Label_Bounds1";
            this.gradient_Label_Bounds1.RightColor = System.Drawing.Color.WhiteSmoke;
            this.gradient_Label_Bounds1.Size = new System.Drawing.Size(441, 62);
            this.gradient_Label_Bounds1.TabIndex = 31;
            this.gradient_Label_Bounds1.Text = "Buscar";
            this.gradient_Label_Bounds1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnBuscar.BorderRadius = 4;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1138, 198);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 62);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.textBox_Control1.Location = new System.Drawing.Point(51, 219);
            this.textBox_Control1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Control1.Multiline = false;
            this.textBox_Control1.Name = "textBox_Control1";
            this.textBox_Control1.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.textBox_Control1.PasswordChar = false;
            this.textBox_Control1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_Control1.PlaceholderText = "Buscar";
            this.textBox_Control1.Size = new System.Drawing.Size(439, 47);
            this.textBox_Control1.TabIndex = 32;
            this.textBox_Control1.TextBox1_Changed = null;
            this.textBox_Control1.Texts = "";
            this.textBox_Control1.UnderlinedStyle = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.White;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(53, 272);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(52, 21);
            this.lbl_Error.TabIndex = 38;
            this.lbl_Error.Text = "label1";
            this.lbl_Error.Visible = false;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 731);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txtBusquedaPago);
            this.Controls.Add(this.gradient_Label_Bounds1);
            this.Controls.Add(this.dtgV_Pagos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox_Control1);
            this.Controls.Add(this.cmbFiltroPagos);
            this.Controls.Add(this.btnClosePagos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Pagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnClosePagos;
        private System.Windows.Forms.ComboBox cmbFiltroPagos;
        private user_controls.RJButton btnBuscar;
        private System.Windows.Forms.DataGridView dtgV_Pagos;
        private System.Windows.Forms.TextBox txtBusquedaPago;
        private user_controls.Gradient_Label_Bounds gradient_Label_Bounds1;
        private user_controls.TextBox_Control textBox_Control1;
        private System.Windows.Forms.Label lbl_Error;
    }
}