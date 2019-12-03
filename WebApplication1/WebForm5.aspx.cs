using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        productos objetoproductos = new productos();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button6.Visible = false;
            btnAplicarModificar.Visible = false;
            gvProductos.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
     
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("WebForm7.aspx");
        }

      protected void btnModificar_Click(object sender, EventArgs e)
        {
       
            listarpro();
            btnAlta.Visible = false;
        }
        
        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
          //  

        }
        public void listarpro()
        {

            gvProductos.DataSource =objetoproductos.verTodosProductos();
            gvProductos.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            //obtener datos de la imagen
            int tamanio = fuploadimagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[tamanio];
            fuploadimagen.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio);
            Bitmap ImagenOriginalBinaria = new Bitmap(fuploadimagen.PostedFile.InputStream);

            //insertar en la bd
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);
            imgPreview.ImageUrl = ImagenDataURL64;


            objetoproductos.insertarProducto(ImagenOriginal,txtProductos.Text,txtCodigo.Text,float.Parse(txtPrecio.Text),float.Parse( txtDisponibles.Text));
            txtCodigo.Text = " ";
            txtDisponibles.Text = " ";
            txtPrecio.Text = " ";
            txtProductos.Text = " ";


        }

        protected void gvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int FilaSeleccionada = int.Parse(e.CommandArgument.ToString());
            id= Convert.ToInt32(gvProductos.Rows[FilaSeleccionada].Cells[1].Text);
            objetoproductos.traerProducto(id);
            txtProductos.Text = gvProductos.Rows[FilaSeleccionada].Cells[2].Text;
            txtCodigo.Text = gvProductos.Rows[FilaSeleccionada].Cells[3].Text;
            txtPrecio.Text  = gvProductos.Rows[FilaSeleccionada].Cells[4].Text;
            txtDisponibles.Text = gvProductos.Rows[FilaSeleccionada].Cells[5].Text;

            Label7.Text = Convert.ToString(id);
            btnAlta.Visible = false;
            btnAplicarModificar.Visible = true;
          
        }
       
            
           

        

        protected void btnAplicarModificar_Click(object sender, EventArgs e)
        {
            btnAlta.Visible = false;
            int id =Convert.ToInt32( Label7.Text);
            objetoproductos.modificaProducto(id, txtProductos.Text, txtCodigo.Text,float.Parse(txtPrecio.Text), float.Parse(txtDisponibles.Text));
            gvProductos.DataBind();
            gvProductos.Visible = true;
            btnAplicarModificar.Visible = true;

            Response.Redirect("WebForm5.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
             int id=Convert.ToInt32(Label7.Text);
             objetoproductos.eliminarRegistro(id);
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}