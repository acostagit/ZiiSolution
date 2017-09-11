using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiiSolution.ZiiSensor.Dominio.Entidade;

namespace ZiiSolution.ZiiSensor.Negocio
{
    public class ClienteNegocio
    {
        private Repositorio.Cliente.ClienteRepositorio _clienteDal;
        //Repositorio.Cliente.ClienteRepositorio clienteRepositorio = new Repositorio.Cliente.ClienteRepositorio();
        private Repositorio.Cliente.ClienteRepositorio Dado
        {
            get
            {
                if (_clienteDal == null) _clienteDal = new Repositorio.Cliente.ClienteRepositorio();
                return _clienteDal;
            }

        }

        public void Incluir(Cliente cliente)
        {
            _clienteDal.Incluir(cliente);
        }

    }
}
