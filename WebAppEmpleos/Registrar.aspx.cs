using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPostulante_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/FormularioPostulante.aspx");

        }

        protected void btnEmpresa_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/FormularioEmpresas.aspx");

        }
    }

}