using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppEmpleos
{
    public partial class Trabajos : System.Web.UI.Page
    {
        public static List<Trabajo> lista = new List<Trabajo>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        public void ValoresCamposInicio(int i)
        {
            int idEmpresa = Listas.Trabajos[i].IdEmpresa;
            string nombreEmpresa = getNombreEmpresa(idEmpresa);
            string titulo = Listas.Trabajos[i].Titulo;
            string descripcion = Listas.Trabajos[i].Descripcion;
            lblTrabajoTitulo.Text = titulo;
            lblTrabajoDescripcion.Text = descripcion;
            lblNombreEmpresa.Text = nombreEmpresa;

        }

        public void ValoresCamposBusqueda(int i)
        {
            int idEmpresa = lista[i].IdEmpresa;
            string nombreEmpresa = getNombreEmpresa(idEmpresa);
            string titulo = lista[i].Titulo;
            string descripcion = lista[i].Descripcion;
            lblBuscarTitulo.Text = titulo;
            lblBsucarDescripcion.Text = descripcion;
            lblBuscarNombre.Text = nombreEmpresa;
        }

        public List<Trabajo> GetListaTrabajos()
        {
            return Listas.Trabajos;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text;
            lista.Clear();

            foreach (Trabajo tb in Listas.Trabajos)
            {
                if (tb.Titulo.ToUpper().Contains(termino.ToUpper()) )
                {
                    lista.Add(tb);
                }
            }
           
        }

        public string getNombreEmpresa(int id)
        {
            string nombre = "";
            foreach(Empresa emp in Listas.Empresas)
            {
                if(emp.getId().Equals(id))
                {
                    nombre = emp.getNombre();
                    return nombre;
                }
            }
            return null;
        }

        protected void btnPostular_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPostular_Click(object sender, EventArgs e)
        {

        }


        
    }
}