using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        conexionBD objetoconexion = new conexionBD();
        usuarios objetoUsuarios = new usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table=objetoconexion.logear(txtCorreo.Text, txtPass.Text);
            if (table.Rows.Count.Equals(1))
            {
                string cadena ="Bienvenido "+Convert.ToString( table.Rows[0][1])+" " +Convert.ToString( table.Rows[0][2]);
                string nombreUsuario = Convert.ToString(table.Rows[0][1]) + " " + Convert.ToString(table.Rows[0][2]);
                objetoUsuarios.recopilandoDatos(nombreUsuario);

                Session["cadena"] = cadena;

                Response.Redirect("WebForm2.aspx");


            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(),"Scripts","<script> alert('Error en Correo o Usuario');</script>");
               
             
                //      ;
            }


            //Crear un guardar solo el usuario
            //  Session["contrase"] = table.Rows[0][2];
            txtCorreo.Text = " ";
            txtPass.Text = " ";

        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}