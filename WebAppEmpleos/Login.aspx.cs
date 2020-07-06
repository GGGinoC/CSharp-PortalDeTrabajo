using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPassword.Text;

            if(confirmarUsuario(email, pass))
            {

                Response.Redirect("/Default.aspx");
            }

            

        }
        
        public Boolean confirmarUsuario(string email, string pass)
        {
            foreach(Empresa usr in Listas.Empresas)
            {
                if (usr.getEmail().Equals(email))
                {
                    
                    if(usr.getPassword().Equals(pass))
                    {
                        Global.UsuarioActual = usr;
                        return true;

                    }
                }
            }

            foreach (Usuario usr in Listas.Postulantes)
            {
                if (usr.getEmail().Equals(email))
                {
                    if (usr.getPassword().Equals(pass))
                    {
                        Global.UsuarioActual = usr;
                        return true;
                    }
                }
            }

            return false;
        }
    
    }
}