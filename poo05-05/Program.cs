namespace poo05_05;

class Program
{
    static void Main(string[] args)
    {
        // ContaBancaria conta = new ContaBancaria();
        // conta.Sacar(30);
        // conta.MostrarSaldo();
        
        Cachorro c1=new Cachorro();
        c1.nome="Caramelo";
        c1.idade=10;
        c1.raca="indefinida";
        c1.cor="caramelo";

        c1.EmitirSom();
        c1.MostrarDados();
        c1.Comer();
        Console.WriteLine("\n");

        Gato g1=new Gato();
        g1.nome="feijão";
        g1.idade=5;
        g1.raca="Siames";
        g1.cor="Branco";
        g1.EmitirSom();
        g1.MostrarDados();
        g1.Comer();
        
    }
}
