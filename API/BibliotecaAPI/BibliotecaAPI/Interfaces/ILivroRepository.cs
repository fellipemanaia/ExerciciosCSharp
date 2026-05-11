using BibliotecaAPI.Domains;

namespace BibliotecaAPI.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> Listar();

        //a interrogação significa que o metodo pode retornar null
        //esse metodo pode retornar um livro ou NADA

        Livro? BuscarPorId(int id);

        Livro Adicionar(Livro livro);

        bool Atualizar(int id, Livro livro);

        bool Remover(int id);

    }

}
