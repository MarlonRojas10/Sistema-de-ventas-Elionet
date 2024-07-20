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
    public partial class Admi_Reportes : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public int reporte1 { get; set; }
        public Admi_Reportes()
        {
            InitializeComponent();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Admi_Grafico_Ventas frm = new Admi_Grafico_Ventas();
            cn.EliminarPedidoconMontoNullreporte();
            frm.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Admi_Grafico_Clientes frm = new Admi_Grafico_Clientes();
            frm.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Admi_Grafico_Compras frm = new Admi_Grafico_Compras();
            cn.EliminarDetalleCompra();
            frm.ShowDialog();
        }

        private void Admi_Reportes_Load(object sender, EventArgs e)
        {
            ingresos.Text = cn.Retornartotaldelasventas().ToString();
            salida.Text = cn.Retornartotaldelascompras().ToString();
        }
    }
}
