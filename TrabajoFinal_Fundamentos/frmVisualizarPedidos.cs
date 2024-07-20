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
    public partial class frmVisualizarPedidos : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        string dni_cliente;
        public frmVisualizarPedidos(string dni)
        {
            InitializeComponent();
            dni_cliente = dni;
        }

        private void frmVisualizarPedidos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.MostrarPedidosClientes(cn.getCodigo_DNI(dni_cliente));
          
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 155;
            dataGridView1.Columns[3].Width = 190;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 180;
            
            dataGridView1.Columns["ID_PEDIDO"].HeaderText = "ID";
            dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
            dataGridView1.Columns["DIRECCION_CLIENTE"].HeaderText = "DIRECCION";
            dataGridView1.Columns["TIPO_ENVIO"].HeaderText = "TIPO DE ENVIO";
            dataGridView1.Columns["MONTO"].HeaderText = "MONTO";
            dataGridView1.Columns["FECHA_REGISTRO"].HeaderText = "FECHA";
            dataGridView1.Columns["ESTADO"].HeaderText = "ESTADO";
            dataGridView1.Columns["Detalle"].DisplayIndex = 7;
           
            if (dataGridView1.Rows.Count==0)
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["Detalle"].Visible = false;
                dataGridView1.DataSource = null;
                label_mensaje.Visible = true;
            }
            else
            {
                dataGridView1.RowHeadersVisible = true;
                dataGridView1.Columns["Detalle"].Visible = true;
                label_mensaje.Visible = false;
            }
     
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PEDIDO"].Value).ToString();

                BoletadeVenta frm = new BoletadeVenta(id);
                frm.Show();
            }
        }
    }
}
