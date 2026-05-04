using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo
{
    //SubClasse(ou derivada),Herda informações de veiculo
    public class Carro : Veiculo
    {
        //Atributos
        // public string Marca;
        public string Modelo;
        // public int Ano;

        //Métodos (ações da classe)
        public void ExibirInformacoes(){
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}