using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
   
    public partial class Site1 : System.Web.UI.MasterPage
    {
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Global.UsuarioActual == null))
            {
                ObtenerDatos();
            }

        }
       
        public void ObtenerDatos()
        {
            string nombre = Global.UsuarioActual.getNombre();
            lblUsuario.Text = nombre;
            lblEmpresa.Text = nombre;

        }

        protected void lnk1Logout_Click(object sender, EventArgs e)
        {
            salir();
        }

        protected void lnk2Logout_Click(object sender, EventArgs e)
        {
            salir();
        }
    
        public void salir()
        {
            Global.UsuarioActual = null;
            Response.Redirect("/Default.aspx");
        }
    
    }
}
