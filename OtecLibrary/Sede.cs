using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class Sede
    {
        private int codigo;
        private string nombre;
        private string ciudad;
        private Administrador administrador;
        private List<Curso> cursos;


        //constructor
        public Sede()
        {
            cursos = new List<Curso>();
        }
        public Sede(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            cursos = new List<Curso>();
        }
        //metodos
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }

        public string agregarCurso(Curso micurso)
        {
            try
            {
                if (cursos.Where(x => x.Nombre == micurso.Nombre).Count() >= 1)
                {
                    return "El curso ya existel!!";
                } 
                cursos.Add(micurso);
                return "Curso ingresado";
            }
            catch (Exception e)
            {
                return "Error Inesperado al agregar un nuevo curso error:" + e.Message;
            }

        }

        public List<Curso> listadoCurso()
        {
            return cursos;
        }

        public int cantidadCursos()
        {
            return cursos.Count;
        }

    }
}
