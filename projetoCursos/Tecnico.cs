using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCursos
{
    public class Tecnico : Curso
    {
        public Tecnico(string nomeCurso,int horasCurso): base(nomeCurso,horasCurso)
        {
        }

        //Sobreescrevendo a informação do metodo abstrato
        public override double CalcularPreco(){
            return horas * 20;//vale por hora
        }
    }
}