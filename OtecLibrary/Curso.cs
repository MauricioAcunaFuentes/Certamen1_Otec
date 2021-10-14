using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
   public class Curso
    {
        private int codigo;
        private string nombre;
        private Coordinador coordinador;
        private List<Asignatura> asignaturas;
        //constructor
        public Curso()
        {
            asignaturas = new List<Asignatura>();
        }
        public Curso(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            asignaturas = new List<Asignatura>();
        }
        //metodos
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Coordinador Coordinador { get => coordinador; set => coordinador = value; }

        public string agregarAsignatura(Asignatura nueva_asignatura)
        {
            try
            {
                if (asignaturas.Where(x => x.Nombre == nueva_asignatura.Nombre).Count() >= 1)
                {
                    return "La asignatura ya existel!!";
                }
                asignaturas.Add(nueva_asignatura);
                return "Asignatura ingresada";
            }
            catch (Exception e)
            {
                return "Error Inesperado al agregar una nueva Asignatura error:" + e.Message;
            }

        }

        public List<Asignatura> listadoAsignatura()
        {
            return asignaturas;
        }

        public int cantidadAsignaturas()
        {
            return asignaturas.Count;
        }


    }
}
