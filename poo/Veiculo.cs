using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo
{
    public class Veiculo
    {
        public string Marca;
        public int Ano;

        public void ExibirDetalhes(){
            Console.WriteLine($"Veiculo: {Marca}, Ano: {Ano}");
        }
    }
}