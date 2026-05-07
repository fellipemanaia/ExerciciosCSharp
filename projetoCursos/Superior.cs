using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoCursos
{
    public class Superior : Curso
    {
        public Superior(string nomeCurso, int horasCurso) : base(nomeCurso,horasCurso)
        {
        }

        public override double CalcularPreco(){
            return horas * 40;
        }
    }
}