using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZiiSolution.ZiiSensor.Web.Models
{
    public class ClienteModel
    { 
        public string Cidade { get; set; }

        public string Endereo { get; set; }

        public int ID { get; set; }

        public int IDEstado { get; set; }

        public int IDTipoCliente { get; set; }

        public string Nome { get; set; }
    }
}