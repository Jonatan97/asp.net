using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace WebApplication1
{

  
    public class productos
    {
        conexionBD objetoConexion = new conexionBD();
        SqlCommand comando = new SqlCommand();

        SqlDataReader leer;

        public void insertarProducto(byte[] imagen,string nombreProducto,string codigo,float precio,float disponibles)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "altaProducto1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@imagen", imagen);
            comando.Parameters.AddWithValue("@nombreProducto", nombreProducto);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@disponibles", disponibles);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void imagenVista(Image imagen,int id)
        {

            
       
            SqlCommand co = new SqlCommand("SELECT imagen FROM productos WHERE idProducto='" + id + "';",objetoConexion.AbrirConexion());
            //comando.Parameters.AddWithValue("@idP",id);
            SqlDataAdapter dp = new SqlDataAdapter();
            // comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet("productos");

            dp.Fill(ds, "productos");
            
            byte[] datosd = new byte[0];

            DataRow DR = ds.Tables["productos"].Rows[0];
            datosd = (byte[])DR["productos"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datosd);
           
     
        }
        public DataTable traerProducto(int idProducto)
        {
            DataTable tabla = new DataTable();

            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM productos WHERE idProducto='"+idProducto+"' ";
           // comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;

        }
        public void eliminarRegistro(int idProducto)
        {
            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "eliminarProducto";
            comando.Parameters.AddWithValue("@idProducto",idProducto);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public DataTable modificaProducto(int idProducto, string nombreProducto, string codigo, float precio, float disponibles)
        {
            DataTable tabla = new DataTable();

            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "modificarProducto1";
            comando.Parameters.AddWithValue("@idProducto",idProducto);
        
            comando.Parameters.AddWithValue("@nombreProducto",nombreProducto);
            comando.Parameters.AddWithValue("@codigo",codigo);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@disponibles",disponibles);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;

        }
        public DataTable verTodosProductos()
        {
            DataTable tabla=new DataTable();

            comando.Connection = objetoConexion.AbrirConexion();
            comando.CommandText = "verTodosProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
            
        }
    }
}