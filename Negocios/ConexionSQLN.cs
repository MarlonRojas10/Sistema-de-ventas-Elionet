using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Negocios
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();
        
    
        public List<string> retornar_descripcion(string prod, string marca)
        {
            return cn.ExtraerDescripcion(prod, marca);
        }
        public DataTable Lista_Clientes()
        {
            return cn.Lista_Clientes();
        }

        public DataTable ListaCompra()
        {
            return cn.TablaCompra();
        }   
        public DataTable Filtro_nombre_marca(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
             string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {
            return cn.filtro_marca_nombre(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8, producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10);
        }
        public DataTable Filtro_marca(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8)
        {
            return cn.filtro_marca(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8);
        }
        public DataTable Filtro_nombre(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {
            return cn.filtro_nombre(producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10);
        }
        public DataTable Filtro_precio(string min, string max)
        {
            return cn.filtro_precio(min, max);
        }
        public DataTable Filtro_nombre_precio(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10, string min, string max)
        {
            return cn.filtro_nombre_precio(producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10, min, max);
        }
        public DataTable Filtro_marca_precio(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8, string min, string max)
        {
            return cn.filtro_marca_precio(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8, min, max);
        }
        public DataTable Filtro_marca_nombre_precio(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
             string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10, string min, string max)
        {
            return cn.filtro_marca_nombre_precio(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8, producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10, min, max);
        }
        public DataTable Lista_Producto()
        {

            return cn.tabla_producto();
        }
        public DataTable getProducto(string id)
        {
            return cn.Producto_id(id);
        }
        public DataTable busqueda_Clientes(string caracterisitica, string value)
        {
            return cn.buscarcliente(caracterisitica, value);
        }
        public DataTable Mostrar_producto_comprar(string id)
        {
            return cn.mostrar_producto_comprar(id);
        }
        public DataTable RetornarTablaProveedor()
        {
            return cn.RetornarTablaProveedor();
        }
        public DataTable RetornarCodigosdeProductoconStockbajo()
        {
            return cn.RetornarCodigosdeProductoconStockbajo();
        }
        public DataTable Tabla_Codigos_Productos()
        {
            return cn.RetornarTablaCodigoProducto();
        }
        public DataTable Tabla_Productos_Clientes()
        {
            return cn.Lista_Productos_Clientes();
        }
        public DataTable MostrarTablaDetalle_Comprar(string id)
        {
            return cn.MostrarTablaDetalle_Compra(id);
        }
        public DataTable MostrarPedidosClientes(string id)
        {
            return cn.MostrarPedidosClientes(id);
        }
        public DataTable Montoytipodeenviopedido(string idpedido)
        {
            return cn.MostrarPrecioyEnvio(idpedido);
        }
        public DataTable Filtromarcaadmin(string marca1,string marca2,string marca3,string marca4,string marca5,string marca6,string marca7,string marca8)
        {
            return cn.filtro_marcaadmin(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8);
        }
        public DataTable filtro_nombreadmin(string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {

            return cn.filtro_nombreadmin(producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10);
        }
        public DataTable filtro_marca_nombreadmin(string marca1, string marca2, string marca3, string marca4, string marca5, string marca6, string marca7, string marca8,
           string producto1, string producto2, string producto3, string producto4, string producto5, string producto6, string producto7, string producto8, string producto9, string producto10)
        {
            return cn.filtro_marca_nombreadmin(marca1, marca2, marca3, marca4, marca5, marca6, marca7, marca8, producto1, producto2, producto3, producto4, producto5, producto6, producto7, producto8, producto9, producto10);
        }
        public DataTable retornarcaracterísticasIDCliente(string idcliente)
        {
            return cn.ClienteporId(idcliente);
        }
        public DataTable ReportedeMontodeventaProducto()
        {
            return cn.ReportedeMontodeventaProducto();
        }
        public DataTable ReportedeCantidadeProductodeVendidos()
        {
            return cn.ReportedeCantidaddeProductoVendidos();
        }
        public DataTable ReportedeMontodeventaMarca()
        {
            return cn.ReportedeMontodeventaMarca();
        }
        public DataTable ReportedeCantidaddeMarcaVendidas()
        {
            return cn.ReportedeCantidaddeMarcaVendidas();
        }
        public DataTable ReportedeMontodeCompradeCliente()
        {
            return cn.ReportedeMontodeCompradeCliente();
        }
        public DataTable ReportedeMontoporDistrito()
        {
            return cn.ReportedeMontoDistritoCliente();
        }
        public DataTable ReportedeCantidadporCliente()
        {
            return cn.ReporteCantidadCompraCliente();
        }
        public DataTable ReporteCantidadCompraDistrito()
        {
            return cn.ReporteCantidadCompraDistrito();
        }
        public DataTable ReportedeMontodeCompraProducto()
        {
            return cn.ReportedeMontodeCompraProducto();
        }
       
        public DataTable ReportedeCantidaddeProductoComprados()
        {
            return cn.ReportedeCantidaddeProductoComprados();
        }
        public DataTable ReportedeMontodeCompraMarca()
        {
            return cn.ReportedeMontodeCompraMarca();
        }
        public DataTable ReportedeCantidaddeMarcaCompradas()
        {
            return cn.ReportedeCantidaddeMarcaCompradas();
        }
        public void registrarCliente(string id, string tipo_documento, string dni, string nombre, string apellido, string telefono, string correo, string distrito, string direccion, string contraseña)
        {
            cn.registrar(id, tipo_documento, dni, nombre, apellido, telefono, correo, distrito, direccion, contraseña);
        }
        public void Modificar_Stock_Reposicion(string id,string valor)
        {
            cn.Modificar_stock_r(id, valor);
        }

        public void EditarProducto(string id, string caracteristica, string valor)
        {
            cn.editar_prod_id(id, caracteristica, valor);
        }
        public void Cargar_Data_Excel(DataTable dt)
        {
            cn.CargarData(dt);
        }
        public void Eliminar_Lista_Productos()
        {
            cn.Eliminar_Lista_Producto();
        }
        public void Insertar_Foto_Perfil(PictureBox pb, string id)
        {
            cn.Guardar_Imagen_Perfil(pb, id);
        }
        public void Mostrar_Imagen_Perfil(string id, IconPictureBox icpb)
        {
            cn.Mostrar_ImagenPerfil(id, icpb);
        }
        public void Actualizar_Foto(string id, PictureBox icpb)
        {
            cn.actualizarFoto(id, icpb);
        }
        public void agregar_Pedido(string id_pedido, string id_cliente, string tipo_documento, string numero_documento, string nombre_cliente, string apellido_cliente, string distrito_cliente, string direccion_cliente)
        {
            cn.agregarPedido(id_pedido, id_cliente, tipo_documento, numero_documento, nombre_cliente, apellido_cliente, distrito_cliente, direccion_cliente);
        }
        public void agregar_detalle_pedido(string id_detalle_pedido, string id_pedido, string id_producto, string marca_producto, string nombre_producto, string descripcion_producto, string valor, string cantidad, string subtotal)
        {
            cn.Registrar_Detalle_Pedido(id_detalle_pedido, id_pedido, id_producto, marca_producto, nombre_producto, descripcion_producto, valor, cantidad, subtotal);
        }
        public void reducir_stock(string id, int cantidad)
        {
            cn.reducir_stock(id, cantidad);
        }
        public void insertar_precio_envio(string id_pedido, string monto, string tipo_envio)
        {
            cn.insertar_precio_envio(id_pedido, monto, tipo_envio);
        }
        public void Eliminar_Pedido(string id_detalle_pedido)
        {
            cn.Eliminar_detalle_pedido(id_detalle_pedido);
        }
        public void AgregarCompra(string id_compra, string id_proveedor, string dni_prov)
        {
            cn.agregarCompra(id_compra, id_proveedor, dni_prov);
        }
        public void AgregarDetalle_Compra(string id_detalle_compra, string id_compra, string id_producto, string marca_producto, string nombre_producto, string descripcion_producto, string precio_venta, string precio_compra, string cantidad, string monto)
        {
            cn.InsertarDetalleCompra(id_detalle_compra, id_compra, id_producto, marca_producto, nombre_producto, descripcion_producto, precio_venta, precio_compra, cantidad, monto);
        }
        public void EliminarPedidoconMontoNullreporte()
        {
            cn.Eliminardetallepedidoreporte();
        }
        public void EliminarPedidoconMontoNull(string idcliente)
        {
            cn.EliminarDetallePedidos(idcliente);
        }
        public void ModificaelStockactualeinicial(string idproducto, string stocki, string stocka, string precio)
        {
            cn.ModificarStockinicialyActual(idproducto, stocki, stocka, precio);
        }
        public void ModificarelStockactual(string idproducto,string stocka, string precio)
        {
            cn.ModificarStockActual(idproducto, stocka,precio);
        }
        public void Eliminar_Detalle_Compra(string iddetallecompra)
        {
            cn.Eliminar_detalle_compra(iddetallecompra);
        }
        public void InsertarMontoTotalCompra(string idcompra)
        {
            cn.insertar_montototal(idcompra);
        }
        public void EliminarDetalleCompra()
        {
            cn.EliminarDetalleCompra();
        }

        public void AgregarProveedor(string id, string nombre, string documento, string razon, string correo, string telefono)
        {
            cn.InsertarProveedor(id, nombre, documento, razon, correo, telefono);
        }

        public void Agregar_Producto(string id, string marca, string nombre, string descripcion)
        {
            cn.registrar_producto(id, marca, nombre, descripcion);
        }
        public void CambiarEstadodePedido(string idpedido)
        {
            cn.cambiarestadodepedido(idpedido); 
        }
      
        public int conSQL(string dni, string psw)
        {
            return cn.consultalogin(dni, psw);
        }
        public int Codigo_Repetido(string id)
        {
            return cn.Codigo_Repetido(id);
        }

        public int cantidad_clientes(string caracteristica, string value)
        {
            return cn.Cantidad_Clientes(caracteristica, value);
        }
        public int Consulta_codigo_Producto(string id)
        {
            return cn.consulta_codigo_producto(id);
        }
        public int Usuario_Sin_Foto(string id)
        {
            return cn.Usuario_SinFoto(id);
        }
        public int codigo_repetido_pedido(string id)
        {
            return cn.codigo_repetido_pedido(id);
        }
        public int codigo_repetido_detalle_pedido(string id)
        {
            return cn.codigo_repetido_detalle_pedido(id);
        }
        public int retornar_cantidad_detalle_producto(string id)
        {
            return cn.regresarcantidad_detallepedido(id);
        }
        public int consultaregistrodni(string dni)
        {
            return cn.consultaregistrodni(dni);
        }
    public int Consulta_codigo_Proveedor(string id)
        {
            return cn.consulta_codigo_proveedor(id);
        }
        public int Consulta_codigo_Compra(string id)
        {
            return cn.consulta_codigo_compra(id);
        }
        public int Consulta_codigo_Detalle_Compra(string id)
        {
            return cn.consulta_codigo_detalle_compra(id);
        }
        public int RetornarstockactualdelProducto(string id)
        {
            return cn.retornodelStockinicial(id);   
        }
        public double precio_total_pedido(string id_pedido)
        {
            return cn.precio_total(id_pedido);
        }
        public double precio_producto(string marca, string producto, string descripcion)
        {
            return cn.BuscarPrecio(marca, producto, descripcion);
        }
        public double RetornarPrecioProducto(string id)
        {
            return cn.retornaprecioproducto(id);
        }
        public double RetornarPrecioCompra(string id)
        {
            return cn.precio_total_compra(id);
        }
        public double precio_total_compraadmin(string id_compra)
        {
            return cn.precio_total_compra_paraadmin(id_compra);
        }
        public double Retornartotaldelascompras()
        {
            return cn.devolvertotaldelascompras();
        }
        public double Retornartotaldelasventas()
        {
            return cn.devolvertotaldelasventas();
        }
        public string getCodigo_DNI(string dni)
        {
            return cn.retornar_id_Cliente(dni);
        }
        public string retornar_producto_caracteristicas(string marca, string producto, string descripcion)
        {
            return cn.retornar_Codigo_Producto(marca, producto, descripcion);
        }
        public string BuscarNombreProveedor(string id)
        {
            return cn.BuscarNombreProveedor(id);
        }
        public string retornarDniProveedor(string idproveedor)
        {
            return cn.RetornarDnideProveedor(idproveedor);
        }
    }   
}
