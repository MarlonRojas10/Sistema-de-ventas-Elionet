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
    public partial class Modificar_Stock_Reposicion : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public Modificar_Stock_Reposicion(string id)
        {
            InitializeComponent();
            codprod.Text = id;  
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cn.Modificar_Stock_Reposicion(codprod.Text, numericUpDown1.Value.ToString());
            MessageBox.Show("Actualización de stock de reposición completada");
        }
    }
}
