using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace TrabajoFinal_Fundamentos
{
    
    public partial class frmListadeProductos : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        int active_marca { get;set;}
        int active_producto { get; set; }
        int active_precio { get; set; }
        ErrorProvider errorProvider { get; set; }
        public frmListadeProductos()
        {

            InitializeComponent();
            autocompletar();
            active_marca = 0;
            active_producto = 0;
            active_precio = 0;
            errorProvider = new ErrorProvider();    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmListadeProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.Tabla_Productos_Clientes();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 377;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns["ID_PRODUCTO"].HeaderText = "ID";
            dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["STOCK_ACTUAL"].HeaderText = "CANTIDAD";
            dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";

        }
        private void autocompletar()
        {
            AutoCompleteStringCollection lista=new AutoCompleteStringCollection();
            for(int i = 0; i < cn.Lista_Clientes().Rows.Count; i++)
            {
                lista.Add(cn.Lista_Clientes().Rows[i]["NOMBRE_CLIENTE"].ToString());
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_marca_Click_1(object sender, EventArgs e)
        {
         
            if (active_marca == 0)
            {
                btn_producto.Location = new System.Drawing.Point(930, 279);
                btn_precio.Location = new System.Drawing.Point(930, 313);
                checkedListBox1.Visible = true;
                checkedListBox2.Visible = false;
                labeliz.Visible = false;
                label_abajo.Visible = false;
                min.Visible = false;
           
                max.Visible = false;
                guion.Visible = false;
                txt_min.Visible = false;
                textmax.Visible = false;
                active_marca = 1;
                active_producto = 0;
                active_precio = 0;
                btn_marca.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
                btn_precio.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_producto.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            }
            else if (active_marca == 1)
            {
                btn_marca.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_producto.Location = new System.Drawing.Point(930, 141);
                btn_precio.Location = new System.Drawing.Point(930, 175);
                checkedListBox1.Visible = false;
                active_marca = 0;
            }
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_producto_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_producto_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btn_producto_Click_3(object sender, EventArgs e)
        {
            if (active_producto == 0)
            {
                btn_producto.Location=new System.Drawing.Point(930,141);
                checkedListBox1.Visible = false;
                checkedListBox2.Visible = true;
                labeliz.Visible = false;
                label_abajo.Visible = false;
              
                min.Visible = false;
                max.Visible = false;
                guion.Visible = false;
                txt_min.Visible = false;
                textmax.Visible = false;
                btn_precio.Location = new System.Drawing.Point(930, 363);
                active_producto = 1;
                active_marca = 0;
                active_precio = 0;
                btn_marca.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_precio.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_producto.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            }
            else if (active_producto == 1)
            {
                btn_producto.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                checkedListBox2.Visible = false;
                btn_precio.Location = new System.Drawing.Point(930, 174);
                active_producto = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont_marcas = 0;
            int cont_productos = 0;
            List<string> marcas = new List<string>();
            List<string> productos = new List<string>();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++) {

                marcas.Add(checkedListBox1.CheckedItems[i].ToString());
            }
            for (int i = checkedListBox1.CheckedItems.Count; i < 8; i++)
            {
                marcas.Add("");
            }
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {

                productos.Add(checkedListBox2.CheckedItems[i].ToString());
            }
            for (int i = checkedListBox2.CheckedItems.Count; i < 10; i++)
            {
                productos.Add("");
            }

            if (txt_min.Text != "" && textmax.Text != "" && checkedListBox2.CheckedItems.Count > 0 && checkedListBox1.CheckedItems.Count > 0 && Convert.ToDouble(txt_min.Text) < Convert.ToDouble(textmax.Text))
            {
                dataGridView1.DataSource = cn.Filtro_marca_nombre_precio(marcas.ElementAt(0), marcas.ElementAt(1), marcas.ElementAt(2), marcas.ElementAt(3),
marcas.ElementAt(4), marcas.ElementAt(5), marcas.ElementAt(6), marcas.ElementAt(7), productos.ElementAt(0), productos.ElementAt(1), productos.ElementAt(2), productos.ElementAt(3),
productos.ElementAt(4), productos.ElementAt(5), productos.ElementAt(6), productos.ElementAt(7), productos.ElementAt(8), productos.ElementAt(9), txt_min.Text, textmax.Text);
            }
            else if (txt_min.Text != "" && textmax.Text != "" && checkedListBox2.CheckedItems.Count == 0 && checkedListBox1.CheckedItems.Count > 0 && Convert.ToDouble(txt_min.Text) < Convert.ToDouble(textmax.Text))
            {
                dataGridView1.DataSource = cn.Filtro_marca_precio(marcas.ElementAt(0), marcas.ElementAt(1), marcas.ElementAt(2), marcas.ElementAt(3),
marcas.ElementAt(4), marcas.ElementAt(5), marcas.ElementAt(6), marcas.ElementAt(7),txt_min.Text,textmax.Text);
            }
            else if (txt_min.Text != "" && textmax.Text != "" && checkedListBox2.CheckedItems.Count > 0 && checkedListBox1.CheckedItems.Count == 0 && Convert.ToDouble(txt_min.Text) < Convert.ToDouble(textmax.Text))
            {
                dataGridView1.DataSource = cn.Filtro_nombre_precio(productos.ElementAt(0), productos.ElementAt(1), productos.ElementAt(2), productos.ElementAt(3),
productos.ElementAt(4), productos.ElementAt(5), productos.ElementAt(6), productos.ElementAt(7), productos.ElementAt(8), productos.ElementAt(9),txt_min.Text,textmax.Text);
            }
            else if(txt_min.Text != "" && textmax.Text != "" && checkedListBox2.CheckedItems.Count== 0 && checkedListBox1.CheckedItems.Count == 0 && Convert.ToDouble(txt_min.Text) < Convert.ToDouble(textmax.Text))
            {
                dataGridView1.DataSource = cn.Filtro_precio(txt_min.Text, textmax.Text);
            }
            else if (txt_min.Text == "" && textmax.Text == "" && checkedListBox2.CheckedItems.Count == 0 && checkedListBox1.CheckedItems.Count > 0)
            {
                dataGridView1.DataSource = cn.Filtro_marca(marcas.ElementAt(0), marcas.ElementAt(1), marcas.ElementAt(2), marcas.ElementAt(3),
marcas.ElementAt(4), marcas.ElementAt(5), marcas.ElementAt(6), marcas.ElementAt(7));
            }
            else if (txt_min.Text == "" && textmax.Text == "" && checkedListBox2.CheckedItems.Count > 0 && checkedListBox1.CheckedItems.Count == 0)
            {
                dataGridView1.DataSource = cn.Filtro_nombre(productos.ElementAt(0), productos.ElementAt(1), productos.ElementAt(2), productos.ElementAt(3),
productos.ElementAt(4), productos.ElementAt(5), productos.ElementAt(6), productos.ElementAt(7), productos.ElementAt(8), productos.ElementAt(9));
            }
            else if(txt_min.Text == "" && textmax.Text == "" && checkedListBox2.CheckedItems.Count > 0 && checkedListBox1.CheckedItems.Count > 0)
            {
                dataGridView1.DataSource = cn.Filtro_nombre_marca(marcas.ElementAt(0), marcas.ElementAt(1), marcas.ElementAt(2), marcas.ElementAt(3),
                    marcas.ElementAt(4), marcas.ElementAt(5), marcas.ElementAt(6), marcas.ElementAt(7), productos.ElementAt(0), productos.ElementAt(1), productos.ElementAt(2), productos.ElementAt(3),
                    productos.ElementAt(4), productos.ElementAt(5), productos.ElementAt(6), productos.ElementAt(7), productos.ElementAt(8), productos.ElementAt(9));
            }
            else if (checkedListBox2.CheckedItems.Count==0 && checkedListBox1.CheckedItems.Count==0 && txt_min.Text == "" && textmax.Text == "") dataGridView1.DataSource = cn.Lista_Producto();

            if(txt_min.Text !="" && textmax.Text == "")
            {
                errorProvider.SetError(textmax, "Falta rellenar el espacio máximo");
            }
            else if(txt_min.Text == "" && textmax.Text != "")
            {
                errorProvider.SetError(txt_min, "Falta rellenar el espacio mínimo");
            }
            else if (txt_min.Text != "" && textmax.Text != "") {
                 if (Convert.ToDouble(txt_min.Text) > Convert.ToDouble(textmax.Text))
                {
                    errorProvider.SetError(txt_min, "El valor mínimo no puede ser mayor al valor máximo");
                    errorProvider.SetError(textmax, "El valor máximo no puede ser menor al valor mínimo");
                }
                else
                {
                    errorProvider.Clear();
                } 
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_precio_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_precio_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_precio_Click_2(object sender, EventArgs e)
        {
            if (active_precio == 0)
            {
                btn_marca.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_producto.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                btn_precio.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
                btn_producto.Location = new System.Drawing.Point(930, 141);
                btn_precio.Location = new System.Drawing.Point(930, 174);
                checkedListBox1.Visible = false;
                checkedListBox2.Visible = false;
                labeliz.Visible = true;
                label_abajo.Visible = true;
                min.Visible = true;
                max.Visible = true;
                guion.Visible = true;
                txt_min.Visible = true;
                textmax.Visible = true;
        
                active_marca = 0;
                active_producto = 0;
                active_precio = 1;
            }
            else if (active_precio == 1)
            {
                btn_precio.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
                labeliz.Visible = false;
                label_abajo.Visible = false;
                min.Visible = false;
                max.Visible = false;
                guion.Visible = false;
                txt_min.Visible = false;
                textmax.Visible = false;
            
                active_precio = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
