using System.Text.Json;
using BibliotecaAPI.Domains;
using BibliotecaAPI.Interfaces;

namespace BibliotecaAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        //caminho do arquivo onde os livros serão salvos
        private readonly string _caminhoArquivo = "Dados/livros.json";

        //Implementando método para listar todos os livros cadastrados
        public List<Livro> Listar()
        {
            //Usamos para try catch nesse metodo pois estamos trabalhando com arquivos e operaçoes realizadas com arquivos podem dar erros por varios motivos
            try
            {
                //verificar se o arquivo ainda nao existe
                if (!File.Exists(_caminhoArquivo))
                {
                    return new List<Livro>();
                }
                //se arquivo existir vamos ler o conteudo do json
                string json = File.ReadAllText(_caminhoArquivo);

                //converter o json para uma lista de livros
                //se caso a conversao der null, retorna uma lista vazia
                return JsonSerializer.Deserialize<List<Livro>>(json)
                            ?? new List<Livro>();
            }
            catch
            {
                //se der erro na leitura ele vai retornar uma lista vazia
                return new List<Livro>();
            }
        }
        public Livro? BuscarPorId(int id)
        {
            Livro livro = Listar().FirstOrDefault(livro => livro.Id == id);
            return livro;
        }
        //metodo privado usado somente dentro da repository
        //esse metodo salva a lista de livros no arquivo json
        private void Salvar(List<Livro> livros)
        {
            //cria a pasta dados caso ela n exista
            Directory.CreateDirectory("Dados");

            //Converte a lista de livros para json
            string json = JsonSerializer.Serialize(livros, new JsonSerializerOptions{
                //Indenta o json -> mais facil d ler
                WriteIndented = true
            });

            //escreve o json no arquivo
            File.WriteAllText(_caminhoArquivo, json);
        }
        public Livro Adicionar(Livro livro)
        {
            //Carrega a lista atual de livros
            List<Livro> livros = Listar();

            //gera ids automaticamente
            //Se ja houver livros ele pega o maior id e soma 1
            //sen houver livros começa com id 1
            //Função ANY valida se existe algo e retorna tru or false
            livro.Id = livros.Any() ? livros.Max(livro => livro.Id) + 1 : 1;

            livros.Add(livro);
            Salvar(livros);

            return livro;
        }
    }
}
