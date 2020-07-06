using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpleos
{

    public class Trabajo
    {
        private int id;
        private string titulo;
        private string descripcion;
        private int idEmpresa;


        public Trabajo(int id, int idEmpresa, string titulo, string descripcion)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.idEmpresa = idEmpresa;
        }

    

        public int Id { get => id; set => id = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }


}