using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Teste
{
    [TestClass]
    public class Temperatura
    {      

        Negocio.TemperaturaNegocio negocio = new Negocio.TemperaturaNegocio();

       // [TestMethod]
        public void Temperatura_IncluirTemperatura()
        {
            //Incluir o cmapo DataHora
            //Retirar o campo Nome

            Dominio.Entidade.Temperatura temperatura = new Dominio.Entidade.Temperatura();
            //temperatura.ID = 100;
            temperatura.IDDispositivo = 3;
            //temperatura.DataHora = "Celsius";
            temperatura.TemperaturaAtual = 32;
            temperatura.TemperaturaMaxima = 40;
            temperatura.TemperaturaMinima = 23;
            temperatura.Umidade = "19";


            negocio.Incluir(temperatura);

            Assert.AreEqual(1, true);
        }

        //[TestMethod]
        public void Temperatura_ConsultarPorID()
        {
            int id = 2;
            var retorno = negocio.GetTemperatura(id);
        }
    }
}
