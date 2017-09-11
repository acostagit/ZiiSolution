using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using ZiiSolution.ZiiSensor.Dominio.Entidade;

namespace ZiiSolution.Api.Controllers
{
    public class TemperaturaController : ApiController
    {
        HttpClient client = new HttpClient();
        ////public IHttpActionResult Get(int id)
        ////{
        ////    ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

        ////    var retorno = negocio.GetTemperatura(id);

        ////    if (retorno != null)
        ////        return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, retorno));
        ////    else
        ////        return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Temperatura não localizada."));


        ////    //return retorno;
        ////}


        //[FromBody]
       // [HttpPost]
        public string Post([FromBody] Temperatura temperatura)
        {
            try
            {
                ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();
                negocio.Incluir(temperatura);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return "sucesso";
        }

        ////[HttpPost]
        ////public async void Incluir([FromBody] ZiiSensor.Dominio.Entidade.Temperatura temperatura)
        ////{
        ////    try
        ////    {
        ////        ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

        ////        var response = await client.PostAsJsonAsync("/api/temperatura/", temperatura);

        ////        //negocio.Incluir(temperatura);

        ////        response.EnsureSuccessStatusCode();
        ////    }
        ////    catch (Exception ex)
        ////    {

        ////        throw new Exception(ex.Message);
        ////    }
        ////}

        public HttpResponseMessage GetTemperatura(int id)
        {
            ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

            ZiiSensor.Dominio.Entidade.Temperatura temperatura = negocio.GetTemperatura(id);

            if (temperatura == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Temperatura não localizado para o Id informado");
            }
            else
            {
                return Request.CreateResponse<ZiiSensor.Dominio.Entidade.Temperatura>(HttpStatusCode.OK, temperatura);
            }
        }

        ////public List<ZiiSensor.Dominio.Entidade.Temperatura> GetAllTemperatura()
        ////{
        ////    List<ZiiSensor.Dominio.Entidade.Temperatura> lista = new List<ZiiSensor.Dominio.Entidade.Temperatura>();

        ////    ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

        ////    lista = negocio.GetAllTemperatura();

        ////    if (lista == null)
        ////        return null;
        ////    //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Temperaturas não localizado para o Id informado");
        ////    //}
        ////    //else
        ////    //{
        ////    //    return Request.CreateResponse<List<ZiiSensor.Dominio.Entidade.Temperatura>>(HttpStatusCode.OK, lista, Configuration.Formatters.JsonFormatter);
        ////    //}

        ////    return lista;
        ////}

        ////public System.Web.Http.Results.JsonResult<ZiiSensor.Dominio.Entidade.Temperatura> GetAllTemperatura()
        ////{
        ////    List<ZiiSensor.Dominio.Entidade.Temperatura> lista = new List<ZiiSensor.Dominio.Entidade.Temperatura>();

        ////    ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

        ////    lista = negocio.GetAllTemperatura();

        ////    if (lista == null)
        ////    {

        ////        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Temperaturas não localizado para o Id informado");
        ////    }
        ////    else
        ////    {
        ////        return Request.CreateResponse<List<ZiiSensor.Dominio.Entidade.Temperatura>>(HttpStatusCode.OK, lista, Configuration.Formatters.JsonFormatter);
        ////    }


        ////    // return Json(resultado, JsonRequestBehavior.AllowGet);

        ////    // return JsonConvert.DeserializeObject<Temperatura>(lista.ToString());
        ////}

        public List<ZiiSensor.Dominio.Entidade.Temperatura> GetAllTemperatura()
        {
            List<ZiiSensor.Dominio.Entidade.Temperatura> lista = new List<ZiiSensor.Dominio.Entidade.Temperatura>();

            ZiiSensor.Negocio.TemperaturaNegocio negocio = new ZiiSensor.Negocio.TemperaturaNegocio();

            lista = negocio.GetAllTemperatura();


            return lista;

        }

        
    }
}
