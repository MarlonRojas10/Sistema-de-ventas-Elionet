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
    public partial class BoletadeVenta : Form
    {
        ConexionSQLN cn=new ConexionSQLN(); 
        string id_pedido;
        public int confirmacion { get; set; }
        public BoletadeVenta(string idpedido)
        {
            InitializeComponent();
            this.id_pedido = idpedido;
            confirmacion = 0;
        }

        private void Confirmacion_Pedido_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.Mostrar_producto_comprar(id_pedido);
            dataGridView1.Columns["ID_DETALLE_PEDIDO"].HeaderText = "ID";
            dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";
            dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
            dataGridView1.Columns["SUBTOTAL"].HeaderText = "SUBTOTAL";
            dataGridView1.Columns["ID_DETALLE_PEDIDO"].Width = 53;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width = 170;
            dataGridView1.Columns["PRECIO_VENTA"].Width = 80;
            dataGridView1.Columns["MARCA_PRODUCTO"].Width = 90;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 110;
            dataGridView1.Columns["CANTIDAD"].Width = 85;
            dataGridView1.Columns["SUBTOTAL"].Width = 90;
            DataTable dt = new DataTable();
            dt = cn.Montoytipodeenviopedido(id_pedido);
            tipo_envio.Text = dt.Rows[0]["TIPO_ENVIO"].ToString().TrimEnd();
            total.Text = dt.Rows[0]["MONTO"].ToString().TrimEnd();
            if (dt.Rows[0]["TIPO_ENVIO"].ToString().TrimEnd() == "Moto")
            {
                costo_envio.Text = "10.00";
            }
            else
            {
                costo_envio.Text = "30.00";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tipo_envio_Click(object sender, EventArgs e)
        {

        }

        private void costo_envio_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
