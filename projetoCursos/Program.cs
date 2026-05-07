namespace projetoCursos;

class Program
{
    static void Main(string[] args)
    {
        List<Curso> cursos = new List<Curso>{
            new Tecnico("Desenvolvimento de Sistemas",360),
            new Superior("CiberSegurança",500)
        };
        foreach(Curso curso in cursos){
            curso.ExibirResumo();
        }
    }
}
