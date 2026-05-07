using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCursos
{
    public abstract class Curso
    {
        public string nome { get; set; } = string.Empty; //""
        public int horas { get; set; }

        public Curso(string nomeCurso, int horasCurso){
            nome=nomeCurso;
            horas=horasCurso;
        }
        public abstract double CalcularPreco();

        public virtual void ExibirResumo(){
            Console.WriteLine($"Curso: {nome}");
            Console.WriteLine($"Carga Horária: {horas}");
            Console.WriteLine($"Preço Final: R${CalcularPreco():f2}\n");
        }

    }
}