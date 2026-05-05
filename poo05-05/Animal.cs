using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo05_05
{
    public abstract class Animal
    {
        public string nome;
        public int idade;
        public string raca;
        public string cor;

        //virtual->o metodo pode ser subescrito
        public virtual void EmitirSom(){
            Console.WriteLine("O animal faz um som");
            
        }
        public void MostrarDados(){
            Console.WriteLine($"O animal da nome: {nome}, tem {idade} anos");
        }

        public abstract void Comer();
    }
}