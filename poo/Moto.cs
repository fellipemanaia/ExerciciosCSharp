using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto(){
            ExibirDetalhes();//metodo herdado de veiculo
            Console.WriteLine($"Partida Eletrica: {TemPartidaEletrica}");
        }
    }
}