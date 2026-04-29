namespace exercicioDia29_04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Facil 1-5, Medio 1-5, Dificil 1-5");
        Console.Write("Digite qual exercicio quer ir: (exemplo: Facil1) ");
        string opcao=Console.ReadLine().ToLower();

        switch(opcao){

            case "facil1":
                for(int i=0;i<=10;i++){
                    Console.WriteLine(i);
                }
                break;

            case "facil2":
                for(int i=10;i>=0;i--){
                    Console.WriteLine(i);
                }
                break;

            case "facil3":
                Console.Write("Digite um numero: ");
                int nf3=int.Parse(Console.ReadLine());

                for(int i=1;i<=10;i++){
                    Console.WriteLine($"{nf3}*{i}="+nf3*i);
                }
                break;

            case "facil4":
                int nf4=1;
                while(nf4<=5){
                    Console.WriteLine(nf4);
                    nf4++;
                }
                break;

            case "facil5":
                int soma=0;
                for(int i=1;i<=5;i++){
                    Console.WriteLine(soma+=i);
                }
                break;

            case "medio1":
                int soma1=0;
                for(int i=1;i<=5;i++){
                    Console.Write("Digite um numero: ");
                    int nm1=int.Parse(Console.ReadLine());
                    soma1=soma1+nm1;
                }
                Console.WriteLine("Resultado: "+soma1);
                break;

            case "medio2":
                for(int i=1;i<=20;i++){
                    if(i%2==0){
                        Console.WriteLine(i);
                    }
                }
                break;

            case "medio3":
                string senha;
                do{
                    Console.WriteLine("Digite sua senha: ");
                    senha =Console.ReadLine();
                }while(senha!="1234");
                Console.WriteLine("Senha correta");
                break;


            case "medio4":
                int op;
                do{
                    Console.WriteLine("1-> continuar,  2->sair");
                    op=int.Parse(Console.ReadLine());
                }while(op!=2);
                 Console.WriteLine("saiu");
                break;

            case "medio5":
                int soma2=0;
                int cont=0;
                for(int i=1;i<=4;i++){
                    Console.Write("Digite um numero: ");
                    int nm5=int.Parse(Console.ReadLine());

                    soma2=soma2+nm5;
                    cont++;
                }
                Console.WriteLine("Média: "+soma2/cont);
                break;
            
            case "dificil1":
                Console.Write("Digite um numero: ");
                int nd1=int.Parse(Console.ReadLine());
                int maior=nd1;
                for(int i=1;i<=4;i++){
                    Console.Write("Digite um numero: ");
                    nd1=int.Parse(Console.ReadLine());
                    if(nd1>maior){
                        maior=nd1;
                    }
                }
                Console.WriteLine("Esse é o maior: "+maior);
                break;

            case "dificil2":
                int cont1=0;
                int nd2=1;
                while(nd2!=0){
                    Console.Write("Digite um numero: ");
                    nd2=int.Parse(Console.ReadLine());
                    cont1++;
                }
                Console.WriteLine("saiu um 0");
                Console.WriteLine($"Foram {cont1} tentativas");
                break;

            case "dificil3":
                int soma3=0;
                int nd3=0;
                while(nd3>=0){
                    Console.Write("Digite um numero: ");
                    nd3=int.Parse(Console.ReadLine());
                    soma3=soma3+nd3;
                }
                Console.WriteLine("saiu um numero negativo");
                Console.WriteLine("A soma foi: "+(soma3-nd3));
                break;

            case "dificil4":
                int[] nd4={1,2,3,4,5};
                foreach(int numero in nd4){
                    Console.WriteLine(numero);
                }
                break;

            case "dificil5":
                double[] nd5={6.0,6.0,7.0,10.0};
                double soma4=0;
                double media=0;
                foreach(int nota in nd5){
                    soma4=soma4+nota;
                }
                media=soma4/nd5.Length;
                Console.WriteLine("A média é: "+media);
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
