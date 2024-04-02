using SistemaCRUD3.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCRUD3.DAL
{
    public class PedidoDAL
    {
        public DataTable ListarPedidoDal()
        {
            string consulta = "SELECT PEDIDO.IDPEDIDO, CLIENTES.NOMBRE, CLIENTES.APELLIDO, PEDIDO.FECHA, PEDIDO.TOTAL, PEDIDO.ESTADO\r\nFROM CLIENTES INNER JOIN\r\nPEDIDO ON CLIENTES.IDCLIENTE = PEDIDO.IDCLIENTE";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPedidoDal(Pedidos pedidos)
        {
            string consulta = "insert into pedido values(" + pedidos.Total + "," +
                                                         "'" + pedidos.Fecha + "'," +
                                                         "'" + pedidos.Estado + 
                                                         "')";
            conexion.Ejecutar(consulta);
        }

        public Pedidos ObtenerPedidoId(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
             Pedidos pedido = new Pedidos();
            if (tabla.Rows.Count > 0)
            {
                pedido.IdPedido = Convert.ToInt32(tabla.Rows[0]["idpedido"]);
                pedido.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                pedido.Total = Convert.ToInt32(tabla.Rows[0]["total"]);
                pedido.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return pedido;
        }

        public void EditarPedidoDal(Pedidos pedido)
        {
            string consulta = "update pedido set fecha='" + pedido.Fecha + "'," +
                                                 "total=" + pedido.Total + "," +
                                                 "direccion='" + pedido.Estado +"'" +
                               "where idpedido=" + pedido.IdPedido;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idpedido=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
