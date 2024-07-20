using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using Negocios;

namespace TrabajoFinal_Fundamentos
{
    public partial class Admi_AgregarProducto : Form
    {
        ConexionSQLN cn=new ConexionSQLN();
        ErrorProvider error=new ErrorProvider();
        string id_aux;
        public int cont;
        List<string> codigos_producto = new List<string>();
        List<string> codigos_detalle_compra = new List<string>();
        public int cant_cod;
        public Admi_AgregarProducto()
        {
            InitializeComponent();
            id_aux = "";
            cont = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Admi_AgregarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Eliminar"].Visible =false;
            label_mensaje.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void cbProducto_Enter(object sender, EventArgs e)
        {
            
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbMarca_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
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
        public  bool validadcantidaddigitos(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                cant_cod++;
            }
            if (cant_cod == 4)
            {
                e.Handled = false;
                return true;
            }
            else if (cant_cod < 4)
            {
                e.Handled = true;
                return false;
            }
            else
            {
                e.Handled = false;
                return false;
            }
            
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = soloNumeros(e);
       
          
           
        }
        
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void cod_proveedor_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Admi_Lista_Codigo_Proveedor frm = new Admi_Lista_Codigo_Proveedor();
            frm.ShowDialog();
            if (frm.id != "")
            {
                cod_proveedor.Text = frm.id;
                label10.Text = cn.BuscarNombreProveedor(frm.id).TrimEnd();
                frm.Close();
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Admin_AgregarProveedor frm = new Admin_AgregarProveedor();
            frm.ShowDialog();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            Admi_Lista_Codigos_Productos frm=new Admi_Lista_Codigos_Productos();
            frm.ShowDialog();
            cod_producto.Text = frm.id;
            lbl_producto.Text = frm.producto.TrimEnd();
            lbl_marca.Text=frm.marca.TrimEnd();  
            lbl_desc.Text=frm.descripcion.TrimEnd();
            txt_precioventa.Text = frm.precio.TrimEnd();
            frm.Close();
        }
      
        private void iconButton5_Click(object sender, EventArgs e)
        {
            Admin_Agregar_Nuevo_Producto frm = new Admin_Agregar_Nuevo_Producto();
            frm.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
        
        public string generarcodigo_compra()
        {
            Random rnd = new Random();
            string id_compra = rnd.Next(999, 9999).ToString();

            while (cn.Consulta_codigo_Compra(id_compra) == 1)
            {
                id_compra = rnd.Next(999, 9999).ToString();
            }

            return id_compra;

        }
        public string generarcodigo_detalle_compra()
        {
            Random rnd = new Random();
            string id_detalle_compra = rnd.Next(999, 9999).ToString();
            while (cn.Consulta_codigo_Detalle_Compra(id_detalle_compra) == 1)
            {
                id_detalle_compra = rnd.Next(999, 9999).ToString();
            }
            return id_detalle_compra;
        }
       
        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (cod_proveedor.Text != "" && cod_producto.Text != "" && txt_precioventa.Text!="0.00" && txt_preciocompra.Text!="" && Convert.ToDouble(txt_preciocompra.Text)!=0 && Convert.ToDouble(txt_precioventa.Text)!=0)
            {
                DialogResult dr = MessageBox.Show("Esta seguro de comprar un producto a "+txt_preciocompra.Text+" soles y venderlo a un precio de venta de "+txt_precioventa.Text+" soles.","Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.RowHeadersVisible = true;
                    dataGridView1.Columns["Eliminar"].Visible = true;
                    label_mensaje.Visible = false;
                    string id_compra;
                    string id_detallecompra;

                    if (cont == 0)
                    {
                        id_aux = generarcodigo_compra();


                    }
                    id_compra = id_aux;
                    id_detallecompra = generarcodigo_detalle_compra();
                    if (cont == 0)
                    {
                        cn.AgregarCompra(id_compra, cod_proveedor.Text, cn.retornarDniProveedor(cod_proveedor.Text));
                    }
                    cn.AgregarDetalle_Compra(id_detallecompra, id_compra, cod_producto.Text, lbl_producto.Text, lbl_marca.Text, lbl_desc.Text, txt_precioventa.Text, txt_preciocompra.Text, numericUpDown1.Value.ToString(), (numericUpDown1.Value * Convert.ToInt32(txt_preciocompra.Text)).ToString());
                    dataGridView1.DataSource = cn.MostrarTablaDetalle_Comprar(id_compra);
                    dataGridView1.Columns["ID_DETALLE_COMPRA"].HeaderText = "ID";
                    dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                    dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                    dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
                    dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO V";
                    dataGridView1.Columns["PRECIO_COMPRA"].HeaderText = "PRECIO C";
                    dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
                    dataGridView1.Columns["MONTO"].HeaderText = "MONTO";
                    dataGridView1.Columns["ID_DETALLE_COMPRA"].Width = 53;
                    dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width = 230;
                    dataGridView1.Columns["PRECIO_VENTA"].Width = 100;
                    dataGridView1.Columns["MARCA_PRODUCTO"].Width = 90;
                    dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 110;
                    dataGridView1.Columns["PRECIO_COMPRA"].Width = 100;
                    dataGridView1.Columns["MONTO"].Width = 90;
                    dataGridView1.Columns["Eliminar"].DisplayIndex = 8;
                    codigos_producto.Add(cod_producto.Text);
                    cont = 1;
                }
            }
            if (cod_proveedor.Text == "" && cod_producto.Text == "" && txt_precioventa.Text == "" && txt_preciocompra.Text == "")
            {
                Error_Registro error = new Error_Registro("Faltan rellenar campos");
                error.ShowDialog();
            }
            else if (cod_proveedor.Text == "")
            {
                Error_Registro error = new Error_Registro("Tiene que seleccionar un proveedor");
                error.ShowDialog();
            }
            else if (cod_producto.Text == "")
            {
                Error_Registro error = new Error_Registro("Tiene que seleccionar un poducto");
                error.ShowDialog();
            }
            else if (txt_precioventa.Text == "" || txt_preciocompra.Text == "")
            {
                Error_Registro error = new Error_Registro("El precio de venta o de compra no puede ser 0 o estar vacio");
                error.ShowDialog();
            }
            else if (txt_preciocompra.Text == "" && Convert.ToDouble(txt_precioventa.Text) != 0.00)
            {
                Error_Registro error = new Error_Registro("El precio de venta o de compra no puede ser 0");
                error.ShowDialog();
            } 
            else if(txt_precioventa.Text == "0.00" && txt_preciocompra.Text == "")
            {
                Error_Registro error = new Error_Registro("El precio de venta o de compra no puede ser 0");
                error.ShowDialog();
            }
            else if(Convert.ToDouble(txt_preciocompra.Text) == 0 && Convert.ToDouble(txt_precioventa.Text) == 0.00)
            {
                Error_Registro error =   new Error_Registro("El precio de venta o de compra no puede ser 0");
                error.ShowDialog();
            }
            else if (Convert.ToDouble(txt_preciocompra.Text) != 0 && Convert.ToDouble(txt_precioventa.Text) == 0.00)
            {
                Error_Registro error = new Error_Registro("El precio de venta o de compra no puede ser 0");
                error.ShowDialog();
            }
           
            else if (Convert.ToDouble(txt_preciocompra.Text) == 0 && Convert.ToDouble(txt_precioventa.Text) != 0.00)
            {
                Error_Registro error = new Error_Registro("El precio de venta o de compra no puede ser 0");
                error.ShowDialog();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_DETALLE_COMPRA"].Value).ToString();

                DialogResult dr = MessageBox.Show("Se eliminará el pedido  con identificador  " + dataGridView1.CurrentRow.Cells["ID_DETALLE_COMPRA"].Value + ". Se eliminará definitivamente", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    cn.Eliminar_Detalle_Compra(id);


                }
                if (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.DataSource = cn.MostrarTablaDetalle_Comprar(id_aux);

                }
                else
                {
                    
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Eliminar"].Visible = false;
                    dataGridView1.DataSource = "";
                    label_mensaje.Visible = true;
                }
            }
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (cn.RetornarstockactualdelProducto(codigos_producto.ElementAt(i)) == 0)
                    {
                        cn.ModificaelStockactualeinicial(codigos_producto.ElementAt(i), dataGridView1.Rows[i].Cells["CANTIDAD"].Value.ToString(), dataGridView1.Rows[i].Cells["CANTIDAD"].Value.ToString(), Convert.ToDouble(dataGridView1.Rows[i].Cells["PRECIO_VENTA"].Value).ToString());
                    }
                    else
                    {
                        cn.ModificarelStockactual(codigos_producto.ElementAt(i), dataGridView1.Rows[i].Cells["CANTIDAD"].Value.ToString()   , Convert.ToDouble(dataGridView1.Rows[i].Cells["PRECIO_VENTA"].Value).ToString());
                    }
                }
                cn.InsertarMontoTotalCompra(id_aux);
                cont = 0;
                cod_proveedor.Text = "";
                label10.Text = "";
                cod_producto.Text = "";
                numericUpDown1.Value = 1;
                lbl_producto.Text = "";
                lbl_marca.Text = "";
                lbl_desc.Text = "";
                txt_precioventa.Text = "";  
                txt_preciocompra.Text = "";
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns["Eliminar"].Visible = false;
                dataGridView1.DataSource = "";
                label_mensaje.Visible = true;
                cn.EliminarDetalleCompra();
                codigos_producto.Clear();
                BoletaCompra frm = new BoletaCompra(id_aux);
                frm.ShowDialog();
            }   
            else
            {
                Error_Registro error=new Error_Registro("No se ha registrado ninguna compra");
                error.ShowDialog();
            }
           
        }
    }
}
