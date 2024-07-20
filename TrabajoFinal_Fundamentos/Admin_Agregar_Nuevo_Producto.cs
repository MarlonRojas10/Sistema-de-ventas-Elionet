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
    public partial class Admin_Agregar_Nuevo_Producto : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Admin_Agregar_Nuevo_Producto()
        {
            InitializeComponent();
        }
        private string codigo_Producto()
        {
            Random rnd = new Random();
            string id_producto = rnd.Next(999, 9999).ToString();

            while (cn.Consulta_codigo_Producto(id_producto) == 1)
            {
                id_producto = rnd.Next(999, 9999).ToString();
            }

            return id_producto;
        }
        private void Agregar_Nuevo_Producto_Load(object sender, EventArgs e)
        {
            cod_producto.Text = codigo_Producto();
        }
        void Limpiar()
        {
            cod_producto.Text = "";
            cbMarca.Text = "";
            cb_producto.Text = "";
            text_descripcion.Text = "";
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (cbMarca.Text != "" && cb_producto.Text != "" && text_descripcion.Text != "")
            {
                cn.Agregar_Producto(cod_producto.Text, cbMarca.Text, cb_producto.Text, text_descripcion.Text);
                MessageBox.Show("Ingeso de nuevo producto con exito.");
                Limpiar();
                cod_producto.Text = codigo_Producto();
            }
            else
            {
                Error_Registro frm = new Error_Registro("Faltan rellenar campos para añadir el producto");
                frm.ShowDialog();   
                
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
