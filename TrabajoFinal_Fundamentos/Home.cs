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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Elionet-103277145772035/");

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/elion.et/");
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/931514045");
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/ElioNET20");
        }
    }
}
