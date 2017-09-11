using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiiSolution.ZiiSensor.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Incluir(Dominio.Entidade.Temperatura entidade);

    }
}
