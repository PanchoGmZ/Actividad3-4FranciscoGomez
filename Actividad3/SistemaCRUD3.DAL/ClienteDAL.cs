using SistemaCRUD3.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCRUD3.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from clientes";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarClienteDal(Clientes cliente)
        {
            string consulta = "insert into clientes values('" + cliente.Nombre + "'," +
                                                         "'" + cliente.Apellido + "'," +
                                                         "'" + cliente.Correo + "'," +
                                                         "'" + cliente.Telefono+ "'," +
                                                         "'" + cliente.Direccion +
                                                         "')";
            conexion.Ejecutar(consulta);
        }

        public Clientes ObtenerClienteId(int id)
        {
            string consulta = "select * from clientes where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Clientes cliente = new Clientes();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["apellido"].ToString();
                cliente.Correo = tabla.Rows[0]["correo"].ToString();
                cliente.Telefono = tabla.Rows[0]["telefono"].ToString();
                cliente.Direccion = tabla.Rows[0]["direccion"].ToString();

            }
            return cliente;
        }

        public void EditarClienteDal(Clientes cliente)
        {
            string consulta = "update clientes set nombre='" + cliente.Nombre + "'," +
                                                 "apellido='" + cliente.Apellido + "'," +
                                                 "correo='" + cliente.Correo + "', " +
                                                 "telefono='" + cliente.Telefono + "'," +
                                                 "direccion='" + cliente.Direccion + "'" +                                                 
                               "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from clientes where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
