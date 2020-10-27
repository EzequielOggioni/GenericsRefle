using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Empleado
    {
           private string nombre;
           private string appellido;
           private int legajo      ;
           private string user     ;
           private string pass     ;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.appellido; }
            set { this.appellido = value; }
        }
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public string User
        {
            get { return this.user; }
            set { this.user = value; }
        }
        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public Empleado()
        {

        }
        public Empleado(string nombre, string appellido, int legajo, string user, string pass)
        
        {
            this.nombre   = nombre;
            this.appellido= appellido;
            this.legajo      = legajo;
            this.user     = user;
            this.pass     = pass;

        }
    }
}
