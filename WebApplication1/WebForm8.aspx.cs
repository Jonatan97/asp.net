using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        usuarios objetoUsuario = new usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            listar();
            listarPagar();

        }

      public void listar()
        {
            gvFormato.DataSource = objetoUsuario.Factura();
            //gvFormato.Columns[0].HeaderText = "Nombre de Usuario";

            DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        protected void btnReporte_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=factura.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            gvFormato.AllowPaging = false;
            gvFormato.DataBind();
            gvFormato.RenderControl(hw);
            gvPagar.AllowPaging = false;
            gvPagar.DataBind();
            gvPagar.RenderControl(hw);
            
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }

        public void listarPagar()
        {
          gvPagar.DataSource = objetoUsuario.totalPagar();
            //gvFormato.Columns[0].HeaderText = "Nombre de Usuario";

            DataBind();
        }
        protected void btnPagar_Click(object sender, EventArgs e)
        {


            objetoUsuario.eliminarDatos();

            

        }
    }
}