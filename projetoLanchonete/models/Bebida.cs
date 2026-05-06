using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public class Bebida : Produto
    {
        public Bebida(string nomeProduto,decimal precoBase):base(nomeProduto,precoBase){

        }
        public override decimal CalcularPrecoFinal(){
            return precoBase;
        }
        public override void ExibirResumoProduto(){
            Console.WriteLine($"Tipo: Bebida");
            base.ExibirResumoProduto();
            System.Console.WriteLine();
            
        }
    }
}