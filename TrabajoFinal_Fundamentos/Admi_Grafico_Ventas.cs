using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Negocios;
namespace TrabajoFinal_Fundamentos
{
    public partial class Admi_Grafico_Ventas : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        int cont = 0;
        int cont1 = 0;
        int cont2 = 0;
        public Admi_Grafico_Ventas()
        {
            InitializeComponent();
        }

        private void Grafico_Compras_Load(object sender, EventArgs e)
        {
            DataTable dt = cn.ReportedeMontodeventaProducto();

            dataGridView1.DataSource = cn.ReportedeMontodeventaProducto();

            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
            dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";

            chart1.Titles.Add("Montos recolectados por las Ventas");
            foreach (DataRow row in dt.Rows)
            {
                Series series = chart1.Series.Add(row["NOMBRE_PRODUCTO"].ToString());
                series.Points.Add(Convert.ToDouble(row["MONTO_COMPRA"].ToString()));
                series.Label = (row["MONTO_COMPRA"].ToString());
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (chart2.Visible == false && cont==0)
            {
                chart1.Visible = false;
                chart3.Visible = false;
                chart2.Visible = true;
                chart4.Visible = false;
                DataTable dt = cn.ReportedeCantidadeProductodeVendidos();
                dataGridView1.DataSource = cn.ReportedeCantidadeProductodeVendidos();
                dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
                dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE VENTA";

                chart2.Titles.Add("Producto más Vendidos");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart2.Series.Add(row["NOMBRE_PRODUCTO"].ToString());
                    series.Points.Add(Convert.ToDouble(row["CANTIDAD"].ToString()));
                    series.Label = (row["CANTIDAD"].ToString());
                }
                cont++;
            }
            else if (cont >0)
            {
                chart1.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                dataGridView1.DataSource = cn.ReportedeCantidadeProductodeVendidos();
                dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
                dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE VENTA";
                chart2.Visible = true;
            }
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
         
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            dataGridView1.DataSource = cn.ReportedeMontodeventaProducto();
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
            dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";
            chart1.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            if (chart3.Visible == false && cont1 == 0)
            {
                chart1.Visible = false;
                chart2.Visible=false;
                chart4.Visible = false;
                chart3.Visible = true;
                DataTable dt = cn.ReportedeMontodeventaMarca();
                dataGridView1.DataSource = cn.ReportedeMontodeventaMarca();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";

                chart3.Titles.Add("Montos recolectados por las Ventas segun Marcas");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart3.Series.Add(row["MARCA_PRODUCTO"].ToString());
                    series.Points.Add(Convert.ToDouble(row["MONTO_COMPRA"].ToString()));
                    series.Label = (row["MONTO_COMPRA"].ToString());
                }
                cont1++;
            }
            else if (cont1 > 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart4.Visible = false;
                dataGridView1.DataSource = cn.ReportedeMontodeventaMarca();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";
                chart3.Visible = true;
            }

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (chart4.Visible == false && cont2 == 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = true;
                DataTable dt = cn.ReportedeCantidaddeMarcaVendidas();
                dataGridView1.DataSource = cn.ReportedeCantidaddeMarcaVendidas();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE VENTA";

                chart4.Titles.Add("Marcas más Vendidos");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart4.Series.Add(row["MARCA_PRODUCTO"].ToString());
                    series.Points.Add(Convert.ToDouble(row["CANTIDAD"].ToString()));
                    series.Label = (row["CANTIDAD"].ToString());
                }
                cont2++;
            }
            else if (cont2 > 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                dataGridView1.DataSource = cn.ReportedeCantidaddeMarcaVendidas();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE VENTA";
                chart4.Visible = true;
            }
        }
    }
}
