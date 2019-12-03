using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        productos objetoProductos = new productos();
        usuarios objetoUsuarios = new usuarios();
        ventas vEvento = new ventas();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarProductos();
            }
           
        }
        public void ListarProductos()
        {
           
           

            gvDatos.DataSource = objetoProductos.verTodosProductos();
            gvDatos.DataBind();
        }

        protected void seleccionderegistro(object sender, GridViewCommandEventArgs e)
        {
          

            int FilaSeleccionada = int.Parse(e.CommandArgument.ToString());
         
            vEvento.vistaProducto(Convert.ToInt32(gvDatos.Rows[FilaSeleccionada].Cells[5].Text));

            gvApoyo.DataSource = objetoUsuarios.m();
            gvApoyo.DataBind();

            string nombreUsuario = gvApoyo.Rows[0].Cells[1].Text;

            if (Convert.ToInt32(gvDatos.Rows[FilaSeleccionada].Cells[5].Text)> 0)
            {
                int resta;
                int suma=0;
                int id = Convert.ToInt32(gvDatos.Rows[FilaSeleccionada].Cells[1].Text);

                int valor = (Convert.ToInt32(gvDatos.Rows[FilaSeleccionada].Cells[5].Text));
                resta = valor - 1;
                //cantidad
                suma += 1;
                //editar dismunye campo
                vEvento.comprarProducto(id, resta);
                string productoNombre = gvDatos.Rows[FilaSeleccionada].Cells[2].Text;

                int precio = Convert.ToInt32(gvDatos.Rows[FilaSeleccionada].Cells[4].Text);

                
                float resultadoTotal = precio * suma;



                

               objetoUsuarios.addCompra(nombreUsuario,productoNombre,suma,precio,resultadoTotal);

                Response.Redirect("WebForm6.aspx");
            }else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script> alert('No hay existencias');</script>");
            }
            

        }

        protected void btnFin_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm8.aspx");
        }


        
    }


}