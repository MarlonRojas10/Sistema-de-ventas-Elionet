namespace TrabajoFinal_Fundamentos
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipodoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_distrito = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(333, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 1);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(334, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 1);
            this.label1.TabIndex = 11;
            // 
            // cb_tipodoc
            // 
            this.cb_tipodoc.BackColor = System.Drawing.Color.Black;
            this.cb_tipodoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tipodoc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_tipodoc.ForeColor = System.Drawing.Color.White;
            this.cb_tipodoc.FormattingEnabled = true;
            this.cb_tipodoc.Items.AddRange(new object[] {
            "DNI",
            "CARNET DE EXTRANJERÍA"});
            this.cb_tipodoc.Location = new System.Drawing.Point(333, 64);
            this.cb_tipodoc.Name = "cb_tipodoc";
            this.cb_tipodoc.Size = new System.Drawing.Size(401, 29);
            this.cb_tipodoc.TabIndex = 1;
            this.cb_tipodoc.Text = "TIPO DE DOCUMENTO";
            this.cb_tipodoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Black;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.White;
            this.txt_nombre.Location = new System.Drawing.Point(332, 185);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(402, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.Text = "NOMBRE";
            this.txt_nombre.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txt_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyDown);
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(333, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 1);
            this.label4.TabIndex = 17;
            // 
            // txt_psw
            // 
            this.txt_psw.BackColor = System.Drawing.Color.Black;
            this.txt_psw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_psw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_psw.ForeColor = System.Drawing.Color.White;
            this.txt_psw.Location = new System.Drawing.Point(331, 545);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(402, 20);
            this.txt_psw.TabIndex = 9;
            this.txt_psw.Text = "CONTRASEÑA";
            this.txt_psw.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txt_psw.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(333, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 1);
            this.label5.TabIndex = 21;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.Black;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.White;
            this.txt_apellido.Location = new System.Drawing.Point(332, 245);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(402, 20);
            this.txt_apellido.TabIndex = 4;
            this.txt_apellido.Text = "APELLIDO";
            this.txt_apellido.Enter += new System.EventHandler(this.textBox3_Enter);
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            this.txt_apellido.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(333, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 1);
            this.label6.TabIndex = 19;
            // 
            // txt_dir
            // 
            this.txt_dir.BackColor = System.Drawing.Color.Black;
            this.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dir.ForeColor = System.Drawing.Color.White;
            this.txt_dir.Location = new System.Drawing.Point(333, 485);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(402, 20);
            this.txt_dir.TabIndex = 8;
            this.txt_dir.Text = "DIRECCIÓN";
            this.txt_dir.Enter += new System.EventHandler(this.textBox5_Enter);
            this.txt_dir.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(334, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 1);
            this.label8.TabIndex = 23;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.Black;
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.ForeColor = System.Drawing.Color.White;
            this.txt_dni.Location = new System.Drawing.Point(332, 125);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(402, 20);
            this.txt_dni.TabIndex = 2;
            this.txt_dni.Text = "N° DEL DOCUMENTO";
            this.txt_dni.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txt_dni.Enter += new System.EventHandler(this.textBox4_Enter);
            this.txt_dni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dni_KeyDown);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            this.txt_dni.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label7.Location = new System.Drawing.Point(452, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 33);
            this.label7.TabIndex = 26;
            this.label7.Text = "REGISTRO ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TrabajoFinal_Fundamentos.Properties.Resources.logn_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(331, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabajoFinal_Fundamentos.Properties.Resources.close1;
            this.pictureBox2.Location = new System.Drawing.Point(771, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(809, 268);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.Black;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.White;
            this.txt_correo.Location = new System.Drawing.Point(332, 365);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(402, 20);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.Text = "CORREO";
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(333, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 1);
            this.label9.TabIndex = 33;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.Black;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.White;
            this.txt_telefono.Location = new System.Drawing.Point(332, 305);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(402, 20);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.Text = "TELEFONO";
            this.txt_telefono.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txt_telefono.Enter += new System.EventHandler(this.textBox8_Enter);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(333, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 1);
            this.label10.TabIndex = 32;
            // 
            // cb_distrito
            // 
            this.cb_distrito.BackColor = System.Drawing.Color.Black;
            this.cb_distrito.DropDownHeight = 125;
            this.cb_distrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_distrito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_distrito.ForeColor = System.Drawing.Color.White;
            this.cb_distrito.FormattingEnabled = true;
            this.cb_distrito.IntegralHeight = false;
            this.cb_distrito.Items.AddRange(new object[] {
            "Ancón",
            "Ate",
            "Barranco",
            "Breña",
            "Callao",
            "Carabayllo",
            "Cercado de Lima",
            "Chaclacayo",
            "Chorrillos",
            "Cieneguilla",
            "Comas",
            "El agustino",
            "Independencia",
            "Jesús maría",
            "La molina",
            "La victoria",
            "Lince",
            "Los olivos",
            "Lurigancho",
            "Lurín",
            "Magdalena del mar",
            "Miraflores",
            "Pachacámac",
            "Pucusana",
            "Pueblo libre",
            "Puente piedra",
            "Punta hermosa",
            "Punta negra",
            "Rímac",
            "San bartolo",
            "San borja",
            "San isidro",
            "San Juan de Lurigancho",
            "San Juan de Miraflores",
            "San Luis",
            "San Martin de Porres",
            "San Miguel",
            "Santa Anita",
            "Santa María del Mar",
            "Santa Rosa",
            "Santiago de Surco",
            "Surquillo",
            "Villa el Salvador",
            "Villa Maria del Triunfo"});
            this.cb_distrito.Location = new System.Drawing.Point(332, 425);
            this.cb_distrito.Name = "cb_distrito";
            this.cb_distrito.Size = new System.Drawing.Size(401, 29);
            this.cb_distrito.TabIndex = 7;
            this.cb_distrito.Text = "DISTRITO";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(334, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 1);
            this.label12.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(333, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(401, 1);
            this.label11.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(334, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(401, 1);
            this.label13.TabIndex = 38;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 647);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_distrito);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipodoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipodoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_distrito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}