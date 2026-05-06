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
        public string nomeProduto {get;set;}

        private decimal precoBaseProduto;
        public decimal precoBase{
            get{return precoBaseProduto;}
            set{
                if(value>=0){
                    precoBaseProduto=value;
                }else
                {
                    precoBase=0;
                }
            }
        }
        
        public Produto(string nome,decimal precoBase){
            nomeProduto=nome;
            precoBaseProduto=precoBase;
        }
        public abstract decimal CalcularPrecoFinal();

        public virtual void ExibirResumoProduto(){
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço Final: R${CalcularPrecoFinal()}");
        }
    }
}