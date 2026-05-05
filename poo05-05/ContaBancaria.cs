using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo05_05
{
    public class ContaBancaria
    {
        private decimal saldo=100;

        public void Sacar(decimal valor){
            if(valor<=saldo){
                saldo-=valor;
            }else{
                Console.WriteLine($"Saldo insuficiente");
            }
        }

        public void MostrarSaldo(){
            Console.WriteLine($"O seu saldo é {saldo}");
        }
    }
}