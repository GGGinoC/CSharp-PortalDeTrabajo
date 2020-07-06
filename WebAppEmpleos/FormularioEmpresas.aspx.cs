using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class FormularioEmpresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void agregarEmpresa()
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string tipo = "Empresa";
            string rut = txtRut.Text;
            string industria = txtIndustria.Text;
            int id = Listas.Empresas.Count + 1;

            Empresa nuevaEmpresa = new Empresa(nombre, email, password, id, rut, industria,tipo);
            Listas.Empresas.Add(nuevaEmpresa);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            agregarEmpresa();
            Response.Redirect("/Default.aspx");

        }
    }
}