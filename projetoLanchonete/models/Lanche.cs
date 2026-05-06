using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public class Lanche : Produto
    {
        public Lanche(string nomeProduto,decimal precoBaseProduto): base(nomeProduto,precoBaseProduto){

        }
        private decimal taxaEmbalagem=2.00m;
        public override decimal CalcularPrecoFinal(){
            return precoBase+taxaEmbalagem;
        }
        public override void ExibirResumoProduto(){
            Console.WriteLine($"Tipo: Lanche");
            base.ExibirResumoProduto();
            System.Console.WriteLine();
        }
    }
}