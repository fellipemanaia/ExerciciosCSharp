namespace projetoLanchonete;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Bacon",20.0m));
        pedido.Add(new Bebida("Pepsi Twist",6.0m));
        pedido.Add(new Sobremesa("Sorvete",16.0m));

        Console.WriteLine($"===== Resumo Pedido ====");
        decimal total=0.00m;
        foreach(Produto produto in pedido){
            produto.ExibirResumoProduto();
            produto.CalcularPrecoFinal();
            total+=produto.CalcularPrecoFinal();
        }
        Console.WriteLine($"Total do pedido: R${total:f2}");
        
    }
}
