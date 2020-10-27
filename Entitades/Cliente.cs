using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Cliente
    {
        private string correoElectronico;
        private string domicilio;
        private int nroTelefono;


        public Cliente()
        {

        }
        #region Propiedades

        /// <summary>
        /// Devuelve el correo electronico 
        /// </summary>
        public string CorreoElectronico
        {
            get { return this.correoElectronico; }
            set { this.correoElectronico = value; } 
    }
        /// <summary>
        /// Devuelve el domicilio
        /// </summary>
        public string Domicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }

        }
        /// <summary>
        /// Devuelve el numero de telefono 
        /// </summary>
        public int NroTelefono
        {
            get { return this.nroTelefono; }

            set { this.nroTelefono = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de un Cliente
        /// </summary>
        /// <param name="nombre">Nombre Cliente</param>
        /// <param name="apellido">Apellido Cliente</param>
        /// <param name="dni">Dni Cliente</param>
        /// <param name="correoElectronico">Correo eletronico del cliente</param>
        /// <param name="domicilio">Domicilio del cliente</param>
        /// <param name="nroTelefono">Nro de telefono del cliente</param>
        public Cliente(string nombre, string apellido, int dni, string correoElectronico, string domicilio, int nroTelefono) : this(nombre, apellido, dni)
        {
            this.correoElectronico = correoElectronico;
            this.domicilio = domicilio;
            this.nroTelefono = nroTelefono;
        }
        protected Cliente(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
        }

        #endregion

        /// <summary>
        ///  Sobrecarga metodo toString ( en realidad sigue existiendo pero le doy otra funcionalidad )
        /// </summary>
        /// <returns> Retorna un cliente con los datos de un cliente formateados </returns>
        public override string ToString()
        {
            // implemento del metodo to string en clase derivada  

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Correo Electronico : " + this.correoElectronico + " - " + "Domicilio : " + this.domicilio + " - " + "Telefono : " + this.nroTelefono);

            return sb.ToString();
        }

        private string nombre;
        private string apellido;
        private int dni;

        #region Propiedades
        /// <summary>
        /// Devuelve el nombre de la persona 
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// Devuelve el apellido de la persona
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// Devuelve el dni de la persona y permite asignarlo
        /// </summary>

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public  string Saludar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" y fui el Cliente.");

            return sb.ToString();
        }
        #endregion

    }
}

