using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class PublicarTrabajo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            publicarTrabajo();
            Response.Redirect("/Trabajos.aspx");

        }

        public void publicarTrabajo()
        {
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            int idEmpresa = Global.UsuarioActual.getId();
            int id = Listas.Trabajos.Count+1;


            Trabajo nuevoTrabajo = new Trabajo(id,idEmpresa,titulo,descripcion);            
            Listas.Trabajos.Add(nuevoTrabajo);
        }
    }
}