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
using ExcelDataReader;
namespace TrabajoFinal_Fundamentos
{
    
    public partial class Admi_Lista_Cliente : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Admi_Lista_Cliente()
        {
            InitializeComponent();
           
        }

        private void Admi_Lista_Cliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cn.Lista_Clientes();
            dgvCliente.Columns[0].Width = 40;
            dgvCliente.Columns[1].Width = 100;
            dgvCliente.Columns[2].Width = 80;
            dgvCliente.Columns[3].Width = 100;
            dgvCliente.Columns[4].Width = 130;
            dgvCliente.Columns[5].Width = 100;
            dgvCliente.Columns[6].Width = 210;
            dgvCliente.Columns[7].Width = 100;
            dgvCliente.Columns[8].Width = 192;
            dgvCliente.Columns[0].HeaderText = "ID";
            dgvCliente.Columns[1].HeaderText = "DOCUMENTO";
            dgvCliente.Columns[2].HeaderText = "DNI";
            dgvCliente.Columns[3].HeaderText ="NOMBRE";
            dgvCliente.Columns[4].HeaderText = "APELLIDOS";
            dgvCliente.Columns[5].HeaderText = "TELEFONO";
            dgvCliente.Columns[6].HeaderText = "CORREO";
            dgvCliente.Columns[7].HeaderText = "DISTRITO";
            dgvCliente.Columns[8].HeaderText = "DIRECCION";
         


        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void autocompletar()
        {
            comboBox2.Text = "";
            List<string> lista = new List<string>();
            comboBox2.Items.Clear();    
           for(int i = 0; i < cn.Lista_Clientes().Rows.Count; i++)
            {
                if (comboBox1.Text == "NOMBRE DEL CLIENTE")
                {
                    cb_distrito.Visible = false;
                    comboBox2.Visible = true;
                    lista.Add(cn.Lista_Clientes().Rows[i]["NOMBRE_CLIENTE"].ToString());
                }
                else if(comboBox1.Text== "CODIGO DEL CLIENTE")
                {
                    cb_distrito.Visible = false;
                    comboBox2.Visible = true;
                    lista.Add(cn.Lista_Clientes().Rows[i]["ID_CLIENTE"].ToString());
                }
                else if(comboBox1.Text== "APELLIDO DEL CLIENTE")
                {
                    cb_distrito.Visible = false;
                    comboBox2.Visible = true;
                    lista.Add(cn.Lista_Clientes().Rows[i]["APELLIDO_CLIENTE"].ToString());
                }
                else if(comboBox1.Text== "DISTRITO DEL CLIENTE")
                {
                    cb_distrito.Visible = true;
                    comboBox2.Visible = false;
                }
                else if(comboBox1.Text== "NUMERO DE DNI")
                {
                    cb_distrito.Visible = false;
                    comboBox2.Visible = true;
                    lista.Add(cn.Lista_Clientes().Rows[i]["DNI_CLIENTE"].ToString());
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i+1; j < lista.Count; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        lista.RemoveAt(j);
                    }
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                comboBox2.Items.Add(lista[i]);
            }
           
          
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autocompletar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string caracteristica = "";
            string value = "";
            if (comboBox1.Text == "NOMBRE DEL CLIENTE")
            {
                caracteristica = "NOMBRE";
                value = comboBox2.Text;
            }
            else if (comboBox1.Text == "CODIGO DEL CLIENTE")
            {
                caracteristica = "ID";
                value = comboBox2.Text;
            }
            else if (comboBox1.Text == "APELLIDO DEL CLIENTE")
            {
                caracteristica = "APELLIDO";
                value = comboBox2.Text;
            }
            else if (comboBox1.Text == "DISTRITO DEL CLIENTE")
            {
                caracteristica = "DISTRITO";
                value = cb_distrito.Text;
            }
            else if(comboBox1.Text == "NUMERO DE DNI")
            {
                caracteristica = "DNI";
                value= comboBox2.Text;
            }
            dgvCliente.DataSource=cn.busqueda_Clientes(caracteristica, value);
            if (cn.cantidad_clientes(caracteristica,comboBox2.Text) < 10)
            {
                contador.Text = "0" + cn.cantidad_clientes(caracteristica, value).ToString();
            }
            else
            {
                contador.Text =cn.cantidad_clientes(caracteristica, value).ToString();
            }
        }

        private void cb_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            exportaraexcel(dgvCliente);
            descarga.Text = "Se realizó la descarga de la tabla"; 

        }
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }


            excel.Columns[1].AutoFit();
            excel.Columns[2].AutoFit();
            excel.Columns[3].AutoFit();
            excel.Columns[4].AutoFit();
            excel.Columns[5].AutoFit();
            excel.Columns[6].AutoFit();
            excel.Columns[7].AutoFit();
            excel.Columns[8].AutoFit();
            excel.Columns[9].AutoFit();
            excel.Visible = true;


        }
    }
}
