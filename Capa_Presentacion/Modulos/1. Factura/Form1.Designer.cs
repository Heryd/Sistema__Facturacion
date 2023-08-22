namespace Capa_Presentacion.Modulos._1._Factura
{
    partial class Frm_Input_Data_Records
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
            this.txt_Cedula_Cliente = new Capa_Presentacion.user_controls.TextBox_Control();
            this.gradient_Label_Bounds1 = new Capa_Presentacion.user_controls.Gradient_Label_Bounds();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Generar_Reporte = new Capa_Presentacion.user_controls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Cedula_Cliente
            // 
            this.txt_Cedula_Cliente.BackColor = System.Drawing.Color.Beige;
            this.txt_Cedula_Cliente.BorderColor = System.Drawing.Color.Purple;
            this.txt_Cedula_Cliente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Cedula_Cliente.BorderRadius = 0;
            this.txt_Cedula_Cliente.BorderSize = 2;
            this.txt_Cedula_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cedula_Cliente.Location = new System.Drawing.Point(34, 115);
            this.txt_Cedula_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cedula_Cliente.Multiline = false;
            this.txt_Cedula_Cliente.Name = "txt_Cedula_Cliente";
            this.txt_Cedula_Cliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Cedula_Cliente.PasswordChar = false;
            this.txt_Cedula_Cliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Cedula_Cliente.PlaceholderText = "";
            this.txt_Cedula_Cliente.Size = new System.Drawing.Size(455, 39);
            this.txt_Cedula_Cliente.TabIndex = 0;
            this.txt_Cedula_Cliente.TextBox1_Changed = null;
            this.txt_Cedula_Cliente.Texts = "";
            this.txt_Cedula_Cliente.UnderlinedStyle = true;
            this.txt_Cedula_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_Cliente_KeyPress);
            // 
            // gradient_Label_Bounds1
            // 
            this.gradient_Label_Bounds1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gradient_Label_Bounds1.BorderRadius = 5;
            this.gradient_Label_Bounds1.BorderSize = 2;
            this.gradient_Label_Bounds1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradient_Label_Bounds1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient_Label_Bounds1.ForeColor = System.Drawing.Color.Black;
            this.gradient_Label_Bounds1.LeftColor = System.Drawing.Color.RosyBrown;
            this.gradient_Label_Bounds1.Location = new System.Drawing.Point(-2, -3);
            this.gradient_Label_Bounds1.Name = "gradient_Label_Bounds1";
            this.gradient_Label_Bounds1.Padding = new System.Windows.Forms.Padding(50);
            this.gradient_Label_Bounds1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gradient_Label_Bounds1.Size = new System.Drawing.Size(537, 254);
            this.gradient_Label_Bounds1.TabIndex = 1;
            this.gradient_Label_Bounds1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cédula del Cliente";
            // 
            // btn_Generar_Reporte
            // 
            this.btn_Generar_Reporte.BackColor = System.Drawing.Color.Maroon;
            this.btn_Generar_Reporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Generar_Reporte.BorderRadius = 10;
            this.btn_Generar_Reporte.BorderSize = 0;
            this.btn_Generar_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Generar_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generar_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar_Reporte.ForeColor = System.Drawing.Color.White;
            this.btn_Generar_Reporte.Location = new System.Drawing.Point(34, 161);
            this.btn_Generar_Reporte.Name = "btn_Generar_Reporte";
            this.btn_Generar_Reporte.Size = new System.Drawing.Size(455, 40);
            this.btn_Generar_Reporte.TabIndex = 3;
            this.btn_Generar_Reporte.Text = "BUSCAR Y GENERAR REPORTE";
            this.btn_Generar_Reporte.UseVisualStyleBackColor = false;
            this.btn_Generar_Reporte.Click += new System.EventHandler(this.btn_Generar_Reporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // Frm_Input_Data_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Generar_Reporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cedula_Cliente);
            this.Controls.Add(this.gradient_Label_Bounds1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Input_Data_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private user_controls.TextBox_Control txt_Cedula_Cliente;
        private user_controls.Gradient_Label_Bounds gradient_Label_Bounds1;
        private System.Windows.Forms.Label label1;
        private user_controls.RJButton btn_Generar_Reporte;
        private System.Windows.Forms.Label label2;
    }
}