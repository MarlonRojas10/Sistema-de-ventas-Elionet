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
    public partial class Admi_Grafico_Compras : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        int cont = 0;
        int cont1 = 0;
        int cont2 = 0;
        public Admi_Grafico_Compras()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            dataGridView1.DataSource = cn.ReportedeMontodeCompraProducto();
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
            dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";
            chart1.Visible = true;
        }

        private void Admi_Grafico_Compras_Load(object sender, EventArgs e)
        {
            DataTable dt = cn.ReportedeMontodeCompraProducto();

            dataGridView1.DataSource = cn.ReportedeMontodeCompraProducto();

            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
            dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE COMPRA";

            chart1.Titles.Add("Montos acumulados por las Compras");
            foreach (DataRow row in dt.Rows)
            {
                Series series = chart1.Series.Add(row["NOMBRE_PRODUCTO"].ToString());
                series.Points.Add(Convert.ToDouble(row["MONTO_COMPRA"].ToString()));
                series.Label = (row["MONTO_COMPRA"].ToString());
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (chart2.Visible == false && cont == 0)
            {
                chart1.Visible = false;
                chart3.Visible = false;
                chart2.Visible = true;
                chart4.Visible = false;
                DataTable dt = cn.ReportedeCantidaddeProductoComprados();
                dataGridView1.DataSource= cn.ReportedeCantidaddeProductoComprados();
                dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
                dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE COMPRA";

                chart2.Titles.Add("Producto más Comprados");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart2.Series.Add(row["NOMBRE_PRODUCTO"].ToString());
                    series.Points.Add(Convert.ToDouble(row["CANTIDAD"].ToString()));
                    series.Label = (row["CANTIDAD"].ToString());
                }
                cont++;
            }
            else if (cont > 0)
            {
                chart1.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                dataGridView1.DataSource = cn.ReportedeCantidaddeProductoComprados();
                dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
                dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE COMPRA";
                chart2.Visible = true;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (chart3.Visible == false && cont1 == 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart4.Visible = false;
                chart3.Visible = true;
                DataTable dt = cn.ReportedeMontodeCompraMarca();
                dataGridView1.DataSource = cn.ReportedeMontodeCompraMarca();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE COMPRA";

                chart3.Titles.Add("Montos acumulados por las Compras");
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
                dataGridView1.DataSource = cn.ReportedeMontodeCompraMarca();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE COMPRA";
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
                DataTable dt = cn.ReportedeCantidaddeMarcaCompradas();
                dataGridView1.DataSource = cn.ReportedeCantidaddeMarcaCompradas();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE COMPRA";

                chart4.Titles.Add("Marcas más Compradas");
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
                dataGridView1.DataSource = cn.ReportedeCantidaddeMarcaCompradas();
                dataGridView1.Columns["MARCA_PRODUCTO"].Width = 120;
                dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD DE COMPRA";
                chart4.Visible = true;
            }
        }
    }
}
