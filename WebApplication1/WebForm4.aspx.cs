using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        conexionBD metodos = new conexionBD();
        WebForm1 objeto1 = new WebForm1();
        usuarios objetoUsuarios = new usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            metodos.insertarUsuario(txtNombre.Text, txtApellido.Text,txtCorreo.Text, txtPass.Text);
            DataTable tab = new DataTable();
            tab = metodos.logear(txtCorreo.Text,txtPass.Text);
            if (tab.Rows.Count.Equals(1))
            {
                string cadena ="Bienvenido "+ Convert.ToString(tab.Rows[0][1]) + Convert.ToString(tab.Rows[0][2]);
                string nombreUsuario = Convert.ToString(tab.Rows[0][1]) + Convert.ToString(tab.Rows[0][2]);
                Session["cadena"] = cadena;
                objetoUsuarios.recopilandoDatos(nombreUsuario);

            }
            else
            {
                string cadena = "error en pass o user";
                Session["cadena"] = cadena;
                //      ;
            }

            Response.Redirect("WebForm2.aspx");
            txtApellido.Text = " ";
            txtCorreo.Text = " ";
            txtPass.Text = " ";
            txtNombre.Text = " ";

            //crear guardar solo usuario
        }

        protected void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}