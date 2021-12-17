using OtecLibrary;
using ClaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebOtec.Models;

namespace WebOtec.Controllers
{
    public class CoordinadorController : ApiController
    {

        [HttpGet]
        [Route("api/v1/get_coordinador")]
        public respuesta listar(string rut = "")
        {

            respuesta resp = new respuesta();
            try
            {
                List<Coordinador> listado = new List<Coordinador>();
                CoordinadorData datos = new CoordinadorData();

                listado = rut == "" ? datos.listado() : datos.listado(rut);

                //operacion correcta 
                resp.error = false;
                resp.mensaje = "ok";
                if (listado.Count > 0)
                    resp.data = listado;
                else
                    resp.data = "No se encontro coordinador";
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
        [Route("api/v1/set_coordinador")]
        public respuesta guardar(Coordinador coordinador)
        {
            respuesta resp = new respuesta();
            try
            {
                CoordinadorData datos = new CoordinadorData();
                
                int estado = datos.guardar(coordinador);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "coordinador ingresado";
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
        [Route("api/v1/delete_coordinador")]
        public respuesta eliminar(string rut)
        {
            respuesta resp = new respuesta();

            try
            {

                CoordinadorData datos = new CoordinadorData();
                int estado = datos.eliminar(rut);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "coordinador eliminado";
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
        [Route("api/v1/edit_coordinador")]
        public respuesta editar(Coordinador coordinador)
        {
            respuesta resp = new respuesta();
            try
            {
                CoordinadorData datos = new CoordinadorData();

                int estado = datos.editar(coordinador);

                if (estado == 1)
                {
                    resp.error = false;
                    resp.mensaje = "coordinador editado";
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
