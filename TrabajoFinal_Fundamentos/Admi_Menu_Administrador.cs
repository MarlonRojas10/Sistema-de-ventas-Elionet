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
    public partial class Admi_Menu_Administrador : Form
    {
        private Admi_Lista_Cliente frm1;
        private Admi_PedidosClientes frm2;
        private Admi_ListaProductos frm3;
        private Admi_AgregarProducto frm4;
        private IconButton currentBtn;
        private Panel leftBorederbtn;
        private int active = 0;
        public Salida salida;
        public Admi_Menu_Administrador()
        {
           
            InitializeComponent();
            leftBorederbtn = new Panel();
            leftBorederbtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorederbtn);
            salida = new Salida();
         
            frm4 = new Admi_AgregarProducto(); 
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DisableButton();
            leftBorederbtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.Home;
            iconPictureBox1.IconColor = Color.White;
            label2.Text = "Home";
            Home h = new Home();
            VentanaChiquita(h);

        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

           

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
            public static Color color3 = Color.FromArgb(96, 255, 28);
            public static Color color4 = Color.FromArgb(0, 255, 255);
            public static Color color5 = Color.FromArgb(255, 173, 0);
            public static Color color6 = Color.FromArgb(5, 195, 221);
            public static Color color7 = Color.FromArgb(255, 99, 71);
            public static Color color8 = Color.FromArgb(46, 248, 160);
        }
        private void ActivateBtn(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = Color.FromArgb(25, 25, 25);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorederbtn.BackColor = color;
                leftBorederbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorederbtn.Visible = true;
                leftBorederbtn.BringToFront();
                iconPictureBox1.IconChar = currentBtn.IconChar;
                iconPictureBox1.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
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
            frm1 = new Admi_Lista_Cliente();
            
            ActivateBtn(sender, RGBColors.color3);
            label2.Text = "Lista de Clientes Registrados";
          
            VentanaChiquita(frm1);
            active = 0;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
         
            frm2 = new Admi_PedidosClientes();
            ActivateBtn(sender, RGBColors.color1);
            label2.Text = "Pedidos de los Clientes";
          
            VentanaChiquita(frm2);
            active = 0;
           
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frm3 = new Admi_ListaProductos();
            ActivateBtn(sender, RGBColors.color2);
            label2.Text = "Lista de Productos";
         
            VentanaChiquita(frm3);
            active = 0;
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (salida.exit == 2)
            {
                Reset();
                salida.exit = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            VentanaChiquita(home);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton4_Click_2(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color5);
           
            label2.Text = "Mantenimiento Productos";
            VentanaChiquita(frm4);
            active = 0;
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color4);
            label2.Text = "Salida";

            VentanaChiquita(salida);
            active = 0;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color6);
            Admi_Visualizar_Compras frm5=new Admi_Visualizar_Compras();
            label2.Text = "Lista de Compras";
            VentanaChiquita(frm5);
            active = 0;
        }

        private void iconButton6_Click_2(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color7);
            Admi_Reportes frm6 = new Admi_Reportes();
            label2.Text = "Reportes de la tienda";
            VentanaChiquita(frm6);
            active = 0;
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color8);
            Salida frm7 = new Salida();
            label2.Text = "Salida";
            VentanaChiquita(frm7);
            active = 0;
        }
    }
}
