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
    public partial class Admi_ListaProductos : Form
    {
      
      
        ConexionSQLN cn=new ConexionSQLN();
        public Admi_ListaProductos()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.Lista_Producto();
            dataGridView2.DataSource = cn.RetornarCodigosdeProductoconStockbajo();
         

        }

        private void Admi_ListaProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.Lista_Producto();
           
            dataGridView1.Columns["ID_PRODUCTO"].Width = 60;
            dataGridView1.Columns["MARCA_PRODUCTO"].Width = 100;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 100;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width =170;
            dataGridView1.Columns["STOCK_INICIAL"].Width = 95;
            dataGridView1.Columns["STOCK_ACTUAL"].Width =95;
            dataGridView1.Columns["STOCK_REPOSICION"].Width =95;
            dataGridView1.Columns["PRECIO_VENTA"].Width = 80;
            dataGridView1.Columns["Editar"].Width = 80;
            dataGridView1.Columns["ID_PRODUCTO"].DisplayIndex = 0;
            dataGridView1.Columns["MARCA_PRODUCTO"].DisplayIndex = 1;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].DisplayIndex = 2;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].DisplayIndex = 3;
            dataGridView1.Columns["STOCK_INICIAL"].DisplayIndex = 4;
            dataGridView1.Columns["STOCK_ACTUAL"].DisplayIndex = 5;
            dataGridView1.Columns["STOCK_REPOSICION"].DisplayIndex = 6;
            dataGridView1.Columns["PRECIO_VENTA"].DisplayIndex = 7;
            dataGridView1.Columns["ID_PRODUCTO"].HeaderText = "ID";
            dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["STOCK_INICIAL"].HeaderText = "STOCK I";
            dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";
            dataGridView1.Columns["STOCK_ACTUAL"].HeaderText = "STOCK A";
            dataGridView1.Columns["STOCK_REPOSICION"].HeaderText = "STOCK R";
            dataGridView2.Columns["ID_PRODUCTO"].Width = 135;
            dataGridView2.Columns["ID_PRODUCTO"].HeaderText = "ID";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
        

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && (comboBox2.Text == "" || (comboBox2.Text == "VACIO"))&& comboBox1.Text!="VACIO")
            {
                dataGridView1.DataSource = cn.Filtromarcaadmin(comboBox1.Text, "", "", "", "", "", "", "");
            }
            else if ((comboBox1.Text == "" || comboBox1.Text == "VACIO") && comboBox2.Text != "" && comboBox2.Text!="VACIO")
            {
                dataGridView1.DataSource = cn.filtro_nombreadmin(comboBox2.Text, "", "", "", "", "", "", "", "", "");
            }
            else if(comboBox1.Text!=""&& comboBox2.Text != "" && comboBox1.Text!="VACIO" && comboBox2.Text!="VACIO")
            {
                dataGridView1.DataSource = cn.filtro_marca_nombreadmin(comboBox1.Text, "", "", "", "", "", "", "", comboBox2.Text, "", "", "", "", "", "", "", "", "");
            }
            else if((comboBox1.Text == "" && comboBox2.Text == "")|| (comboBox1.Text == "VACIO" && comboBox2.Text == "VACIO"))
            {
                dataGridView1.DataSource = cn.Lista_Producto();
            }

            dataGridView1.Columns["ID_PRODUCTO"].DisplayIndex = 0;
            dataGridView1.Columns["MARCA_PRODUCTO"].DisplayIndex = 1;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].DisplayIndex = 2;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].DisplayIndex = 3;
            dataGridView1.Columns["STOCK_INICIAL"].DisplayIndex = 4;
            dataGridView1.Columns["STOCK_ACTUAL"].DisplayIndex = 5;
            dataGridView1.Columns["STOCK_REPOSICION"].DisplayIndex = 6;
            dataGridView1.Columns["PRECIO_VENTA"].DisplayIndex = 7;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PRODUCTO"].Value).ToString();
                Modificar_Stock_Reposicion frm = new Modificar_Stock_Reposicion(id);
                frm.ShowDialog();
                dataGridView1.DataSource = cn.Lista_Producto();
                dataGridView2.DataSource = cn.RetornarCodigosdeProductoconStockbajo();
            }
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
           
            exportaraexcel(dataGridView1);
            descarga.Text = "Se realizo la descarga de la tabla";
        }
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;
            for(int i = 2; i < tabla.Columns.Count; i++)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = tabla.Columns[i].Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                for (int i = 2; i < tabla.Columns.Count; i++)
                {
                    
                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[tabla.Columns[i].Name].Value;
    
                }

            }
            excel.Columns[1].AutoFit();
            excel.Columns[2].AutoFit();
            excel.Columns[3].AutoFit();
            excel.Columns[4].AutoFit();
            excel.Columns[5].AutoFit();
           
            excel.Visible = true;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }
    }
}
