using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSensor.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string conteudo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57091/api/temperatura");
            request.Method = "GET";
            request.Accept = "application/xml";

            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                conteudo = reader.ReadToEnd();
            }

            Console.WriteLine(conteudo);
            Console.Read();
        }

        /*
          request.Method = "POST";

    string json = "{'Produtos':[{'Id':6237,'Preco':4000.0,'Nome':'Xbox','Quantidade':3}],'Endereço':'Rua Vergueiro 3185, 8 andar, Sao Paulo','Id':2}";
    byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
    request.GetRequestStream().Write(jsonBytes, 0, jsonBytes.Length);

    request.ContentType = "application/json"; 
         
         */
    }
}
