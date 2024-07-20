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
    public partial class Login : Form
    {
  
        ConexionSQLN cn=new ConexionSQLN();
        int active { get;set;}
        public Login()
        {
      
            InitializeComponent();
            label3.Focus();
      
  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
            
        {
            this.Hide();
            Inicio i = new Inicio();
            i.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "N° DE DOCUMENTO")
            {
                textBox3.Text = "";
                textBox3.ForeColor= Color.White;    
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "N° DE DOCUMENTO";

            }
        }

        private void textpsw_Enter(object sender, EventArgs e)
        {
            if (textpsw.Text == "CONTRASEÑA")
            {
                textpsw.Text = "";
                textpsw.ForeColor = Color.White;
                textpsw.UseSystemPasswordChar = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }

        private void textpsw_Leave(object sender, EventArgs e)
        {
            if (textpsw.Text == "")
            {
                textpsw.Text = "CONTRASEÑA";
                textpsw.UseSystemPasswordChar = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro frm=new Registro();
            frm.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textpsw.Text != "" && textBox3.Text!= "N° DE DOCUMENTO" && textpsw.Text!="CONTRASEÑA")
            {
                if (textBox3.Text == "1" && textpsw.Text == "1")
                {
                   
                    Admi_Menu_Administrador frm = new Admi_Menu_Administrador();
                    frm.ShowDialog();
                }
                else if (cn.conSQL(textBox3.Text, textpsw.Text) == 1)
                {
                   
                    
                    Menu_Cliente menu = new Menu_Cliente(textBox3.Text);
                    menu.ShowDialog();
                }
                else
                {
                    Error_Registro frm = new Error_Registro("El numero de DNI del usuario o la contraseña ingresadas es incorrecto");
                    frm.ShowDialog();
                }
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textpsw.UseSystemPasswordChar == true && textpsw.Text!="CONTRASEÑA")
            {
                textpsw.UseSystemPasswordChar = false;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else if(textpsw.Text != "CONTRASEÑA")
            {
                textpsw.UseSystemPasswordChar = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textpsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textpsw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
              
                if (textBox3.Text != "" && textpsw.Text != "" && textBox3.Text != "N° DE DOCUMENTO" && textpsw.Text != "CONTRASEÑA")
                {
                    if (textBox3.Text == "1" && textpsw.Text == "1")
                    {

                        Admi_Menu_Administrador frm = new Admi_Menu_Administrador();
                        frm.ShowDialog();
                    }
                    else if (cn.conSQL(textBox3.Text, textpsw.Text) == 1)
                    {

                
                        Menu_Cliente menu = new Menu_Cliente(textBox3.Text);
                        menu.ShowDialog();
                    }
                    else
                    {
                        Error_Registro frm = new Error_Registro("El numero de DNI del usuario o la contraseña ingresadas es incorrecto");
                        frm.ShowDialog();
                    }
                }   
            } 
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                if (textBox3.Text != "" && textpsw.Text != "" && textBox3.Text != "N° DE DOCUMENTO" && textpsw.Text != "CONTRASEÑA")
                {
                    if (textBox3.Text == "1" && textpsw.Text == "1")
                    {

                        Admi_Menu_Administrador frm = new Admi_Menu_Administrador();
                        frm.ShowDialog();
                    }
                    if (cn.conSQL(textBox3.Text, textpsw.Text) == 1)
                    {

                        
                        Menu_Cliente menu = new Menu_Cliente(textBox3.Text);
                        menu.ShowDialog();
                    }
                }
            }
        }
       
    }
}
