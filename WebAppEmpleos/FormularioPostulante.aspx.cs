using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class FormularioPostulante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void agregarPostulante()
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string tipo = "Postulante";
            int id = Listas.Postulantes.Count + 1;

            Usuario nuevoUsuario = new Usuario(id,nombre, email, password, tipo);
            Listas.Postulantes.Add(nuevoUsuario);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            agregarPostulante();
            Response.Redirect("/Default.aspx");


        }
    }
}