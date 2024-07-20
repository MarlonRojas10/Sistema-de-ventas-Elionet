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
    public partial class Salida : Form
    {
        public int exit { get; set; }
        public Salida()
        {
            InitializeComponent();
            exit = 0;
        }

        private void btn2_MouseMove(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.Blue;
            btn2.IconColor = Color.White;
            btn2.ForeColor= Color.White;    
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor= Color.White;
            btn2.IconColor = Color.Black;
            btn2.ForeColor = Color.Black;
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.Red;
            btn1.IconColor = Color.White;
            btn1.ForeColor = Color.White;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor= Color.White;
            btn1.IconColor = Color.Black;
            btn1.ForeColor = Color.Black;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void Salida_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.exit = 2;
        }
    }
}
