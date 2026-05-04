namespace exercicioDia04_05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade1-13");
        Console.Write("Digite qual exercicio quer ir: (exemplo: Atividade1) ");
        string opcao=Console.ReadLine().ToLower();

        switch(opcao){
            case "atividade1":

                break;
            
            case "atividade2":
                string[] nomes={"ana","bruno","carlos","duda"};
                Array.Reverse(nomes);
                Console.WriteLine(nomes);
                break;

            case "atividade3":
                static void Repetir(int num,string palavra){
                    Console.Write("\n");
                    for(int i=1;i<=num;i++){
                        Console.WriteLine(palavra);
                    }
                }
                Console.Write("Digite um numero: ");
                int num3=int.Parse(Console.ReadLine());
                Console.Write("Digite uma palavra: ");
                string palavra=Console.ReadLine();
                Repetir(num3,palavra);
                break;

            case "atividade4":
                int[] numeros ={0,2,3,0,4};
                for(int i=1;i<numeros.Length;i++){
                    if(numeros[i-1]==0){
                        numeros[i-1]=1;
                    }
                }
                Console.WriteLine(string.Join(", ",numeros));
                break;
            case "atividade5":
                List<int> nomes5=new List<int>();
                nomes5.Add(1);
                nomes5.Add(2);
                nomes5.Add(3);
                nomes5.Add(4);
                nomes5.Add(5);
                foreach (int nome in nomes5)
                {
                    Console.WriteLine(nome);
                }
                Console.Write("Digite um numero para remover: ");
                nomes5.Remove(int.Parse(Console.ReadLine()));
                Console.Write("\n");
                foreach (int nome in nomes5)
                {
                    Console.WriteLine(nome);
                }
                break;
            
            case "atividade6":
                List<string> nomes6=new List<string>();
                nomes6.Add("Ana");
                nomes6.Add("Lucia");
                nomes6.Add("Maria");
                nomes6.Add("Luana");
                nomes6.Add("Giovana");
                foreach (string nome in nomes6)
                {
                    Console.WriteLine(nome);
                }
                Console.Write("Digite um nome da lista: ");
                string aaa=Console.ReadLine();
                for(int num6=0;num6<nomes6.Count();num6++){
                    if(nomes6[num6]==aaa){
                        Console.WriteLine("Esta no indice "+num6);  
                    }else{
                        Console.WriteLine("Nao encontrado");
                    }
                }
                
                break;

        }
    }
}
