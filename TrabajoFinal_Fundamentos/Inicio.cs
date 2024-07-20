using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_Fundamentos
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
      
            InitializeComponent();
            
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor= Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
  


        }

        private void Inicio_Leave(object sender, EventArgs e)
        {
        }

        private void Inicio_Deactivate(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
