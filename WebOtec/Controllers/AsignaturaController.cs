using ClaseDatos;
using OtecLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebOtec.Models;

namespace WebOtec.Controllers
{
    public class AsignaturaController : ApiController
    {

        [HttpGet]
        [Route("api/v1/get_asignatura")]
        public respuesta listar(int codigo=0)
        {

            respuesta resp = new respuesta();
            try
            {
                List<Asignatura> listado = new List<Asignatura>();
                AsignaturaData datos = new AsignaturaData();

                listado = codigo == 0 ? datos.listado() : datos.listado(codigo);

                //operacion correcta 
                resp.error = false;
                resp.mensaje = "ok";
                if (listado.Count > 0)
                    resp.data = listado;
                else
                    resp.data = "No se encontro asignatura";
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }


        [HttpPost]
        [Route("api/v1/set_asignatura")]
        public respuesta guardar(Asignatura asignatura)
        {
            respuesta resp = new respuesta();
            try
            {
                AsignaturaData datos = new AsignaturaData();

                int estado = datos.guardar(asignatura);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "asignatura ingresado";
                    resp.data = null;
                }
                else
                {
                    resp.error = true;
                    resp.mensaje = "No se realizo el ingreso";
                    resp.data = null;
                }
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }



        [HttpDelete]
        [Route("api/v1/delete_asignatura")]
        public respuesta eliminar(int codigo)
        {
            respuesta resp = new respuesta();

            try
            {

                AsignaturaData datos = new AsignaturaData();
                int estado = datos.eliminar(codigo);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "asignatura eliminado";
                    resp.data = null;
                }
                else
                {
                    resp.error = true;
                    resp.mensaje = "No se realizo la eliminacion";
                    resp.data = null;
                }
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }


        [HttpPost]
        [Route("api/v1/edit_asignatura")]
        public respuesta editar(Asignatura asignatura)
        {
            respuesta resp = new respuesta();
            try
            {
                AsignaturaData datos = new AsignaturaData();

                int estado = datos.editar(asignatura);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "asignatura editado";
                    resp.data = null;
                }
                else
                {
                    resp.error = true;
                    resp.mensaje = "No se realizo la edición";
                    resp.data = null;
                }
                return resp;
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = "Error:" + e.Message;
                resp.data = null;
                return resp;
            }
        }


    }
}
