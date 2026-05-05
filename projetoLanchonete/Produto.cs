using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public abstract class Produto
    {
        //get->visualizar a informação
        //set->modificar a informação
        public string nome {get;set;}

        public decimal precoBase {get;private set;}
        
        public abstract void CalcularPrecoFinal();

        public void ExibirResumo(){
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço Final:");
        }
    }
}