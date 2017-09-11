using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ZiiSolution.ZiiSensor.Web.Controllers
{
    public class TemperaturaController : Controller
    {
        HttpClient client = new HttpClient();
        string uri = "http://localhost:57091/api/temperatura";

        public TemperaturaController()
        {
            client.BaseAddress = new Uri("http://localhost:57091/api/temperatura/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));

        }

        public ActionResult Index()
        {
            //// //Montar o grafico
            //// int id = 1;

            //// var resultado = "";
            //// List<Dominio.Entidade.Temperatura> lista = new List<Dominio.Entidade.Temperatura>();
            //// HttpResponseMessage response = client.GetAsync("/api/temperatura/").Result;

            ////// resultado = response.Content.ReadAsStringAsync().Result;

            //// //var serializer = new JavaScriptSerializer();
            //// //var result = serializer.Deserialize<Dominio.Entidade.Temperatura>(resultado);

            //// if (response.IsSuccessStatusCode)
            //// {
            ////     resultado = response.Content.ReadAsStringAsync().Result; //List<Dominio.Entidade.Temperatura>
            ////                                                              //products = JSserializer.Deserialize<List<Product>>(data);
            //// }
            //// else
            //// {
            ////     ViewBag.Result = "Error";
            //// }
            //// return View(resultado);

            return View();
        }

        public ActionResult Semanal()
        {
            return View();
        }

        public JsonResult GeraGrafico()
        {
            var resultado = "";
            List<Dominio.Entidade.Temperatura> lista = new List<Dominio.Entidade.Temperatura>();
            HttpResponseMessage response = client.GetAsync("/api/temperatura/").Result;

            // resultado = response.Content.ReadAsStringAsync().Result;

            //var serializer = new JavaScriptSerializer();
            //var result = serializer.Deserialize<Dominio.Entidade.Temperatura>(resultado);

            if (response.IsSuccessStatusCode)
            {
                resultado = response.Content.ReadAsStringAsync().Result; //List<Dominio.Entidade.Temperatura>
                                                                         //products = JSserializer.Deserialize<List<Product>>(data);
            }
            else
            {
                ViewBag.Result = "Error";
            }

           // var retorno = JsonConvert.DeserializeObject<Dominio.Entidade.Temperatura>(resultado);
           
           // return retorno;

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        

        public JsonResult GeraGraficoSemanal()
        {
            var resultado = "";
            List<Dominio.Entidade.Temperatura> lista = new List<Dominio.Entidade.Temperatura>();
            HttpResponseMessage response = client.GetAsync("/api/temperatura/").Result;

            // resultado = response.Content.ReadAsStringAsync().Result;

            //var serializer = new JavaScriptSerializer();
            //var result = serializer.Deserialize<Dominio.Entidade.Temperatura>(resultado);

            if (response.IsSuccessStatusCode)
            {
                resultado = response.Content.ReadAsStringAsync().Result; //List<Dominio.Entidade.Temperatura>
                                                                         //products = JSserializer.Deserialize<List<Product>>(data);
            }
            else
            {
                ViewBag.Result = "Error";
            }

            // var retorno = JsonConvert.DeserializeObject<Dominio.Entidade.Temperatura>(resultado);

            // return retorno;

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
    }
}