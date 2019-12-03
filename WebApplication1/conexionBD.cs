using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace WebApplication1
{
   
    class conexionBD{
        SqlCommand comando = new SqlCommand();
       
        SqlDataReader leer;
        SqlConnection conexion = new SqlConnection("server=DESKTOP-LOL40QT; database=usuariosNet2; integrated security=true");
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public DataTable logear(string correo,string pass)
        {
            DataTable tabla = new DataTable();
            comando.Connection = AbrirConexion();
            comando.CommandText = "logine"; /*"Select*from usuaurios WHERE correo='" + correo+"'AND pass='"+pass+"'"*/;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@correo",correo);
            comando.Parameters.AddWithValue("@pass",pass);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CerrarConexion();
          
            return tabla;

        }
        public void insertarUsuario(string nombre, string apellido,string correo, string pass)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "insertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}