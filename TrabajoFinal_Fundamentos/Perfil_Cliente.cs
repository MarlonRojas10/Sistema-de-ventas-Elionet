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
using System.Data.SqlClient;


namespace TrabajoFinal_Fundamentos
{
    public partial class Perfil_Cliente : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        public string numero_dni="";
        public int foto;
        public Perfil_Cliente(string dni)
        {
            InitializeComponent();
            numero_dni = dni;
        }

        private void Perfil_Usuario_Load(object sender, EventArgs e)
        {
            if (cn.Usuario_Sin_Foto(cn.getCodigo_DNI(numero_dni)) == 1)
            {
                iconPictureCircular1.SizeMode = PictureBoxSizeMode.StretchImage;
                cn.Mostrar_Imagen_Perfil(cn.getCodigo_DNI(numero_dni), iconPictureCircular1);
            }
           
            
            label_dni.Text = numero_dni;
            DataTable dt = new DataTable();
            dt=cn.busqueda_Clientes("DNI", numero_dni);
            label_nombre.Text = dt.Rows[0]["NOMBRE_CLIENTE"].ToString().TrimEnd();
            label_apellido.Text = dt.Rows[0]["APELLIDO_CLIENTE"].ToString().TrimEnd();
            label_direccion.Text = dt.Rows[0]["DIRECCION_CLIENTE"].ToString().TrimEnd();
            label_telefono.Text = dt.Rows[0]["TELEFONO_CLIENTE"].ToString().TrimEnd();
            label_correo.Text = dt.Rows[0]["CORREO_CLIENTE"].ToString().TrimEnd();
            label_distrito.Text = dt.Rows[0]["DISTRITO_CLIENTE"].ToString().TrimEnd();
            label_codigo.Text = dt.Rows[0]["ID_CLIENTE"].ToString().TrimEnd();
        }

        private void label_apellido_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label_apellido_Click_1(object sender, EventArgs e)
        {

        }

        private void label_direccion_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void iconPictureCircular1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            DialogResult result = ofd.ShowDialog();
           


            if (result == DialogResult.OK)
            {
                Foto_Perfil_Cliente frm = new Foto_Perfil_Cliente(ofd.FileName,cn.getCodigo_DNI(numero_dni));
                frm.ShowDialog();
                if (frm.okey == 1)
                {
                    iconPictureCircular1.IconChar = FontAwesome.Sharp.IconChar.None;
                    iconPictureCircular1.Image = Image.FromFile(ofd.FileName);
                    iconPictureCircular1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
               
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureCircular1_MouseHover(object sender, EventArgs e)
        {
            iconPictureCircular1.BackColor = Color.White;   
            iconPictureCircular1.SizeMode=PictureBoxSizeMode.CenterImage;
            iconPictureCircular1.IconSize = 70;
            iconPictureCircular1.IconColor= Color.Black;
            iconPictureCircular1.IconChar = FontAwesome.Sharp.IconChar.Pen;

            

        }

        private void iconPictureCircular1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureCircular1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if (cn.Usuario_Sin_Foto(cn.getCodigo_DNI(numero_dni)) == 1)
            {
                iconPictureCircular1.IconChar = FontAwesome.Sharp.IconChar.None;
                cn.Mostrar_Imagen_Perfil(cn.getCodigo_DNI(numero_dni), iconPictureCircular1);
            }
            else
            {
                iconPictureCircular1.SizeMode = PictureBoxSizeMode.CenterImage;
                iconPictureCircular1.BackColor = Color.FromArgb(25,25,25) ;
                iconPictureCircular1.IconSize = 180;
                iconPictureCircular1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
                iconPictureCircular1.IconColor = Color.White;
            }

        }

        private void label40_Click(object sender, EventArgs e)
        {
            Modificar_Info_Cliente frm=new Modificar_Info_Cliente(cn.getCodigo_DNI(numero_dni));
            frm.ShowDialog();
            DataTable dt = new DataTable();
            dt = cn.busqueda_Clientes("DNI", numero_dni);
            label_nombre.Text = dt.Rows[0]["NOMBRE_CLIENTE"].ToString().TrimEnd();
            label_apellido.Text = dt.Rows[0]["APELLIDO_CLIENTE"].ToString().TrimEnd();
            label_direccion.Text = dt.Rows[0]["DIRECCION_CLIENTE"].ToString().TrimEnd();
            label_telefono.Text = dt.Rows[0]["TELEFONO_CLIENTE"].ToString().TrimEnd();
            label_correo.Text = dt.Rows[0]["CORREO_CLIENTE"].ToString().TrimEnd();
            label_distrito.Text = dt.Rows[0]["DISTRITO_CLIENTE"].ToString().TrimEnd();
            label_codigo.Text = dt.Rows[0]["ID_CLIENTE"].ToString().TrimEnd();
        }
    }
}
