using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class usuarios
    {
        conexionBD objetoConexion = new conexionBD();
        SqlCommand comando = new SqlCommand();

        SqlDataReader leer;

        public void recopilandoDatos(string usuarioNombre)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "sistemaAvance1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuarioCompra", usuarioNombre);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public DataTable ultimoRegistroHecho()
        {
            DataTable tabla = new DataTable();


            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "ultimoRegistroHecho";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }
        public void addCompra(string usuarioCompra,string producto,int cantidadProductos,float precio,float totalPagar)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "addCompra1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuarioCompra",usuarioCompra);
            comando.Parameters.AddWithValue("@producto",producto);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidadProductos", cantidadProductos);
            comando.Parameters.AddWithValue("@totalPagar", totalPagar);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            

        }
        public void eliminarDatos()
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "eliminarDatos";
         
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public DataTable m()
        {
            DataTable tabla = new DataTable();


            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM usuarioProducto";
            //comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }
        public DataTable totalPagar()
        {
            DataTable tabla = new DataTable();


            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "totalPagar1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }



        public DataTable Factura()
        {
            DataTable tabla = new DataTable();


            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "factura1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }
        public void verTodasLasCompras(int idUsuario)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "idListado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id",idUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


    }
}