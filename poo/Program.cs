namespace poo;

class Program
{
    static void Main(string[] args)
    {
        //Instanciando objeto da classe carro
        Carro meuCarro=new Carro();
        //Definindo valores para atributos
        meuCarro.Marca="Ford Mustang";
        meuCarro.Modelo="Maverick";
        meuCarro.Ano=1977;
        //Chamar metodo
        meuCarro.ExibirInformacoes();

        Moto minhaMoto= new Moto();
        minhaMoto.Marca="honda";
        minhaMoto.Ano=2021;
        minhaMoto.TemPartidaEletrica=true;
        minhaMoto.ExibirDetalhesMoto();
    }
}
