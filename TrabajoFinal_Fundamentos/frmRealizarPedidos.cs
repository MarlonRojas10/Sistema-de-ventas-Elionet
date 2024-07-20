using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Negocios;
namespace TrabajoFinal_Fundamentos
{
    public partial class frmRealizarPedidos : Form
    {
        
        ConexionSQLN cn=new ConexionSQLN(); 
        int monto, v1, montoTotal,cont;
        string id_aux;
        List<string> codigos_producto = new List<string>();
        List<string> codigos_detalle_pedidos=new List<string>();        
        public string numero_dni { get; set; }
        public frmRealizarPedidos(string dni)
        {
            InitializeComponent();
            monto = 0;
            v1 = 0;
            montoTotal = 0;
            numero_dni = dni;
            cont = 0;
            id_aux = "";

        }

        private void frmRealizarPedidos_Load(object sender, EventArgs e)
        {
          
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (cbProducto.Text == "" || cbMarca.Text == "" || cbTipoEntrega.Text == "" )
            {
                if (cbProducto.Text == "")
                {
                 
                    cbProducto.Focus();
                    return;
                }

                if (cbMarca.Text == "")
                {
                   
                    cbMarca.Focus();
                    return;
                }

                if (cbTipoEntrega.Text == "")
                {
                  
                    cbTipoEntrega.Focus();
                    return;
                }

              
            }
            else
            {
                if (label_monto.Text == "")
                {
                    
                    label_monto.Focus();
                    return;
                }
                else
                {
                 
                 

                

                    nudCantidad.Value = 1;
                    cbProducto.Text = "";
                    cbMarca.Text = "";
               
                    label_monto.Text = "";
                  
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_descripcion.Text = "";
            labelmonto.Text = "";
            nudCantidad.Value = 1;
     
            cbMarca.Enabled = true;
            cb_descripcion.Items.Clear();
            if (cbMarca.Text != "")
            {
                foreach (string des in cn.retornar_descripcion(cbProducto.Text, cbMarca.Text))
                {
                    cb_descripcion.Items.Add(des);
                }
            }

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_descripcion.Items.Clear();
            labelmonto.Text = "";

            nudCantidad.Value = 1;
            cb_descripcion.Enabled = true;
            foreach (string des in cn.retornar_descripcion(cbProducto.Text, cbMarca.Text))
            {
                cb_descripcion.Items.Add(des);
            }
            cb_descripcion.Text = "";
            
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            labelmonto.Text = ((cn.precio_producto(cbMarca.Text, cbProducto.Text, cb_descripcion.Text) * Convert.ToDouble(nudCantidad.Value))).ToString();
        }

        private void cbTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void cb_descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelmonto.Text = "";
         
            nudCantidad.Value = 1;
            nudCantidad.Enabled = true;

            labelmonto.Text = ((cn.precio_producto(cbMarca.Text, cbProducto.Text, cb_descripcion.Text) * Convert.ToDouble(nudCantidad.Value))).ToString();

        }
        public string generarcodigo_pedido()
        {
            Random rnd = new Random();
            string id_pedido = rnd.Next(999, 9999).ToString();
          
             while (cn.codigo_repetido_pedido(id_pedido) == 1)
            {
                id_pedido = rnd.Next(999, 9999).ToString();
            }

            return id_pedido;
        
        }
        public string generarcodigo_detalle_pedido()
        {
            Random rnd = new Random();
            string id_detallepedido = rnd.Next(999, 9999).ToString();
            while (cn.codigo_repetido_detalle_pedido(id_detallepedido) == 1)
            {
                id_detallepedido = rnd.Next(999, 9999).ToString();
            }
            return id_detallepedido;
        }
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (cbMarca.Text != "" && cbProducto.Text != "" && cb_descripcion.Text!="" && nudCantidad.Value.ToString()!="" && labelmonto.Text!="") {

                string id_pedido;
                string id_detallepedido;
                if (cont == 0)
                {
                    id_aux = generarcodigo_pedido();
                }

                id_pedido = id_aux;
                id_detallepedido = generarcodigo_detalle_pedido();
                DataTable dt = new DataTable();
                dt = cn.busqueda_Clientes("DNI", numero_dni);

                if (cont == 0)
                {
                    cn.agregar_Pedido(id_pedido, dt.Rows[0]["ID_CLIENTE"].ToString().TrimEnd(), dt.Rows[0]["DOCUMENTO_CLIENTE"].ToString().TrimEnd(), dt.Rows[0]["DNI_CLIENTE"].ToString().TrimEnd(), dt.Rows[0]["NOMBRE_CLIENTE"].ToString().TrimEnd(), dt.Rows[0]["APELLIDO_CLIENTE"].ToString().TrimEnd(),
              dt.Rows[0]["DISTRITO_CLIENTE"].ToString().TrimEnd(), dt.Rows[0]["DIRECCION_CLIENTE"].ToString().TrimEnd());
                }
                if (cn.RetornarstockactualdelProducto(cn.retornar_producto_caracteristicas(cbMarca.Text, cbProducto.Text, cb_descripcion.Text)) >= nudCantidad.Value)
                {
                    label_mensaje.Visible = false;
                    cbMarca.Enabled = false;
                    nudCantidad.Enabled = false;
                    cb_descripcion.Enabled = false;
                    cbTipoEntrega.Enabled = true;
                    dataGridView1.RowHeadersVisible = true;
                    dataGridView1.Columns["Eliminar"].Visible = true;
                    cn.agregar_detalle_pedido(id_detallepedido, id_pedido, cn.retornar_producto_caracteristicas(cbMarca.Text, cbProducto.Text, cb_descripcion.Text), cbMarca.Text, cbProducto.Text, cb_descripcion.Text, cn.RetornarPrecioProducto(cn.retornar_producto_caracteristicas(cbMarca.Text, cbProducto.Text, cb_descripcion.Text)).ToString(), nudCantidad.Value.ToString(), labelmonto.Text);
                    dataGridView1.DataSource = cn.Mostrar_producto_comprar(id_pedido);
                    dataGridView1.Columns["ID_DETALLE_PEDIDO"].HeaderText = "ID";
                    dataGridView1.Columns["MARCA_PRODUCTO"].HeaderText = "MARCA";
                    dataGridView1.Columns["NOMBRE_PRODUCTO"].HeaderText = "PRODUCTO";
                    dataGridView1.Columns["DESCRIPCION_PRODUCTO"].HeaderText = "DESCRIPCIÓN";
                    dataGridView1.Columns["PRECIO_VENTA"].HeaderText = "PRECIO";
                    dataGridView1.Columns["CANTIDAD"].HeaderText = "CANTIDAD";
                    dataGridView1.Columns["SUBTOTAL"].HeaderText = "SUBTOTAL";
                    dataGridView1.Columns["ID_DETALLE_PEDIDO"].Width = 53;
                    dataGridView1.Columns["DESCRIPCION_PRODUCTO"].Width = 156;
                    dataGridView1.Columns["PRECIO_VENTA"].Width = 80;
                    dataGridView1.Columns["MARCA_PRODUCTO"].Width = 90;
                    dataGridView1.Columns["NOMBRE_PRODUCTO"].Width = 110;
                    dataGridView1.Columns["CANTIDAD"].Width = 85;
                    dataGridView1.Columns["SUBTOTAL"].Width = 90;
                    dataGridView1.Columns["Eliminar"].DisplayIndex = 7;
                    cont = 1;
                    codigos_producto.Add(cn.retornar_producto_caracteristicas(cbMarca.Text, cbProducto.Text, cb_descripcion.Text));
                    codigos_detalle_pedidos.Add(id_detallepedido);
                    
                    total_pedido.Text = cn.precio_total_pedido(id_aux).ToString();
                }
                else
                {
                    Error_Registro frm = new Error_Registro("El producto seleccionado no cuenta con el stock suficiente");
                    frm.ShowDialog();
                } 
            }
            else
            {
                Error_Registro frm = new Error_Registro("Los campos para añadir el producto no están completos");
                frm.ShowDialog();
            }
            cbMarca.Enabled = false;
            nudCantidad.Enabled = false;
            cb_descripcion.Enabled = false;
            cbMarca.Text = "";
            cbProducto.Text = "";
            cb_descripcion.Text = "";
            nudCantidad.Value = 1;
            labelmonto.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_DETALLE_PEDIDO"].Value).ToString();
      
                DialogResult dr = MessageBox.Show("Se eliminará el pedido  con identificador  " + dataGridView1.CurrentRow.Cells["ID_DETALLE_PEDIDO"].Value + ". Se eliminará definitivamente", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    cn.Eliminar_Pedido(id);
                    

                }
                if (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.DataSource = cn.Mostrar_producto_comprar(id_aux);
                    total_pedido.Text=cn.precio_total_pedido(id_aux).ToString();
                }
                else
                {
                    total_pedido.Text = "0";
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns["Eliminar"].Visible = false;
                    dataGridView1.DataSource = "";
                    label_mensaje.Visible = true;
                }
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) { 
            DialogResult dr = new DialogResult();
                if (cbTipoEntrega.Text != "")
                {
                    if (cbTipoEntrega.Text == "Moto")
                    {
                        dr = MessageBox.Show("Esta seguro de su compra con un total de " + (cn.precio_total_pedido(id_aux) + 10).ToString() + " soles", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                    else if (cbTipoEntrega.Text == "Auto")
                    {
                        dr = MessageBox.Show("Esta seguro de su compra con un total de " + (cn.precio_total_pedido(id_aux) + 30).ToString() + " soles", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < codigos_producto.Count; i++)
                        {
                            cn.reducir_stock(codigos_producto.ElementAt(i), cn.retornar_cantidad_detalle_producto(codigos_detalle_pedidos.ElementAt(i)));

                        }
                        if (cbTipoEntrega.Text == "Moto")
                        {
                            cn.insertar_precio_envio(id_aux, (cn.precio_total_pedido(id_aux) + 10).ToString(), cbTipoEntrega.Text);
                        }
                        else if (cbTipoEntrega.Text == "Auto")
                        {
                            cn.insertar_precio_envio(id_aux, (cn.precio_total_pedido(id_aux) + 30).ToString(), cbTipoEntrega.Text);
                        }
                        cont = 0;

                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.Columns["Eliminar"].Visible = false;
                        dataGridView1.DataSource = "";
                        label_mensaje.Visible = true;
                        cn.EliminarPedidoconMontoNull(cn.getCodigo_DNI(numero_dni));
                        codigos_producto.Clear();
                        codigos_detalle_pedidos.Clear();
                        BoletadeVenta frm = new BoletadeVenta(id_aux);
                        frm.Show();
                        label_mensaje.Visible = false;
                        cbMarca.Enabled = false;
                        nudCantidad.Enabled = false;
                        cb_descripcion.Enabled = false;
                        cbTipoEntrega.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Falta rellenar el campo de envio");
                }
            }
            else
            {
                Error_Registro error = new Error_Registro("No se ha registado ningun pedido"); 
                error.ShowDialog();
            }
           
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
     
            
        }

       
    }
}
