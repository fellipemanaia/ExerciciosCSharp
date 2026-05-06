using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public class Sobremesa : Produto
    {
        public Sobremesa(string nomeProduto,decimal precoBase):base(nomeProduto,precoBase){

        }
        public decimal AplicarDesconto(){
            return precoBase * 0.1m;
        }
        public override decimal CalcularPrecoFinal(){
            return precoBase - AplicarDesconto();
        }
        public override void ExibirResumoProduto(){
            Console.WriteLine($"Tipo: Sobremesa");
            base.ExibirResumoProduto();
            Console.WriteLine($"Desconto: R${AplicarDesconto():f2}");
            System.Console.WriteLine();
            
        }
    }
}