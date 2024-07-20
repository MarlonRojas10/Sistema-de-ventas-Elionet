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
    public partial class Admi_PedidosClientes : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public Admi_PedidosClientes()
        {
            InitializeComponent();
        }

        private void Admi_PedidosClientes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cn.Lista_Clientes().Rows.Count; i++)
            {
                comboBox1.Items.Add(cn.Lista_Clientes().Rows[i]["ID_CLIENTE"].ToString());
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Detalle"].Visible = false;
            dataGridView1.Columns["Enviar"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_mensaje.Visible = false;
            DataTable dt = new DataTable();
            dt = cn.retornarcaracterísticasIDCliente(comboBox1.Text);
            label_nombre.Text = dt.Rows[0]["NOMBRE_CLIENTE"].ToString().TrimEnd();
            label_apellido.Text = dt.Rows[0]["APELLIDO_CLIENTE"].ToString().TrimEnd();
            labeldir.Text = dt.Rows[0]["DIRECCION_CLIENTE"].ToString().TrimEnd();
            labeltel.Text = dt.Rows[0]["TELEFONO_CLIENTE"].ToString().TrimEnd();
            label_correo.Text = dt.Rows[0]["CORREO_CLIENTE"].ToString().TrimEnd();
            label_distrito.Text = dt.Rows[0]["DISTRITO_CLIENTE"].ToString().TrimEnd();
            labeldoc.Text = dt.Rows[0]["DOCUMENTO_CLIENTE"].ToString().TrimEnd();
            label_dni.Text = dt.Rows[0]["DNI_CLIENTE"].ToString().TrimEnd();
            dataGridView1.DataSource = cn.MostrarPedidosClientes(comboBox1.Text);
            dataGridView1.Columns["ID_PEDIDO"].HeaderText = "ID";
            dataGridView1.Columns["DISTRITO_CLIENTE"].HeaderText = "DISTRITO";
            dataGridView1.Columns["DIRECCION_CLIENTE"].HeaderText = "DIRECCION";
            dataGridView1.Columns["TIPO_ENVIO"].HeaderText = "TIPO DE ENVIO";
            dataGridView1.Columns["MONTO"].HeaderText = "MONTO";
            dataGridView1.Columns["FECHA_REGISTRO"].HeaderText = "FECHA";
            dataGridView1.Columns["ESTADO"].HeaderText = "ESTADO";
            dataGridView1.Columns["ID_PEDIDO"].DisplayIndex =0;
            dataGridView1.Columns["DISTRITO_CLIENTE"].DisplayIndex =1;
            dataGridView1.Columns["DIRECCION_CLIENTE"].DisplayIndex = 2;
            dataGridView1.Columns["TIPO_ENVIO"].DisplayIndex =3;
            dataGridView1.Columns["MONTO"].DisplayIndex = 4;
            dataGridView1.Columns["FECHA_REGISTRO"].DisplayIndex = 5;
            dataGridView1.Columns["ESTADO"].DisplayIndex =6;
            dataGridView1.Columns["Detalle"].DisplayIndex = 7;
            dataGridView1.Columns["Enviar"].DisplayIndex = 8;
            dataGridView1.Columns["ID_PEDIDO"].Width =60;
            dataGridView1.Columns["DISTRITO_CLIENTE"].Width=130;
            dataGridView1.Columns["DIRECCION_CLIENTE"].Width=183;
            dataGridView1.Columns["TIPO_ENVIO"].Width=130;
            dataGridView1.Columns["MONTO"].Width=85;
            dataGridView1.Columns["FECHA_REGISTRO"].Width=130;
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["Detalle"].Visible = false;
                dataGridView1.Columns["Enviar"].Visible = false;
                dataGridView1.DataSource = null;
                label_nohaypedidos.Visible = true;
            }
            else
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["Detalle"].Visible = true;
                dataGridView1.Columns["Enviar"].Visible = true;
                label_nohaypedidos.Visible = false;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PEDIDO"].Value).ToString();

                BoletadeVenta frm = new BoletadeVenta(id);
                frm.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Enviar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_PEDIDO"].Value).ToString();
                DialogResult dr = MessageBox.Show("Esta seguro de enviar este pedido", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes) { 
                    cn.CambiarEstadodePedido(id);
                    dataGridView1.DataSource = cn.MostrarPedidosClientes(comboBox1.Text);
                }
            }
        }
    }
}
