using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmpleos
{
    public class Usuario
    {
        protected string nombre;
        protected string email;
        protected string password;
        protected string tipo;
        protected int id;

        public Usuario(int id, string nombre, string email, string password, string tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.tipo = tipo;
        }

        public Usuario()
        {

        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPassword()
        {
            return this.password;
        }
        
        public string getTipo()
        {
            return this.tipo;
        }
        
        public int getId()
        {
            return this.id;

        }
        
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }


    }

    public class Empresa : Usuario
    {
        private string rut;
        private string industria;
        private List<int> trabajosEmpresa = new List<int>();

        public Empresa(string nombre, string email, string password, int id, string rut, string industria,string tipo)
        {
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.id = id;
            this.rut = rut;
            this.industria = industria;
            this.tipo = tipo;
        }
    

        public string getRut()
        {
            return this.rut;
        }

        public string getIndustria()
        {
            return this.industria;
        }

        public List<int> lista
        {
            get { return trabajosEmpresa; }
        }
    

}
}