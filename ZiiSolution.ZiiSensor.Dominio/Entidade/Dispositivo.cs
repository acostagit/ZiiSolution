using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Dominio.Entidade
{
    public class Dispositivo 
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int IDTipoDispositivo { get; set; }

        public int IDCliente { get; set; }
    }
}
