using BibliotecaAPI.Domains;
using BibliotecaAPI.Interfaces;

namespace BibliotecaAPI.Services
{
    public class LivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }
        public List<Livro> Listar()
        {
            return _repository.Listar();
        }
        public Livro? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public Livro Adicionar(Livro livro)
        {
            if (string.IsNullOrWhiteSpace(livro.Titulo))
            {
                throw new Exception("O Titulo é obrigatório");
            }
            if (string.IsNullOrWhiteSpace(livro.Autor))
            {
                throw new Exception("O Autor é obrigatório");
            }
            if (livro.AnoPublicacao<=0)
            {
                throw new Exception("O Ano de publicação é obrigatório");
            }
            return _repository.Adicionar(livro);
        }
    }
}
