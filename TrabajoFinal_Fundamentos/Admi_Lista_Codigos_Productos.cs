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
    public partial class Admi_Lista_Codigos_Productos : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public string id { get; set; }
        public string marca { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public Admi_Lista_Codigos_Productos()
        {
            InitializeComponent();
            this.id = "";
            this.producto = "";
            this.marca = "";
            this.descripcion = "";
            this.precio = "";
        }

        private void Lista_Codigos_Productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.Tabla_Codigos_Productos();
              
            dataGridView1.Columns["ID_PRODUCTO"].Width = 60;
            dataGridView1.Columns["MARCA_PRODUCTO"].Width = 100;
            dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 120;
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width =230;
            dataGridView1.Columns["STOCK_ACTUAL"].Width =95;
            dataGridView1.Columns["PRECIO_VENTA"].Width = 80;
            dataGridView1.Columns["ID_PRODUCTO"].HeaderText = "ID";
            dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
            dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
            dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
            dataGridView1.Columns["STOCK_ACTUAL"].HeaderText = "STOCK A";
            dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PRODUCTO"].Value).ToString();
                string marca = dataGridView1.CurrentRow.Cells["MARCA_PRODUCTO"].Value.ToString();
                string producto = dataGridView1.CurrentRow.Cells["NOMBRE_PRODUCTO"].Value.ToString();
                string descripcion = dataGridView1.CurrentRow.Cells["DESCRIPCION_PRODUCTO"].Value.ToString();
                string precio = dataGridView1.CurrentRow.Cells["PRECIO_VENTA"].Value.ToString();
                this.id = id;
                this.marca = marca;
                this.producto = producto;
                this.descripcion = descripcion;
                this.precio = precio;
                this.Hide();
            }
        }
    }
}
