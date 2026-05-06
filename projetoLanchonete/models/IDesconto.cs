using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public interface IDesconto
    {
        decimal AplicarDesconto(decimal valor);
    }
}