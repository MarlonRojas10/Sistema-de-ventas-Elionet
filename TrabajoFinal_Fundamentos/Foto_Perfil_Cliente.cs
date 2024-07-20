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
    public partial class Foto_Perfil_Cliente : Form
    {
        ConexionSQLN cn=new ConexionSQLN(); 
        public int okey { get; set; }
        public string id { get; set; }

        public Foto_Perfil_Cliente(string direccion,string id_cliente)
        {
            InitializeComponent();
            pictureBox1.Image=Image.FromFile(direccion);
            okey = 0;
            id = id_cliente;
        }

        private void Foto_Perfil_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (cn.Usuario_Sin_Foto(id) == 0) { 
                cn.Insertar_Foto_Perfil(pictureBox1, id); }
            else
            {
                cn.Actualizar_Foto(id, pictureBox1);
            }
            this.okey = 1;
            this.Hide();
        }
    }
}
