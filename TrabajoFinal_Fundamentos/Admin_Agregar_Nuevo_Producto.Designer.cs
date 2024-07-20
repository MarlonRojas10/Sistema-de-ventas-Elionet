namespace TrabajoFinal_Fundamentos
{
    partial class Admin_Agregar_Nuevo_Producto
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
            this.label2 = new System.Windows.Forms.Label();
            this.cod_producto = new System.Windows.Forms.Label();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código del Producto:";
            // 
            // cod_producto
            // 
            this.cod_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cod_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cod_producto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_producto.ForeColor = System.Drawing.Color.White;
            this.cod_producto.Location = new System.Drawing.Point(155, 119);
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.Size = new System.Drawing.Size(100, 23);
            this.cod_producto.TabIndex = 12;
            this.cod_producto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_producto
            // 
            this.cb_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cb_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_producto.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cb_producto.ForeColor = System.Drawing.Color.White;
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Items.AddRange(new object[] {
            "PANTALLAS",
            "IMPRESORAS",
            "TECLADOS",
            "WEBCAMS",
            "PARLANTES",
            "MOUSE",
            "MICROFONOS",
            "AUDIFONOS",
            "TABLETS",
            "iPADS",
            "LAPTOPS"});
            this.cb_producto.Location = new System.Drawing.Point(110, 162);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(312, 24);
            this.cb_producto.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Producto:";
            // 
            // text_descripcion
            // 
            this.text_descripcion.BackColor = System.Drawing.Color.Black;
            this.text_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_descripcion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descripcion.ForeColor = System.Drawing.Color.White;
            this.text_descripcion.Location = new System.Drawing.Point(110, 245);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(312, 21);
            this.text_descripcion.TabIndex = 35;
            this.text_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbMarca.ForeColor = System.Drawing.Color.White;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "ASUS",
            "HP",
            "SAMSUNG",
            "HALION",
            "TOSHIBA",
            "LENOVO",
            "DELL",
            "ACER"});
            this.cbMarca.Location = new System.Drawing.Point(110, 203);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(312, 24);
            this.cbMarca.TabIndex = 34;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(121, 294);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(208, 45);
            this.iconButton5.TabIndex = 33;
            this.iconButton5.Text = "Agregar Nuevo Producto";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Descripcion:";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(98, 33);
            this.iconButton2.TabIndex = 62;
            this.iconButton2.Text = "Regresar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(45, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(355, 1);
            this.label16.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Agregar Producto";
            // 
            // Admin_Agregar_Nuevo_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(435, 351);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_producto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cod_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin_Agregar_Nuevo_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Nuevo_Producto";
            this.Load += new System.EventHandler(this.Agregar_Nuevo_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cod_producto;
        private System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.ComboBox cbMarca;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}