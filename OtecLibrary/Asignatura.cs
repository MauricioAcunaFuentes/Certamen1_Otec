using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
   public class Asignatura
    {
        private int codigo;
        private string nombre;

        //constructor
        public Asignatura()
        {

        }
        public Asignatura(int codigo,string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        //metodos
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }
}
