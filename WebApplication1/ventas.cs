using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
 //   conexionBD objetoconexion = new conexionBD();
    public class ventas
    {
        conexionBD objetoConexion = new conexionBD();
        SqlCommand comando = new SqlCommand();

        SqlDataReader leer;

        public void comprarProducto(int idProducto,float disponibles)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "comprarProducto4";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@disponibles", disponibles);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();



        }
        public DataTable vistaProducto(int idProducto)
        {
            DataTable tabla = new DataTable();

            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM productos WHERE idProducto='" + idProducto + "' ";
            // comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;

        }

    }
}