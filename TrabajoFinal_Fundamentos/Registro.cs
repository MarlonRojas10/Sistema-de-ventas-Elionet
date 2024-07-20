using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocios;
using System.Text.RegularExpressions;
namespace TrabajoFinal_Fundamentos
{
    public partial class Registro : Form
    {
        ErrorProvider error = new ErrorProvider();
        ConexionSQLN cn = new ConexionSQLN();
        public Registro()
        {
            InitializeComponent();
           
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Focus();
        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE")
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.White;

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "APELLIDO")
            {
                txt_apellido.Text = "";
                txt_apellido.ForeColor = Color.White;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txt_psw.Text == "CONTRASEÑA")
            {
                txt_psw.Text = "";
                txt_psw.ForeColor = Color.White;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (txt_dir.Text == "DIRECCIÓN")
            {
                txt_dir.Text = "";
                txt_dir.ForeColor = Color.White;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (txt_dir.Text == "")
            {
                txt_dir.Text = "DIRECCIÓN";
                txt_dir.ForeColor = Color.White;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txt_psw.Text == "")
            {
                txt_psw.Text = "CONTRASEÑA";
                txt_psw.ForeColor = Color.White;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "")
            {
                txt_apellido.Text = "APELLIDO";
                txt_apellido.ForeColor = Color.White;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE";
                txt_nombre.ForeColor = Color.White;

            }
        }

        private void textpsw_Leave(object sender, EventArgs e)
        {

        }

        private void textNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNAME_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textNAME_Enter(object sender, EventArgs e)
        {

        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (txt_dni.Text == "N° DEL DOCUMENTO")
            {
                txt_dni.Text = "";
                txt_dni.ForeColor = Color.White;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txt_dni.Text == "")
            {
                txt_dni.Text = "N° DEL DOCUMENTO";
                txt_dni.ForeColor = Color.White;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int cont1 = 0;

            if (cb_tipodoc.Text != "" && txt_nombre.Text != "" && txt_psw.Text != "" && txt_apellido.Text != "" && txt_dni.Text != "" && txt_dir.Text != "" && txt_correo.Text != "" &&
                txt_telefono.Text != "" && cb_distrito.Text != "" && cb_tipodoc.Text != "TIPO DE DOCUMENTO" && txt_nombre.Text != "NOMBRE" && txt_psw.Text != "CONTRASEÑA" && txt_apellido.Text != "APELLIDO" &&
                txt_dni.Text != "N° DEL DOCUMENTO" && txt_dir.Text != "DIRECCIÓN" && txt_telefono.Text != "TELEFONO" && txt_correo.Text != "CORREO" && cb_distrito.Text != "DISTRITO")
            {
                if (cb_tipodoc.Text == "DNI" || cb_tipodoc.Text == "CARNET DE EXTRANJERÍA")
                {
                    if (txt_dni.Text.Length == 8)
                    {
                        if (txt_telefono.Text.Length == 9)
                        {
                            for (int i = 0; i < txt_nombre.Text.TrimEnd().Length; i++)
                            {
                                if (txt_nombre.Text[i].ToString() == " ")
                                {
                                    cont++;
                                }
                            }
                            for (int i = 0; i < cb_distrito.Items.Count; i++)
                            {
                                if (cb_distrito.Items[i].ToString() == cb_distrito.Text.TrimEnd())
                                {
                                    cont1++;
                                }
                            }
                            if (cont == 0)
                            {
                                if (cont1 > 0)
                                {
                                    if (txt_psw.Text.Length >= 8 && txt_psw.Text.Length <= 12)
                                    {
                                        if (cn.consultaregistrodni(txt_dni.Text) != 1)
                                        {
                                            Random rnd = new Random();
                                            string id = rnd.Next(999, 9999).ToString();
                                            while (cn.Codigo_Repetido(id) == 1)
                                            {
                                                id = rnd.Next(999, 9999).ToString();
                                            }

                                            cn.registrarCliente(id, cb_tipodoc.Text.TrimEnd(), txt_dni.Text.TrimEnd(), txt_nombre.Text.TrimEnd(), txt_apellido.Text.TrimEnd(), txt_telefono.Text.TrimEnd(), txt_correo.Text.TrimEnd(), cb_distrito.Text.TrimEnd(), txt_dir.Text.TrimEnd(), txt_psw.Text.TrimEnd());
                                            Form1 form = new Form1();
                                            form.ShowDialog();
                                            this.Close();
                                        }
                                        else
                                        {
                                            Error_Registro frm = new Error_Registro("El usuario ya ha sido registrado");
                                            frm.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        Error_Registro frm = new Error_Registro("La contraseña debe poseer entre 8 a 12 caracteres.");
                                        frm.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Error_Registro frm = new Error_Registro("El distrito ingresado no concuerda con los elementos de la lista");
                                    frm.ShowDialog();
                                }
                            }
                            else
                            {
                                Error_Registro frm = new Error_Registro("Ingrese solo un nombre");
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            Error_Registro frm = new Error_Registro("El número telefónico debe tener 9 dígitos");
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        Error_Registro frm = new Error_Registro("El número de DNI debe tener 8 dígitos");
                        frm.ShowDialog();
                    }
                }
                else
                {
                    Error_Registro frm = new Error_Registro("Seleccione tipo de documentos de la lista");
                    frm.ShowDialog();
                }
            }
            else
            {
                Error_Registro frm = new Error_Registro("Faltan Campos por Rellenar");
                frm.ShowDialog();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "TELEFONO")
            {
                txt_telefono.Text = "";
                txt_telefono.ForeColor = Color.White;

            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "CORREO")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.White;

            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "CORREO";
                txt_correo.ForeColor = Color.White;

            }
            if (!ValidarEmail(txt_correo.Text) && txt_correo.Text != "CORREO")
            {
                error.SetError(txt_correo, "Correo no valido");
            }
            else
            {
                error.Clear();
            }
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "TELEFONO";
                txt_telefono.ForeColor = Color.White;

            }
        }
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public static bool soloTexto(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
           
            else
            {
                e.Handled = false;
                return false;
            }
        }

        public static bool ValidarEmail(string correo)
        {
            return correo!=null && Regex.IsMatch(correo,@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
        {

        }
     
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida=soloNumeros(e);
            if (!valida) error.SetError(txt_dni, "Solo números");
            else { error.Clear(); }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = soloNumeros(e);
            if (!valida) error.SetError(txt_telefono, "Solo números");
            else { error.Clear(); }
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = soloTexto(e);
            if (valida) error.SetError(txt_nombre, "Solo letras");
            else { error.Clear(); }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = soloTexto(e);
            if (valida) error.SetError(txt_apellido, "Solo letras");
            else { error.Clear(); }
        }
    }
}
