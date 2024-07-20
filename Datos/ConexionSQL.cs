using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using FontAwesome.Sharp;
using System.Drawing;
using System.Configuration;

namespace Datos
{
    public class ConexionSQL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ELIONETEntities"].ConnectionString);
        public int consultalogin(string dni, string contraseña)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From CLIENTES where DNI_CLIENTE='" + dni + "' and CONTRASEÑA_CLIENTE='" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int consultaregistrodni(string dni)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From CLIENTES where DNI_CLIENTE='" + dni + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int consulta_codigo_producto(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From PRODUCTO where ID_PRODUCTO='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int consulta_codigo_proveedor(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From PROVEEDOR where ID_PROVEEDOR='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int consulta_codigo_compra(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From COMPRA where ID_COMPRA='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int consulta_codigo_detalle_compra(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From DETALLE_COMPRA where ID_DETALLE_COMPRA='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int Cantidad_Clientes(string caracteristica, string value)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From CLIENTES WHERE " + caracteristica + "_CLIENTE='" + value + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }

        public int Codigo_Repetido(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From CLIENTES where ID_CLIENTE='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int codigo_repetido_pedido(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From PEDIDOS where ID_PEDIDO='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int codigo_repetido_detalle_pedido(string id)
        {
            int cont;
            con.Open();
            string Query = "Select Count(*) From DETALLE_PEDIDO where ID_DETALLE_PEDIDO='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int Usuario_SinFoto(string id)
        {
            int cont = 0;
            con.Open();
            string Query = "Select Count(*) From PERFIL where ID_CLIENTE='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public int regresarcantidad_detallepedido(string id_detalle_pedido)
        {
            int cantidad;
            con.Open();
            string Query = "Select CANTIDAD From DETALLE_PEDIDO where ID_DETALLE_PEDIDO='" + id_detalle_pedido + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cantidad;
        }
        public int retornodelStockinicial(string idproducto)
        {
            int cont = 0;
            con.Open();
            string Query = "select STOCK_ACTUAL from PRODUCTO where ID_PRODUCTO='" + idproducto + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;
        }
        public double retornaprecioproducto(string id)
        {
            double id_producto;
            con.Open();
            string cadena = "select PRECIO_VENTA from PRODUCTO where ID_PRODUCTO=" + id;
            SqlCommand cmd = new SqlCommand(cadena, con);
            id_producto = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return id_producto;


        }
        public double BuscarPrecio(string marca, string producto, string descripcion)
        {
            double precio;
            con.Open();
            string Query = "Select PRECIO_VENTA From PRODUCTO where MARCA_PRODUCTO='" + marca + "' AND NOMBRE_PRODUCTO='" + producto + "' AND DESCRIPCION_PRODUCTO='" + descripcion + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            precio = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return precio;
        }
        public double precio_total(string id_pedido)
        {
            double precio;
            con.Open();
            string Query = "select SUM(SUBTOTAL) AS TOTAL_PEDIDO FROM DETALLE_PEDIDO WHERE ID_PEDIDO='" + id_pedido + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            precio = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return precio;
        }
        public double precio_total_compra(string id_compra)
        {
            double precio;

            string Query = "select SUM(MONTO) AS TOTAL_PEDIDO FROM DETALLE_COMPRA WHERE ID_COMPRA='" + id_compra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            precio = Convert.ToDouble(cmd.ExecuteScalar());

            return precio;
        }
        public double precio_total_compra_paraadmin(string id_compra)
        {
            double precio;
            con.Open();
            string Query = "select SUM(MONTO) AS TOTAL_PEDIDO FROM DETALLE_COMPRA WHERE ID_COMPRA='" + id_compra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            precio = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            return precio;
        }
        public double devolverelmontototaldecompra(string idcompra)
        {
            double precio;

            string Query = "select MONTO_TOTAL from COMPRA where ID_COMPRA='" + idcompra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            precio = Convert.ToDouble(cmd.ExecuteScalar());
            return precio;
        }
        public double devolvertotaldelascompras()
        {
            double precio;
            con.Open();
            string queryval = "select count(*) from COMPRA where MONTO_TOTAL is not null";
            string Query = "select sum(MONTO_TOTAL) from COMPRA";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlCommand cmd1 = new SqlCommand(queryval, con);
            if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDouble(cmd.ExecuteScalar());
            }
            con.Close();
            return precio;
        }
        public double devolvertotaldelasventas()
        {
          
            double precio;
            con.Open();
            string queryval = "select count(*) from PEDIDOS where MONTO is not null";
            string Query = "select sum(MONTO) from PEDIDOS";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlCommand cmd1 = new SqlCommand(queryval, con);
            if (Convert.ToInt32(cmd1.ExecuteScalar())==0)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDouble(cmd.ExecuteScalar());
            }
            con.Close();
            return precio;
        }
       
        public string retornar_Codigo_Producto(string marca, string producto, string descripcion)
        {
            string id;
            con.Open();
            string Query = "Select ID_PRODUCTO From PRODUCTO where MARCA_PRODUCTO='" + marca + "' and NOMBRE_PRODUCTO='" + producto + "' and DESCRIPCION_PRODUCTO='" + descripcion + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            id = cmd.ExecuteScalar().ToString();
            con.Close();
            return id;
        }
        public string retornar_id_Cliente(string dni)
        {
            string id;
            con.Open();
            string Query = "Select ID_CLIENTE From CLIENTES where DNI_CLIENTE='" + dni + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            id = cmd.ExecuteScalar().ToString();
            con.Close();
            return id;
        }
        public string RetornarDnideProveedor(string idproveedor)
        {
            con.Open();
            string dni;
            string Query = "select DOCUMENTO_PROVEEDOR from PROVEEDOR where ID_PROVEEDOR='" + idproveedor + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            dni = cmd.ExecuteScalar().ToString();
            con.Close();
            return dni;

        }
        public string BuscarNombreProveedor(string id)
        {
            string nombre;
            con.Open();
            string Query = "select NOMBRE_PROVEEDOR FROM PROVEEDOR WHERE ID_PROVEEDOR='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            nombre = cmd.ExecuteScalar().ToString();
            con.Close();
            return nombre;
        }
        public List<string> ExtraerDescripcion(string producto, string marca)
        {
            List<string> descripcion = new List<string>();
            con.Open();

            string cadena = "select DESCRIPCION_PRODUCTO from PRODUCTO where MARCA_PRODUCTO = '" + marca + "' AND NOMBRE_PRODUCTO = '" + producto + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                descripcion.Add(dt.Rows[i]["DESCRIPCION_PRODUCTO"].ToString().TrimEnd());
            }
            con.Close();
            return descripcion;
        }
        public List<string> CodigosconMontosNullPedido(string idcliente)
        {
            List<string> codigos = new List<string>();


            string cadena = "SELECT ID_PEDIDO from PEDIDOS where MONTO is null AND  ID_CLIENTE='" + idcliente + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                codigos.Add(dt.Rows[i]["ID_PEDIDO"].ToString().TrimEnd());
            }

            return codigos;
        }
        public List<string> CodigosconMontosNullPedidoReporte()
        {
            List<string> codigos = new List<string>();


            string cadena = "SELECT ID_PEDIDO from PEDIDOS where MONTO is null";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                codigos.Add(dt.Rows[i]["ID_PEDIDO"].ToString().TrimEnd());
            }

            return codigos;
        }
        public List<string> CodigosconMontosNullCompra()
        {
            List<string> codigos = new List<string>();


            string cadena = "SELECT ID_COMPRA from COMPRA where MONTO_TOTAL is null";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                codigos.Add(dt.Rows[i]["ID_COMPRA"].ToString().TrimEnd());
            }

            return codigos;
        }

        public void Eliminar_Lista_Producto()
        {
            con.Open();
            string cadena = "DELETE FROM PRODUCTO";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CargarData(DataTable dt)
        {
            con.Open();

            using (SqlBulkCopy s = new SqlBulkCopy(con))
            {

                s.DestinationTableName = "PRODUCTO";
                s.BulkCopyTimeout = 1500;
                s.WriteToServer(dt);


            }
            con.Close();
        }
        public void Guardar_Imagen_Perfil(PictureBox picturebox, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            MemoryStream archivomemoria = new MemoryStream();
            string rpt;
            picturebox.Image.Save(archivomemoria, ImageFormat.Bmp);
            cmd.Connection = con;
            cmd.CommandText = "insertarimagen1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", id);
            cmd.Parameters.AddWithValue("@foto_perfil", archivomemoria.GetBuffer());
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public void Mostrar_ImagenPerfil(string id, IconPictureBox icpb)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = con;
            cmd.CommandText = "mostrarimagen";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Byte[] archivo = (byte[])dt.Rows[0]["IMAGEN_CLIENTE"];
            Stream imagen = new MemoryStream(archivo);
            icpb.Image = Image.FromStream(imagen);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void actualizarFoto(string id, PictureBox icpb)
        {
            if (Usuario_SinFoto(id) == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                MemoryStream archivomemoria = new MemoryStream();
                icpb.Image.Save(archivomemoria, ImageFormat.Bmp);
                cmd.Connection = con;
                cmd.CommandText = "actualizarimagen_nuevo1";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id);
                cmd.Parameters.AddWithValue("@foto_perfil1", archivomemoria.GetBuffer());
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void agregarPedido(string id_pedido, string id_cliente, string tipo_documento, string numero_documento, string nombre_cliente, string apellido_cliente, string distrito_cliente, string direccion_cliente)
        {
            con.Open();
            string cadena = "insert into PEDIDOS([ID_PEDIDO],[ID_CLIENTE],[TIPO_DOCUMENTO],[NUMERO_DOCUMENTO],[NOMBRE_CLIENTE],[APELLIDO_CLIENTE],[DISTRITO_CLIENTE],[DIRECCION_CLIENTE]) " +
                "VALUES('" + id_pedido + "','" + id_cliente + "','" + tipo_documento + "','" + numero_documento + "','" + nombre_cliente + "','" + apellido_cliente + "','" + distrito_cliente + "','" + direccion_cliente + "')";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Registrar_Detalle_Pedido(string id_detalle_pedido, string id_pedido, string id_producto, string marca_producto, string nombre_producto, string descripcion_producto, string valor, string cantidad, string subtotal)
        {
            con.Open();
            string cadena = "insert into DETALLE_PEDIDO([ID_DETALLE_PEDIDO], [ID_PEDIDO], [ID_PRODUCTO], [MARCA_PRODUCTO], [NOMBRE_PRODUCTO], [DESCRIPCION_PRODUCTO],[PRECIO_VENTA],[CANTIDAD], [SUBTOTAL]) VALUES('" + id_detalle_pedido + "', '" + id_pedido + "', '" + id_producto + "', '" + marca_producto + "', '" + nombre_producto + "', '" + descripcion_producto + "'," + valor + "," + cantidad + "," + subtotal + ")";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void reducir_stock(string id, int cantidad)
        {
            int cont;
            int reduccion;
            con.Open();
            string Query = "Select STOCK_ACTUAL From PRODUCTO where ID_PRODUCTO='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            reduccion = cont - cantidad;
            string cadena = "UPDATE PRODUCTO SET STOCK_ACTUAL=" + reduccion + " WHERE ID_PRODUCTO='" + id + "'";
            SqlCommand cmd2 = new SqlCommand(cadena, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }


        public void insertar_precio_envio(string id_pedido, string monto, string tipo_envio)
        {
            con.Open();
            string Query = "UPDATE PEDIDOS SET TIPO_ENVIO='" + tipo_envio + "' where ID_PEDIDO='" + id_pedido + "' " +
                "UPDATE PEDIDOS SET MONTO = " + monto + " where ID_PEDIDO = '" + id_pedido + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Eliminar_detalle_pedido(string id_detalle_pedido)
        {

            con.Open();

            string cadena4 = "DELETE FROM DETALLE_PEDIDO WHERE ID_DETALLE_PEDIDO='" + id_detalle_pedido + "'";
            SqlCommand cmd4 = new SqlCommand(cadena4, con);
            cmd4.ExecuteNonQuery();
            con.Close();
        }
       
        public void InsertarProveedor(string id, string nombre, string documento, string razon, string correo, string telefono)
        {
            con.Open();
            string cadena = "insert into PROVEEDOR([ID_PROVEEDOR],[NOMBRE_PROVEEDOR],[DOCUMENTO_PROVEEDOR],[RAZON_SOCIAL_PROVEEDOR],[CORREO_PROVEEDOR],[TELEFONO_PROVEEDOR]) " +
                "VALUES('" + id + "','" + nombre + "','" + documento + "','" + razon + "','" + correo + "','" + telefono + "')";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void agregarCompra(string id_compra, string id_proveedor, string dni_proveedor)
        {
            con.Open();
            string cadena = "insert into COMPRA([ID_COMPRA],[ID_PROVEEDOR],[NUMERO_DOCUMENTO]) " +
               "VALUES('" + id_compra + "','" + id_proveedor + "'," + dni_proveedor + ")";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertarDetalleCompra(string id_detalle_compra, string id_compra, string id_producto, string nombre_producto, string marca_producto, string descripcion_producto, string precioventa, string precio_compra, string cantidad, string monto)
        {
            con.Open();
            string cadena = "insert into DETALLE_COMPRA([ID_DETALLE_COMPRA],[ID_COMPRA],[ID_PRODUCTO],[MARCA_PRODUCTO],[NOMBRE_PRODUCTO],[DESCRIPCION_PRODUCTO],[PRECIO_VENTA],[PRECIO_COMPRA],[CANTIDAD],[MONTO]) " +
               "VALUES('" + id_detalle_compra + "','" + id_compra + "','" + id_producto + "','" + marca_producto + "','" + nombre_producto + "','" + descripcion_producto + "'," + precioventa + "," + precio_compra + "," + cantidad + "," + monto + ")";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void EliminarDetallePedidos(string idcliente)
        {
            con.Open();
            for (int i = 0; i < CodigosconMontosNullPedido(idcliente).Count; i++)
            {

                string cadena = "DELETE FROM DETALLE_PEDIDO WHERE ID_PEDIDO='" + CodigosconMontosNullPedido(idcliente).ElementAt(i) + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
               
            }
            string cadena1 = "DELETE FROM PEDIDOS WHERE MONTO IS NULL";
            SqlCommand cmd1 = new SqlCommand(cadena1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        public void Eliminardetallepedidoreporte()
        {
            con.Open();
            for (int i = 0; i < CodigosconMontosNullPedidoReporte().Count; i++)
            {

                string cadena = "DELETE FROM DETALLE_PEDIDO WHERE ID_PEDIDO='" + CodigosconMontosNullPedidoReporte().ElementAt(i) + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();

            }
            string cadena1 = "DELETE FROM PEDIDOS WHERE MONTO IS NULL";
            SqlCommand cmd1 = new SqlCommand(cadena1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarStockinicialyActual(string idproducto, string cantidadi, string cantidada, string precio)
        {
            con.Open();
            string cadena = "update PRODUCTO set STOCK_INICIAL ="+cantidadi + ", STOCK_ACTUAL = STOCK_ACTUAL+" + cantidada + ",PRECIO_VENTA=" + precio + " where ID_PRODUCTO = '" + idproducto + "'";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ModificarStockActual(string idproducto, string cantidada, string precio)
        {
            con.Open();
            string cadena = "update PRODUCTO set STOCK_ACTUAL = STOCK_ACTUAL+" + cantidada + ",PRECIO_VENTA=" + precio + " where ID_PRODUCTO = '" + idproducto + "'";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Eliminar_detalle_compra(string id_detalle_compra)
        {

            con.Open();

            string cadena4 = "DELETE FROM DETALLE_COMPRA WHERE ID_DETALLE_COMPRA='" + id_detalle_compra + "'";
            SqlCommand cmd4 = new SqlCommand(cadena4, con);
            cmd4.ExecuteNonQuery();
            con.Close();
        }

        public void insertar_montototal(string id_compra)
        {
            con.Open();
            string Query = "UPDATE COMPRA SET MONTO_TOTAL=" + precio_total_compra(id_compra) + " where ID_COMPRA='" + id_compra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EliminarDetalleCompra()
        {
            con.Open();
            for (int i = 0; i < CodigosconMontosNullCompra().Count; i++)
            {

                string cadena = "DELETE FROM DETALLE_COMPRA WHERE ID_COMPRA='" + CodigosconMontosNullCompra().ElementAt(i) + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
              
            }
            string cadena1 = "DELETE FROM COMPRA WHERE MONTO_TOTAL IS NULL";
            SqlCommand cmd1 = new SqlCommand(cadena1, con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        public void registrar(string id, string tipo_documento, string dni, string nombre, string apellido, string telefono, string correo, string distrito, string direccion, string contraseña)
        {
            con.Open();
            string cadena = "insert into CLIENTES([ID_CLIENTE],[DOCUMENTO_CLIENTE],[DNI_CLIENTE],[NOMBRE_CLIENTE],[APELLIDO_CLIENTE],[TELEFONO_CLIENTE],[CORREO_CLIENTE],[DISTRITO_CLIENTE],[DIRECCION_CLIENTE],[CONTRASEÑA_CLIENTE]) " +
                "VALUES('" + id + "','" + tipo_documento + "','" + dni + "','" + nombre + "','" + apellido + "','" + telefono + "','" + correo + "','" + distrito + "','" + direccion + "','" + contraseña + "')";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void registrar_producto(string id, string marca, string nombre, string descripcion)
        {
            con.Open();
            string cadena = "insert into PRODUCTO([ID_PRODUCTO],[MARCA_PRODUCTO],[NOMBRE_PRODUCTO],[DESCRIPCION_PRODUCTO]) " +
                "VALUES(" + id + ",'" + marca + "','" + nombre + "','" + descripcion + "')";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void Modificar_stock_r(string id,string valor)
        {
            con.Open();
            string cadena = "UPDATE PRODUCTO SET STOCK_REPOSICION="+valor+" WHERE ID_PRODUCTO='" + id + "'";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void editar_prod_id(string id, string caracteristica, string valor)
        {
            con.Open();
            string cadena = "UPDATE PRODUCTO SET " + caracteristica + "_PRODUCTO='" + valor + "' WHERE ID_PRODUCTO='" + id + "'";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void cambiarestadodepedido(string idpedido)
        {
            con.Open();
            string cadena = "UPDATE PEDIDOS SET ESTADO='Enviado' where ID_PEDIDO='" + idpedido + "'";
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ClienteporId(string id_cliente)
        {
            string cadena = "select * FROM CLIENTES WHERE ID_CLIENTE='" + id_cliente + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable Producto_id(string id)
        {
            string cadena = "select * FROM PRODUCTO WHERE ID_PRODUCTO='" + id + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable tabla_producto()
        {
            string cadena = "select * FROM PRODUCTO";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable Lista_Clientes()
        {
            string cadena = "select  ID_CLIENTE,DOCUMENTO_CLIENTE,DNI_CLIENTE,NOMBRE_CLIENTE,APELLIDO_CLIENTE,TELEFONO_CLIENTE,CORREO_CLIENTE,DISTRITO_CLIENTE,DIRECCION_CLIENTE FROM CLIENTES";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable buscarcliente(string caracteristica, string valor)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter("select ID_CLIENTE,DOCUMENTO_CLIENTE,DNI_CLIENTE,NOMBRE_CLIENTE,APELLIDO_CLIENTE,TELEFONO_CLIENTE,CORREO_CLIENTE,DISTRITO_CLIENTE,DIRECCION_CLIENTE FROM CLIENTES WHERE " + caracteristica + "_CLIENTE='" + valor + "'", con);
            adaptador.Fill(dt);
            return dt;
        }
        public DataTable filtro_marca_nombre_precio(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
        string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10, string min, string max)
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE (MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "') AND (NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "') AND (PRECIO_VENTA>=" + min + " AND PRECIO_VENTA<=" + max + ")";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_marca_nombre(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
            string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE (MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "') AND (NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "')";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_marca(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8)
        {

            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "'";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_marcaadmin(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8)
        {

            string cadena = "select * FROM PRODUCTO WHERE MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "'";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_nombreadmin(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {

            string cadena = "select * FROM PRODUCTO WHERE NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "'";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_marca_nombreadmin(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
           string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {
            string cadena = "select * FROM PRODUCTO WHERE (MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "') AND (NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "')";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_marca_precio(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8, string max, string min)
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE (MARCA_PRODUCTO='" + marca1 + "' OR MARCA_PRODUCTO='" + marca2 + "' OR MARCA_PRODUCTO='" + marca3 + "' OR MARCA_PRODUCTO='" + marca4 + "' OR MARCA_PRODUCTO='" + marca5 + "'OR MARCA_PRODUCTO='" + marca6 + "' OR MARCA_PRODUCTO='" + marca7 + "' OR MARCA_PRODUCTO='" + marca8 + "') AND (PRECIO_VENTA>=" + min + "AND PRECIO_VENTA<=" + max + ")";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_nombre(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {

            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "'";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_nombre_precio(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10, string min, string max)
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE (NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "') " +
                "AND (PRECIO_VENTA>=" + min + "AND PRECIO_VENTA<=" + max + ")";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_nombre_precio_asc(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10, string min, string max)
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO WHERE (NOMBRE_PRODUCTO='" + producto1 + "' OR NOMBRE_PRODUCTO = '" + producto2 + "'" +
                "OR NOMBRE_PRODUCTO='" + producto3 + "' OR NOMBRE_PRODUCTO='" + producto4 + "' OR NOMBRE_PRODUCTO='" + producto5 + "' OR NOMBRE_PRODUCTO='" + producto6 + "' OR NOMBRE_PRODUCTO='" + producto7 + "' OR NOMBRE_PRODUCTO='" + producto8 + "' OR NOMBRE_PRODUCTO='" + producto9 + "' OR NOMBRE_PRODUCTO='" + producto10 + "') " +
                "AND (PRECIO_VENTA>=" + min + "AND PRECIO_VENTA<=" + max + ") order ";

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable filtro_precio(string min, string max)
        {
            int min_value = Convert.ToInt32(min);
            int max_value = Convert.ToInt32(max);
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO  WHERE PRECIO_VENTA>=" + min + "AND PRECIO_VENTA=<" + max;

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable TablaCompra()
        {
            string cadena = "select * FROM COMPRA where MONTO_TOTAL is not null order by FECHA_COMPRA desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable mostrar_producto_comprar(string id)
        {

            string cadena = "select ID_DETALLE_PEDIDO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,PRECIO_VENTA,CANTIDAD,SUBTOTAL FROM DETALLE_PEDIDO WHERE ID_PEDIDO='" + id + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable Lista_Productos_Clientes()
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO where PRECIO_VENTA!=0";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable RetornarCodigosdeProductoconStockbajo()
        {
            string cadena = "select ID_PRODUCTO from PRODUCTO where STOCK_ACTUAL<STOCK_REPOSICION";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable RetornarTablaProveedor()
        {
            string cadena = "select ID_PROVEEDOR,NOMBRE_PROVEEDOR,DOCUMENTO_PROVEEDOR,ESTADO FROM PROVEEDOR";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable RetornarTablaCodigoProducto()
        {
            string cadena = "select ID_PRODUCTO,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,STOCK_ACTUAL,PRECIO_VENTA FROM PRODUCTO";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable MostrarTablaDetalle_Compra(string id)
        {
            string cadena = "select ID_DETALLE_COMPRA,MARCA_PRODUCTO,NOMBRE_PRODUCTO,DESCRIPCION_PRODUCTO,PRECIO_VENTA,PRECIO_COMPRA,CANTIDAD,MONTO FROM DETALLE_COMPRA WHERE ID_COMPRA='" + id + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable MostrarPedidosClientes(string idcliente)
        {
            string cadena = "select ID_PEDIDO,DISTRITO_CLIENTE,DIRECCION_CLIENTE,TIPO_ENVIO,MONTO,FECHA_REGISTRO,ESTADO FROM PEDIDOS WHERE ID_CLIENTE='" + idcliente + "' AND MONTO IS NOT NULL order by FECHA_REGISTRO desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable MostrarPrecioyEnvio(string idpedido)
        {
            string cadena = "select TIPO_ENVIO,DISTRITO_CLIENTE,MONTO,FECHA_REGISTRO FROM PEDIDOS WHERE ID_PEDIDO='" + idpedido + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeMontodeventaProducto()
        {
            string cadena = "select NOMBRE_PRODUCTO, SUM(PRECIO_VENTA) as [MONTO_COMPRA] from DETALLE_PEDIDO group by NOMBRE_PRODUCTO order by [MONTO_COMPRA] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeCantidaddeProductoVendidos()
        {
            string cadena = "select NOMBRE_PRODUCTO,SUM(CANTIDAD) as CANTIDAD from DETALLE_PEDIDO GROUP BY NOMBRE_PRODUCTO order by CANTIDAD desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeMontodeventaMarca()
        {
            string cadena = "select MARCA_PRODUCTO, SUM(PRECIO_VENTA) as [MONTO_COMPRA] from DETALLE_PEDIDO group by MARCA_PRODUCTO order by [MONTO_COMPRA] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeCantidaddeMarcaVendidas()
        {
            string cadena = "select	MARCA_PRODUCTO,SUM(CANTIDAD) as CANTIDAD from DETALLE_PEDIDO GROUP BY MARCA_PRODUCTO order by CANTIDAD desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;


        }
        public DataTable ReportedeMontodeCompraProducto()
        {
            string cadena = "select NOMBRE_PRODUCTO, SUM(PRECIO_VENTA) as [MONTO_COMPRA] from DETALLE_COMPRA group by NOMBRE_PRODUCTO order by [MONTO_COMPRA] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeCantidaddeProductoComprados()
        {
            string cadena = "select	NOMBRE_PRODUCTO,SUM(CANTIDAD) as CANTIDAD from DETALLE_COMPRA GROUP BY NOMBRE_PRODUCTO order by CANTIDAD desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeMontodeCompraMarca()
        {
            string cadena = "select MARCA_PRODUCTO, SUM(PRECIO_VENTA) as [MONTO_COMPRA] from DETALLE_COMPRA group by MARCA_PRODUCTO order by [MONTO_COMPRA] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeCantidaddeMarcaCompradas()
        {
            string cadena = "select	MARCA_PRODUCTO,SUM(CANTIDAD) as CANTIDAD from DETALLE_COMPRA GROUP BY MARCA_PRODUCTO order by CANTIDAD desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;


        }
        public DataTable ReportedeMontodeCompradeCliente()
        {
            string cadena = "select ID_CLIENTE,NOMBRE_CLIENTE,APELLIDO_CLIENTE, SUM(MONTO) as [MONTO_COMPRA] from PEDIDOS group by ID_CLIENTE,NOMBRE_CLIENTE,APELLIDO_CLIENTE order by [MONTO_COMPRA] desc ";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReportedeMontoDistritoCliente()
        {
            string cadena = "select DISTRITO_CLIENTE, SUM(MONTO) as [MONTO_COMPRA] from PEDIDOS group by DISTRITO_CLIENTE order by [MONTO_COMPRA] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReporteCantidadCompraDistrito()
        {
            string cadena = "select DISTRITO_CLIENTE, count(*) as [CANTIDAD] from PEDIDOS group by DISTRITO_CLIENTE order by [CANTIDAD] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public DataTable ReporteCantidadCompraCliente()
        {
            string cadena = "select NOMBRE_CLIENTE, count(*) as [CANTIDAD] from PEDIDOS group by NOMBRE_CLIENTE order by [CANTIDAD] desc";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
