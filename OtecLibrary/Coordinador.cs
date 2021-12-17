using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class Coordinador
    {
        private string rut;
        private string nombre;
        private string correo;
        private string telefono;

        //constructor
        public Coordinador()
        {

        }
        public Coordinador(string rut,string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }
        public Coordinador(string rut, string nombre,string correo,string telefono)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }
        //metodos
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
