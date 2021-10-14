using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new Curso(1, "Ing. Informática");
            Coordinador coordinador1 = new Coordinador("112233-4", "Claudio Montoya");
            coordinador1.Telefono = "+56955443322";
            coordinador1.Correo = "claudio.montoya1@virginiogomez.cl";

            curso1.Coordinador = coordinador1;

            Asignatura asignatura1 = new Asignatura(1, "Base de datos");
            Asignatura asignatura2 = new Asignatura(1, "Programación OO");
            Asignatura asignatura3 = new Asignatura(1, "Ingles II");
            Asignatura asignatura4 = new Asignatura(1, "Ingenieria de software");
            curso1.agregarAsignatura(asignatura1);
            curso1.agregarAsignatura(asignatura2);
            curso1.agregarAsignatura(asignatura3);
            curso1.agregarAsignatura(asignatura4);


            Sede sede1 = new Sede(10, "Concepción");
            sede1.Ciudad = "Concepción";

            Administrador administrador1 = new Administrador("124444-5", "Alicia Riquelme");
            administrador1.Telefono = "+56777543222";
            administrador1.Correo = "alicia.riquelme@virginiogomez.cl";
            sede1.Administrador = administrador1;

            sede1.agregarCurso(curso1);


            Console.WriteLine("Sede: " + sede1.Nombre);
            Console.WriteLine("Administrador: " + sede1.Administrador.Nombre);
            Console.WriteLine("Curso: " + sede1.listadoCurso()[0].Nombre);
            Console.WriteLine("N° Asignatura: " + sede1.listadoCurso()[0].cantidadAsignaturas());
            Console.ReadKey();


        }
    }
}
