namespace TrabajoFinal_Fundamentos
{
    partial class frmRealizarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbTipoEntrega = new System.Windows.Forms.ComboBox();
            this.label_monto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelmonto = new System.Windows.Forms.Label();
            this.cb_descripcion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label_mensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.total_pedido = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Producto:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Marca:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Descripción:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 7;
            // 
            // cbProducto
            // 
            this.cbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
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
            this.cbProducto.Location = new System.Drawing.Point(191, 59);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 24);
            this.cbProducto.TabIndex = 9;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.Enabled = false;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cbMarca.Location = new System.Drawing.Point(191, 102);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 24);
            this.cbMarca.TabIndex = 10;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbTipoEntrega
            // 
            this.cbTipoEntrega.Enabled = false;
            this.cbTipoEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoEntrega.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEntrega.FormattingEnabled = true;
            this.cbTipoEntrega.Items.AddRange(new object[] {
            "Moto",
            "Auto"});
            this.cbTipoEntrega.Location = new System.Drawing.Point(817, 438);
            this.cbTipoEntrega.Name = "cbTipoEntrega";
            this.cbTipoEntrega.Size = new System.Drawing.Size(121, 23);
            this.cbTipoEntrega.TabIndex = 11;
            this.cbTipoEntrega.SelectedIndexChanged += new System.EventHandler(this.cbTipoEntrega_SelectedIndexChanged);
            // 
            // label_monto
            // 
            this.label_monto.AutoSize = true;
            this.label_monto.BackColor = System.Drawing.Color.White;
            this.label_monto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monto.ForeColor = System.Drawing.Color.Black;
            this.label_monto.Location = new System.Drawing.Point(221, 301);
            this.label_monto.Name = "label_monto";
            this.label_monto.Size = new System.Drawing.Size(0, 16);
            this.label_monto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cantidad:";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton2.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(72, 295);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(176, 29);
            this.iconButton2.TabIndex = 31;
            this.iconButton2.Text = "Agregar al carrito";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.labelmonto);
            this.groupBox2.Controls.Add(this.cb_descripcion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_monto);
            this.groupBox2.Controls.Add(this.cbMarca);
            this.groupBox2.Controls.Add(this.cbProducto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 355);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Pedido";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 1);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(99, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 207);
            this.label10.TabIndex = 43;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 1);
            this.label9.TabIndex = 42;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 1);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 1);
            this.label7.TabIndex = 40;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 1);
            this.label6.TabIndex = 39;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 1);
            this.label5.TabIndex = 38;
            this.label5.Text = "label5";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Location = new System.Drawing.Point(191, 184);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 23);
            this.nudCantidad.TabIndex = 36;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // labelmonto
            // 
            this.labelmonto.BackColor = System.Drawing.Color.White;
            this.labelmonto.ForeColor = System.Drawing.Color.Black;
            this.labelmonto.Location = new System.Drawing.Point(191, 224);
            this.labelmonto.Name = "labelmonto";
            this.labelmonto.Size = new System.Drawing.Size(121, 24);
            this.labelmonto.TabIndex = 35;
            this.labelmonto.Text = "0";
            this.labelmonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_descripcion
            // 
            this.cb_descripcion.Enabled = false;
            this.cb_descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_descripcion.FormattingEnabled = true;
            this.cb_descripcion.Location = new System.Drawing.Point(122, 143);
            this.cb_descripcion.Name = "cb_descripcion";
            this.cb_descripcion.Size = new System.Drawing.Size(190, 24);
            this.cb_descripcion.TabIndex = 34;
            this.cb_descripcion.SelectedIndexChanged += new System.EventHandler(this.cb_descripcion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(713, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tipo de envio:";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconButton1.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(957, 434);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(146, 29);
            this.iconButton1.TabIndex = 45;
            this.iconButton1.Text = "Agregar Pedido ";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(347, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(761, 355);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::TrabajoFinal_Fundamentos.Properties.Resources.eliminar__1_;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Width = 70;
            // 
            // label_mensaje
            // 
            this.label_mensaje.AutoSize = true;
            this.label_mensaje.BackColor = System.Drawing.Color.Black;
            this.label_mensaje.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensaje.ForeColor = System.Drawing.Color.White;
            this.label_mensaje.Location = new System.Drawing.Point(525, 220);
            this.label_mensaje.Name = "label_mensaje";
            this.label_mensaje.Size = new System.Drawing.Size(485, 44);
            this.label_mensaje.TabIndex = 47;
            this.label_mensaje.Text = "Sin productos en el carrito";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(348, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 1);
            this.label4.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(348, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(763, 1);
            this.label12.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(348, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1, 352);
            this.label17.TabIndex = 45;
            this.label17.Text = "label17";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1110, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1, 356);
            this.label21.TabIndex = 49;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(708, 469);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(403, 1);
            this.label22.TabIndex = 45;
            this.label22.Text = "label22";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(707, 426);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1, 44);
            this.label23.TabIndex = 45;
            this.label23.Text = "label23";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(1110, 423);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(1, 46);
            this.label24.TabIndex = 50;
            this.label24.Text = "label24";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(367, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(400, 1);
            this.label25.TabIndex = 52;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(451, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(227, 32);
            this.label26.TabIndex = 51;
            this.label26.Text = "Realizar Pedidos";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(483, 425);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1, 44);
            this.label27.TabIndex = 53;
            this.label27.Text = "label27";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(483, 469);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(403, 1);
            this.label28.TabIndex = 54;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(490, 440);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 16);
            this.label29.TabIndex = 55;
            this.label29.Text = "Total de pedido:";
            // 
            // total_pedido
            // 
            this.total_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_pedido.ForeColor = System.Drawing.Color.White;
            this.total_pedido.Location = new System.Drawing.Point(603, 440);
            this.total_pedido.Name = "total_pedido";
            this.total_pedido.Size = new System.Drawing.Size(98, 16);
            this.total_pedido.TabIndex = 56;
            this.total_pedido.Text = "0";
            // 
            // frmRealizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1103, 487);
            this.Controls.Add(this.total_pedido);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_mensaje);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRealizarPedidos";
            this.Text = "frmRealizarPedidos";
            this.Load += new System.EventHandler(this.frmRealizarPedidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbTipoEntrega;
        private System.Windows.Forms.Label label_monto;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label labelmonto;
        private System.Windows.Forms.ComboBox cb_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_mensaje;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label total_pedido;
    }
}