using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZiiSolution.ZiiSensor.Web.Models
{
    public class DispositivoModel 
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int IDTipoDispositivo { get; set; }

        public int IDCliente { get; set; }
    }
}