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
    public partial class BoletaCompra : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        string idcompra;
        public BoletaCompra(string id)
        {
            InitializeComponent();
            idcompra = id;  
        }

        private void BoletaCompra_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.MostrarTablaDetalle_Comprar(idcompra);
            dataGridView1.Columns["ID_DETALLE_COMPRA"].HeaderText = "ID";
            dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO V";
            dataGridView1.Columns["PRECIO_COMPRA"].HeaderText = "PRECIO C";
            dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
            dataGridView1.Columns["MONTO"].HeaderText = "MONTO";
            dataGridView1.Columns["ID_DETALLE_COMPRA"].Width = 53;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width = 208;
            dataGridView1.Columns["PRECIO_VENTA"].Width = 100;
            dataGridView1.Columns["MARCA_PRODUCTO"].Width = 90;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 110;
            dataGridView1.Columns["PRECIO_COMPRA"].Width = 100;
            dataGridView1.Columns["MONTO"].Width = 80;
            total.Text = cn.precio_total_compraadmin(idcompra).ToString();
            
        }
    }
}
