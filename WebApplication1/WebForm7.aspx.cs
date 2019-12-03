using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listarpro();
        }
        productos objetoproductos = new productos();
        protected void eliminarProducto(object sender, GridViewCommandEventArgs e)
        {
            int FilaSeleccionada = int.Parse(e.CommandArgument.ToString());
           int  id = Convert.ToInt32(gvProductos.Rows[FilaSeleccionada].Cells[1].Text);

            objetoproductos.eliminarRegistro(id);
            Response.Redirect("WebForm7.aspx");
        }
        public void listarpro()
        {

            gvProductos.DataSource = objetoproductos.verTodosProductos();
            gvProductos.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}