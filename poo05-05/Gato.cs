using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo05_05
{
    public class Gato : Animal
    {
        public override void EmitirSom(){
            Console.WriteLine("MIAUUUUUUUUUU");
            
        }
        public override void Comer(){
            Console.WriteLine("Comeu sache");
            
        }
    }
}