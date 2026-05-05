using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo05_05
{
    public class Cachorro : Animal
    {
        //override->Redefinir metodo herdado
        public override void EmitirSom(){
            Console.WriteLine("AU AUUUUUUUUUUU");
            
        }
        public override void Comer(){
            Console.WriteLine("Comeu ração");
            
        }
        
    }
}