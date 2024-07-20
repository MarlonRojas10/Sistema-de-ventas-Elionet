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
    public partial class Admi_Visualizar_Compras : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public Admi_Visualizar_Compras()
        {
            InitializeComponent();
        }

        private void Visualizar_Compras_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ListaCompra();
            dataGridView1.Columns["ID_COMPRA"].Width = 150;
            dataGridView1.Columns["ID_PROVEEDOR"].Width = 150;
            dataGridView1.Columns["NUMERO_DOCUMENTO"].Width = 200;
            dataGridView1.Columns["MONTO_TOTAL"].Width = 150;
            dataGridView1.Columns["FECHA_COMPRA"].Width = 200;
      
           
            dataGridView1.Columns["Detalle"].DisplayIndex = 5;
         
            dataGridView1.Columns["ID_COMPRA"].HeaderText = "ID COMPRA";
            dataGridView1.Columns["ID_PROVEEDOR"].HeaderText = "ID PROVEEDOR";
            dataGridView1.Columns["NUMERO_DOCUMENTO"].HeaderText = "DNI DEL PROVEEDOR";
            dataGridView1.Columns["MONTO_TOTAL"].HeaderText = "MONTO TOTAL";
            dataGridView1.Columns["FECHA_COMPRA"].HeaderText = "FECHA DE COMPRA";
            if (dataGridView1.Rows.Count == 0)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_COMPRA"].Value).ToString();

                BoletaCompra frm = new BoletaCompra(id);
                frm.Show();
            }
        }
    }
}
