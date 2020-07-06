using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppEmpleos
{
    public class Global : System.Web.HttpApplication
    {

        public static Usuario UsuarioActual;
        protected void Application_Start(object sender, EventArgs e)
        {
            Listas.Empresas.Add(new Empresa("Tottus","tottus@gmail.com","123",1,"1-1","supermercado","Empresa"));
            Listas.Empresas.Add(new Empresa("Lider", "lider@gmail.com", "123", 2, "1-2", "supermercado", "Empresa"));
            Listas.Empresas.Add(new Empresa("Jumbo", "jumbo@gmail.com", "123", 3, "1-3", "supermercado", "Empresa"));

            Listas.Postulantes.Add(new Usuario(1, "Juan","juan@gmail.com","123","Postulante"));
            Listas.Postulantes.Add(new Usuario(2, "Pablo", "pablo@gmail.com", "123", "Postulante"));
            Listas.Postulantes.Add(new Usuario(3, "Pepe", "pepe@gmail.com", "123", "Postulante"));

            Listas.Trabajos.Add(new Trabajo(5,1,"1 PRIMER TITULO DEL TRABAJO ES ESTE","NECESITAMOS GENTE, AYUDA"));
            Listas.Trabajos.Add(new Trabajo(6, 1, "2 SEGUNDO TITULO DEL TRABAJO ES ESTE", "NECESITAMOS GENTE, AYUDA"));
            Listas.Trabajos.Add(new Trabajo(7, 1, "3 TERCERO TITULO DEL TRABAJO ES ESTE", "NECESITAMOS GENTE, AYUDA"));
            Listas.Trabajos.Add(new Trabajo(8, 1, "4 CUARTO TITULO DEL TRABAJO ES ESTE", "NECESITAMOS GENTE, AYUDA"));



        }




        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}