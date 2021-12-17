using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OtecLibrary;

namespace ClaseDatos
{
    public class AsignaturaData
    {

        Datos data = new Datos();
        //metodos
        public List<Asignatura> listado()
        {
            //realiza la consulta a la bd y almacena en un dataset
            DataSet respuesta= data.listado("select * from ar_ma_asignatura");

            //declaramos una lista de asignaturas, que será la que devolvemos
            List<Asignatura> listadoAsignatura = new List<Asignatura>();

            //recorremos la tabla del dataset
            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                //declaramos una nueva instancia asignatura y utilizamos el constructor con variables (sobrecarga)
                Asignatura asig = new Asignatura(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString());
                //insertamos la asignatura en la lista
                listadoAsignatura.Add(asig);
            }
            //devolvemos la lista
            return listadoAsignatura;
        }

        //sobrecarga para consultar una asignatura en particular
        public List<Asignatura> listado(int codigo)
        {
            //realiza la consulta a la bd y almacena en un dataset
            DataSet respuesta = data.listado("select * from ar_ma_asignatura where codigo='" + codigo.ToString() + "'");

            //declaramos una lista de asignaturas, que será la que devolvemos
            List<Asignatura> listadoAsignatura = new List<Asignatura>();

            //recorremos la tabla del dataset
            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                //declaramos una nueva instancia asignatura y utilizamos el constructor con variables (sobrecarga)
                Asignatura asig = new Asignatura(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString());
                //insertamos la asignatura en la lista
                listadoAsignatura.Add(asig);
            }
            //devolvemos la lista
            return listadoAsignatura;
        }

        
        public int buscaExiste(int codigo)
        {
            return Convert.ToInt32(data.listado("select count(*) cantidad from ar_ma_asignatura where codigo='" + codigo.ToString() + "'").Tables[0].Rows[0].ItemArray[0]);
        }

        public int guardar(Asignatura asig)
        {
            return data.ejecutar("insert into ar_ma_asignatura(codigo,nombre) values('" + asig.Codigo.ToString() + "','" + asig.Nombre + "')");
        }
        public int editar(Asignatura asig)
        {
            return data.ejecutar("update ar_ma_asignatura set nombre='" + asig.Nombre + "' where codigo='" + asig.Codigo.ToString() + "'");
        }
        public int eliminar(int codigo)
        {
            return data.ejecutar("DELETE FROM ar_ma_asignatura WHERE codigo= '" + codigo.ToString() + "'");
        }
    }
}
