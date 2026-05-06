using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoPassagens
{
    public class Passagens
    {
        public string nome;
        public string origem;
        public string destino;
        public string dataViagem;

        public void ExibirInformacao(){
            Console.WriteLine($"======================================");
            Console.WriteLine($"Nome do passageiro: {nome}");
            Console.WriteLine($"Origem da viagem: {origem}");
            Console.WriteLine($"Destino: {destino}");
            Console.WriteLine($"Data da viagem: {dataViagem}");
            Console.WriteLine($"======================================");
        }

        public Passagens(string nomePassagem,string origemPassagem,string destinoPassagem,string dataViagemPassagem){
            nome=nomePassagem;
            origem=origemPassagem;
            destino=destinoPassagem;
            dataViagem=dataViagemPassagem;
        }
    }
}