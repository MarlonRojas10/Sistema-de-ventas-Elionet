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
    public partial class Admi_Lista_Codigo_Proveedor : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public string id { get; set; }
        public Admi_Lista_Codigo_Proveedor()
        {
            InitializeComponent();
            this.id = "";
        }

        private void Lista_Codigo_Proveedor_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = cn.RetornarTablaProveedor();
            dataGridView1.Columns["ID_PROVEEDOR"].Width = 60;
            dataGridView1.Columns["NOMBRE_PROVEEDOR"].Width = 120;
            dataGridView1.Columns["DOCUMENTO_PROVEEDOR"].Width = 120;
            dataGridView1.Columns["ESTADO"].Width = 95;
            dataGridView1.Columns["ID_PROVEEDOR"].HeaderText = "ID";
            dataGridView1.Columns["NOMBRE_PROVEEDOR"].HeaderText = "NOMBRE";
            dataGridView1.Columns["DOCUMENTO_PROVEEDOR"].HeaderText = "DNI";
            dataGridView1.Columns["ESTADO"].HeaderText = "ESTADO";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PROVEEDOR"].Value).ToString();

                this.id = id;
                this.Hide();
            }
        }
    }
}
