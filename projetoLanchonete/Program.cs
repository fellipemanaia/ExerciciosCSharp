namespace projetoLanchonete;

class Program
{
    static void Main(string[] args)
    {
        Bebida b1=new Bebida();
        Lanche l1=new Lanche();
        Sobremesa s1=new Sobremesa();
        Console.WriteLine($"Digite o nome do Lanche: ");
        l1.nome=Console.ReadLine();
        Console.WriteLine($"Digite o nome da Bebida:");
        b1.nome=Console.ReadLine();
        Console.WriteLine($"Digite o nome da Sobremesa: ");
        s1.nome=Console.ReadLine();
        

        Console.WriteLine($"Digite o preço do Lanche: ");
        l1.precoBase=int.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o preço da Bebida:");
        b1.precoBase=int.Parse(Console.ReadLine());
        Console.WriteLine($"Digite o preço da Sobremesa: ");
        s1.precoBase=int.Parse(Console.ReadLine());
        l1.precoBase+=2;
        AplicarDesconto(s1.precoBase);
    }
}
