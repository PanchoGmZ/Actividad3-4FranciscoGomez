using SistemaCRUD3.DAL;
using SistemaCRUD3.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCRUD3.BSS
{
    public class PedidoBss
    {
        PedidoDAL dal = new PedidoDAL();
        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }

        public void InsertarPedidoBss(Pedidos pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public Pedidos ObtenerIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(Pedidos pedido)
        {
            dal.EditarPedidoDal(pedido);
        }

        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
