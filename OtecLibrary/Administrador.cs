using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class Administrador
    {
        private string rut;
        private string nombre;
        private string correo;
        private string telefono;

        //constructor
        public Administrador()
        {

        }
        public Administrador(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }
        //metodos
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
