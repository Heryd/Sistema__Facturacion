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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbFiltroPagos = new System.Windows.Forms.ComboBox();
            this.btnClosePagos = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtgV_Pagos = new System.Windows.Forms.DataGridView();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.cmbFiltrarMonto = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new Capa_Presentacion.user_controls.RJButton();
            this.txtBusquedaPago = new Capa_Presentacion.user_controls.TextBox_Control();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
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
            this.cmbFiltroPagos.Location = new System.Drawing.Point(333, 137);
            this.cmbFiltroPagos.Name = "cmbFiltroPagos";
            this.cmbFiltroPagos.Size = new System.Drawing.Size(163, 24);
            this.cmbFiltroPagos.TabIndex = 8;
            this.cmbFiltroPagos.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPagos_SelectedIndexChanged);
            // 
            // btnClosePagos
            // 
            this.btnClosePagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(177)))), ((int)(((byte)(3)))));
            this.btnClosePagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePagos.Image = global::Capa_Presentacion.Properties.Resources.cerca;
            this.btnClosePagos.Location = new System.Drawing.Point(801, 41);
            this.btnClosePagos.Name = "btnClosePagos";
            this.btnClosePagos.Size = new System.Drawing.Size(38, 42);
            this.btnClosePagos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClosePagos.TabIndex = 6;
            this.btnClosePagos.TabStop = false;
            this.btnClosePagos.Click += new System.EventHandler(this.btnClosePagos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(858, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.minimizar;
            this.pictureBox1.Location = new System.Drawing.Point(151, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_Presentacion.Properties.Resources.Fondo_OPC_Elegida;
            this.pictureBox3.Location = new System.Drawing.Point(2, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(892, 466);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgV_Pagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgV_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgV_Pagos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgV_Pagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Pagos.EnableHeadersVisualStyles = false;
            this.dtgV_Pagos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgV_Pagos.Location = new System.Drawing.Point(34, 179);
            this.dtgV_Pagos.Name = "dtgV_Pagos";
            this.dtgV_Pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgV_Pagos.RowHeadersVisible = false;
            this.dtgV_Pagos.RowHeadersWidth = 62;
            this.dtgV_Pagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgV_Pagos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgV_Pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgV_Pagos.Size = new System.Drawing.Size(829, 267);
            this.dtgV_Pagos.TabIndex = 24;
            this.dtgV_Pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgV_Pagos_CellContentClick);
            this.dtgV_Pagos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgV_Pagos_CellPainting);
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor1.Location = new System.Drawing.Point(587, 138);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(68, 22);
            this.txt_Valor1.TabIndex = 25;
            this.txt_Valor1.Visible = false;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor2.Location = new System.Drawing.Point(659, 138);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(68, 22);
            this.txt_Valor2.TabIndex = 26;
            this.txt_Valor2.Visible = false;
            // 
            // cmbFiltrarMonto
            // 
            this.cmbFiltrarMonto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFiltrarMonto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFiltrarMonto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbFiltrarMonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFiltrarMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarMonto.FormattingEnabled = true;
            this.cmbFiltrarMonto.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            ">= && <"});
            this.cmbFiltrarMonto.Location = new System.Drawing.Point(500, 137);
            this.cmbFiltrarMonto.Name = "cmbFiltrarMonto";
            this.cmbFiltrarMonto.Size = new System.Drawing.Size(83, 24);
            this.cmbFiltrarMonto.TabIndex = 28;
            this.cmbFiltrarMonto.Visible = false;
            this.cmbFiltrarMonto.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarMonto_SelectedIndexChanged);
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
            this.btnBuscar.Location = new System.Drawing.Point(759, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 40);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusquedaPago
            // 
            this.txtBusquedaPago.BackColor = System.Drawing.Color.White;
            this.txtBusquedaPago.BorderColor = System.Drawing.Color.Gray;
            this.txtBusquedaPago.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBusquedaPago.BorderRadius = 0;
            this.txtBusquedaPago.BorderSize = 3;
            this.txtBusquedaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPago.ForeColor = System.Drawing.Color.Gray;
            this.txtBusquedaPago.Location = new System.Drawing.Point(34, 133);
            this.txtBusquedaPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaPago.Multiline = false;
            this.txtBusquedaPago.Name = "txtBusquedaPago";
            this.txtBusquedaPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaPago.PasswordChar = false;
            this.txtBusquedaPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusquedaPago.PlaceholderText = "Buscar";
            this.txtBusquedaPago.Size = new System.Drawing.Size(292, 31);
            this.txtBusquedaPago.TabIndex = 7;
            this.txtBusquedaPago.Texts = "";
            this.txtBusquedaPago.UnderlinedStyle = true;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(502, 135);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(147, 27);
            this.txt_fecha.TabIndex = 29;
            this.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            this.txt_fecha.Visible = false;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 475);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.cmbFiltrarMonto);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.dtgV_Pagos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbFiltroPagos);
            this.Controls.Add(this.txtBusquedaPago);
            this.Controls.Add(this.btnClosePagos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private user_controls.TextBox_Control txtBusquedaPago;
        private System.Windows.Forms.ComboBox cmbFiltroPagos;
        private user_controls.RJButton btnBuscar;
        private System.Windows.Forms.DataGridView dtgV_Pagos;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.ComboBox cmbFiltrarMonto;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
    }
}