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
            this.txtBusquedaPago = new Capa_Presentacion.user_controls.TextBox_Control();
            this.cmbFiltroPagos = new System.Windows.Forms.ComboBox();
            this.btnActualizarPagos = new Capa_Presentacion.user_controls.RJButton();
            this.btnEliminarPagos = new Capa_Presentacion.user_controls.RJButton();
            this.dtgVpagos = new System.Windows.Forms.DataGridView();
            this.btnClosePagos = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaPago
            // 
            this.txtBusquedaPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusquedaPago.BorderColor = System.Drawing.Color.Gray;
            this.txtBusquedaPago.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBusquedaPago.BorderRadius = 0;
            this.txtBusquedaPago.BorderSize = 3;
            this.txtBusquedaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPago.ForeColor = System.Drawing.Color.Gray;
            this.txtBusquedaPago.Location = new System.Drawing.Point(34, 127);
            this.txtBusquedaPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaPago.Multiline = false;
            this.txtBusquedaPago.Name = "txtBusquedaPago";
            this.txtBusquedaPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaPago.PasswordChar = false;
            this.txtBusquedaPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusquedaPago.PlaceholderText = "";
            this.txtBusquedaPago.Size = new System.Drawing.Size(289, 31);
            this.txtBusquedaPago.TabIndex = 7;
            this.txtBusquedaPago.Texts = "Buscar";
            this.txtBusquedaPago.UnderlinedStyle = true;
            // 
            // cmbFiltroPagos
            // 
            this.cmbFiltroPagos.FormattingEnabled = true;
            this.cmbFiltroPagos.Location = new System.Drawing.Point(358, 137);
            this.cmbFiltroPagos.Name = "cmbFiltroPagos";
            this.cmbFiltroPagos.Size = new System.Drawing.Size(143, 21);
            this.cmbFiltroPagos.TabIndex = 8;
            // 
            // btnActualizarPagos
            // 
            this.btnActualizarPagos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarPagos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarPagos.BorderRadius = 15;
            this.btnActualizarPagos.BorderSize = 0;
            this.btnActualizarPagos.FlatAppearance.BorderSize = 0;
            this.btnActualizarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPagos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPagos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPagos.Location = new System.Drawing.Point(530, 127);
            this.btnActualizarPagos.Name = "btnActualizarPagos";
            this.btnActualizarPagos.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarPagos.TabIndex = 18;
            this.btnActualizarPagos.Text = "ACTUALIZAR";
            this.btnActualizarPagos.UseVisualStyleBackColor = false;
            this.btnActualizarPagos.Click += new System.EventHandler(this.btnActualizarPagos_Click);
            // 
            // btnEliminarPagos
            // 
            this.btnEliminarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarPagos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarPagos.BorderRadius = 15;
            this.btnEliminarPagos.BorderSize = 0;
            this.btnEliminarPagos.FlatAppearance.BorderSize = 0;
            this.btnEliminarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPagos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPagos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPagos.Location = new System.Drawing.Point(713, 127);
            this.btnEliminarPagos.Name = "btnEliminarPagos";
            this.btnEliminarPagos.Size = new System.Drawing.Size(150, 40);
            this.btnEliminarPagos.TabIndex = 19;
            this.btnEliminarPagos.Text = "ELIMINAR";
            this.btnEliminarPagos.UseVisualStyleBackColor = false;
            // 
            // dtgVpagos
            // 
            this.dtgVpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVpagos.Location = new System.Drawing.Point(34, 199);
            this.dtgVpagos.Name = "dtgVpagos";
            this.dtgVpagos.Size = new System.Drawing.Size(829, 237);
            this.dtgVpagos.TabIndex = 20;
            // 
            // btnClosePagos
            // 
            this.btnClosePagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 475);
            this.Controls.Add(this.dtgVpagos);
            this.Controls.Add(this.btnEliminarPagos);
            this.Controls.Add(this.btnActualizarPagos);
            this.Controls.Add(this.cmbFiltroPagos);
            this.Controls.Add(this.txtBusquedaPago);
            this.Controls.Add(this.btnClosePagos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnClosePagos;
        private user_controls.TextBox_Control txtBusquedaPago;
        private System.Windows.Forms.ComboBox cmbFiltroPagos;
        private user_controls.RJButton btnActualizarPagos;
        private user_controls.RJButton btnEliminarPagos;
        private System.Windows.Forms.DataGridView dtgVpagos;
    }
}