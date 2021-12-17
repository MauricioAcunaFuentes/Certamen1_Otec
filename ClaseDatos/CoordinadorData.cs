using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OtecLibrary;

namespace ClaseDatos
{
    public class CoordinadorData
    {
        Datos data = new Datos();
        //metodos
        public List<Coordinador> listado()
        {
            //realiza la consulta a la bd y almacena en un dataset
            DataSet respuesta = data.listado("select * from ar_ma_coordinador");

            //declaramos una lista de asignaturas, que será la que devolvemos
            List<Coordinador> listadoCoordinador = new List<Coordinador>();

            //recorremos la tabla del dataset
            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                //declaramos una nueva instancia asignatura y utilizamos el constructor con variables (sobrecarga)
                Coordinador asig = new Coordinador(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString());
                //insertamos la asignatura en la lista
                listadoCoordinador.Add(asig);
            }
            //devolvemos la lista
            return listadoCoordinador;
        }

        //sobrecarga para consultar un coordinador en particular
        public List<Coordinador> listado(string rut)
        {
            //realiza la consulta a la bd y almacena en un dataset
            DataSet respuesta = data.listado("select * from ar_ma_coordinador where rut='" +  rut +  "'");

            //declaramos una lista de asignaturas, que será la que devolvemos
            List<Coordinador> listadoCoordinador = new List<Coordinador>();

            //recorremos la tabla del dataset
            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                //declaramos una nueva instancia asignatura y utilizamos el constructor con variables (sobrecarga)
                Coordinador asig = new Coordinador(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString());
                //insertamos la asignatura en la lista
                listadoCoordinador.Add(asig);
            }
            //devolvemos la lista
            return listadoCoordinador;
        }
         


        public int buscaExiste(string rut)
        {
            return Convert.ToInt32(data.listado("select count(*) cantidad from ar_ma_coordinador where rut='" + rut + "'").Tables[0].Rows[0].ItemArray[0]);
        }

        public int guardar(Coordinador coo)
        {
            return data.ejecutar("insert into ar_ma_coordinador(rut,nombre,correo,telefono) values('" + coo.Rut + "','" + coo.Nombre + "','" + coo.Correo + "','" + coo.Telefono + "')");
        }

        public int editar(Coordinador coo)
        {
            return data.ejecutar("update ar_ma_coordinador set nombre='" + coo.Nombre + "',correo='" + coo.Correo + "',telefono='" + coo.Telefono + "' where rut='" + coo.Rut + "'");
        }
        public int eliminar(string rut)
        {
            return data.ejecutar("DELETE FROM ar_ma_coordinador WHERE rut= '" + rut + "'");
        }
    }
}
