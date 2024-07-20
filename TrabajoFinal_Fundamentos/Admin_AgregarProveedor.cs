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
    public partial class Admin_AgregarProveedor : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public Admin_AgregarProveedor()
        {
            InitializeComponent();
        }
        void Limipiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Random rnd = new Random();
                string id = rnd.Next(999, 9999).ToString();
                while (cn.Consulta_codigo_Proveedor(id) == 1)
                {
                    id = rnd.Next(999, 9999).ToString();
                }
                cn.AgregarProveedor(id, textBox1.Text, textBox2.Text, comboBox1.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Agregación de Proveedo con exito.");
                Limipiar();
            }
            else
            {
                Error_Registro frm = new Error_Registro("Falta campos por rellenar");
                frm.ShowDialog();   
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_AgregarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
