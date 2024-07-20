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
    public partial class Admi_Grafico_Clientes : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        int cont = 0;
        int cont1 = 0;
        int cont2 = 0;
        public Admi_Grafico_Clientes()
        {
            InitializeComponent();
        }

        private void Admi_Grafico_Clientes_Load(object sender, EventArgs e)
        {
            DataTable dt = cn.ReportedeMontodeCompradeCliente();
            dataGridView1.DataSource = cn.ReportedeMontodeCompradeCliente();

           
            dataGridView1.Columns["ID_CLIENTE"].Width = 50;
            dataGridView1.Columns["NOMBRE_CLIENTE"].Width = 80;
            dataGridView1.Columns["APELLIDO_CLIENTE"].Width = 90;
            dataGridView1.Columns["MONTO_COMPRA"].Width = 90;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].HeaderText = "APELLIDOS";
            dataGridView1.Columns[3].HeaderText = "MONTO";

            chart1.Titles.Add("Montos recolectados por las ventas hacia los clientes");
            foreach (DataRow row in dt.Rows)
            {
                Series series = chart1.Series.Add(row["ID_CLIENTE"].ToString());
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
                DataTable dt = cn.ReportedeMontoporDistrito();
                dataGridView1.DataSource = cn.ReportedeMontoporDistrito();
                dataGridView1.Columns["DISTRITO_CLIENTE"].Width = 120;
                dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";

                chart2.Titles.Add("Monto recolectados por distritos");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart2.Series.Add(row["DISTRITO_CLIENTE"].ToString());
                    series.Points.Add(Convert.ToDouble(row["MONTO_COMPRA"].ToString()));
                    series.Label = (row["MONTO_COMPRA"].ToString());
                }
                cont++;
            }
            else if (cont > 0)
            {
                chart1.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                dataGridView1.DataSource = cn.ReportedeCantidadeProductodeVendidos();
                dataGridView1.DataSource = cn.ReportedeMontoporDistrito();
                dataGridView1.Columns["DISTRITO_CLIENTE"].Width = 120;
                dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
                dataGridView1.Columns["MONTO_COMPRA"].Width = 191;
                dataGridView1.Columns["MONTO_COMPRA"].HeaderText = "MONTO DE VENTA";
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
                DataTable dt = cn.ReportedeCantidadporCliente();
                dataGridView1.DataSource = cn.ReportedeCantidadporCliente();
                dataGridView1.Columns["NOMBRE_CLIENTE"].Width = 120;
                dataGridView1.Columns["NOMBRE_CLIENTE"].HeaderText = "NOMBRE";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";

                chart3.Titles.Add("Cantidad de productos vendidos por cliente");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart3.Series.Add(row["NOMBRE_CLIENTE"].ToString());
                    series.Points.Add(Convert.ToDouble(row["CANTIDAD"].ToString()));
                    series.Label = (row["CANTIDAD"].ToString());
                }
                cont1++;
            }
            else if (cont1 > 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                chart4.Visible = false;
                dataGridView1.DataSource = cn.ReportedeCantidadporCliente();
                dataGridView1.Columns["NOMBRE_CLIENTE"].Width = 120;
                dataGridView1.Columns["NOMBRE_CLIENTE"].HeaderText = "NOMBRE";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
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
                DataTable dt = cn.ReporteCantidadCompraDistrito();
                dataGridView1.DataSource = cn.ReporteCantidadCompraDistrito();
                dataGridView1.Columns["DISTRITO_CLIENTE"].Width = 120;
                dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";

                chart4.Titles.Add("Cantidad de productos vendidos por distrito");
                foreach (DataRow row in dt.Rows)
                {
                    Series series = chart4.Series.Add(row["DISTRITO_CLIENTE"].ToString());
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
                dataGridView1.DataSource = cn.ReporteCantidadCompraDistrito();
                dataGridView1.Columns["DISTRITO_CLIENTE"].Width = 120;
                dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
                dataGridView1.Columns["CANTIDAD"].Width = 191;
                dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
                chart4.Visible = true;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            dataGridView1.DataSource = cn.ReportedeMontodeCompradeCliente();
            dataGridView1.Columns["ID_CLIENTE"].Width = 50;
            dataGridView1.Columns["NOMBRE_CLIENTE"].Width = 80;
            dataGridView1.Columns["APELLIDO_CLIENTE"].Width = 90;
            dataGridView1.Columns["MONTO_COMPRA"].Width = 90;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].HeaderText = "APELLIDOS";
            dataGridView1.Columns[3].HeaderText = "MONTO";
            chart1.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
