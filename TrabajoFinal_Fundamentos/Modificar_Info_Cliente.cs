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
    public partial class Modificar_Info_Cliente : Form
    {
        string idcliente;
        ConexionSQLN cn=new ConexionSQLN(); 
        public Modificar_Info_Cliente(string id)
        {
            InitializeComponent();
            this.idcliente = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
