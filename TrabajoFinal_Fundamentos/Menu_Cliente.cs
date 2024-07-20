using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace TrabajoFinal_Fundamentos
{
    public partial class Menu_Cliente : Form
    {
        private IconButton currentBtn;
        private Panel leftBorederbtn;
        private int active = 0;
        public Salida salida;
        public string numero_dni = "";
        private Perfil_Cliente frmperfil;
        frmRealizarPedidos frmpedidos;
        public Menu_Cliente(string dni)
        {
            InitializeComponent();
            leftBorederbtn = new Panel();
            leftBorederbtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorederbtn);
            salida = new Salida();
            numero_dni = dni;
            frmperfil = new Perfil_Cliente(dni);
            frmpedidos = new frmRealizarPedidos(numero_dni);
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            VentanaChiquita(home);
           
            
        }
        private void VentanaChiquita(Form frm)
        {
            if (active == 0)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                pictureBox2.Controls.Add(frm);
                pictureBox2.Tag = frm;
                frm.BringToFront();
                frm.Show();
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(240, 0, 6);
            public static Color color2 = Color.FromArgb(199, 36, 177);
            public static Color color3=Color.FromArgb(96, 255, 28);
            public static Color color4=Color.FromArgb(0, 255, 255);
            public static Color color5= Color.FromArgb(255, 173, 0);
        
        }
        private void ActivateBtn(object senderbtn,Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = Color.FromArgb(25, 25, 25);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign=ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorederbtn.BackColor = color;
                leftBorederbtn.Location=new Point(0,currentBtn.Location.Y);
                leftBorederbtn.Visible = true;
                leftBorederbtn.BringToFront();
                iconPictureBox1.IconChar = currentBtn.IconChar;
                iconPictureBox1.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
               
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color1);
            label2.Text = "Lista de Productos";
           
            frmListadeProductos frm = new frmListadeProductos();
            active = 0;
            VentanaChiquita(frm); 
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color2);
            label2.Text = "Realizar pedidos";
            active = 0;
            
            VentanaChiquita(frmpedidos);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color3);
            label2.Text = "Ver Pedidos Realizados";
           
            active = 0;
            frmVisualizarPedidos frm = new frmVisualizarPedidos(numero_dni);
            VentanaChiquita(frm);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color5);
            label2.Text = "Perfil del usuario";
           
            VentanaChiquita(frmperfil);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorederbtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.Home;
            iconPictureBox1.IconColor = Color.White;
            label2.Text = "Home";
            Home h=new Home();
            VentanaChiquita(h);
    
        }
     
     
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (salida.exit == 1)
            {
                Application.Exit();
            }
            else if(salida.exit == 2)
            {
                Reset();
                salida.exit = 0;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color4);
            label2.Text = "Salir de la Aplicación";

            active = 0;

            VentanaChiquita(salida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
