namespace repeticao;

class Program
{
    static void Main(string[] args)
    {
        //for usado para quando sabe quantas vezes vai repetir

        //while usado para quando você não sabe quantas vezes vai repetir e a repetição acontece enquanto uma condição for verdadeira

        //do while é igual ao ao while, mas mesmo que a condição seja falsa, ele executa uma vez:"faz primeiro depois pergunta"

        //foreach usado para percorrer listas



        //exemplo FOR

        // for(int i=1;i<=5;i++){
        //     //int i=1   contador,valor inicial
        //     //i<=5      condição,se for verdadeiro, continua executando
        //     //i++       iterador, acrescenta um valor a mais dentro do i (i=i+1)
        //     Console.WriteLine(i);
        // }

        // int soma=0;
        // for(int i=1;i<=10;i++){
        //     soma=soma+i;
        //     Console.WriteLine(soma);
        // }
        // Console.WriteLine(soma);

        // int contador=1;
        // while(contador<=5){
        //     Console.WriteLine("Japones fraco de lata");
        //     contador++;
        // }


        // int n=0;
        // while (n<=0){
        //     Console.WriteLine("Digite um numero maior que 0: ");
        //     n=int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("Numero válido: "+n);



        // //DO WHILE
        // int n=0;
        // do{
        //     Console.WriteLine("Digite um numero maior que 0: ");
        //     n=int.Parse(Console.ReadLine());
        // }while(n<=0);
        // Console.WriteLine("Número válido: "+n);


        //MENU
        // int opcao;

        // do{
        //     Console.WriteLine("1-> continuar,  2->sair");
        //     opcao=int.Parse(Console.ReadLine());
        // }while(opcao!=2);
        // Console.WriteLine("saiu");


        // //FOREACH
        // string[] nomes={"Ana","Carlos","Maria"};
        // //para cada nome em nomes
        // foreach(string nome in nomes){
        //     //imprima o nome
        //     Console.WriteLine(nome);
        // }



        int[] n= {2,3,4,5,6,7,8};
        int soma=0;
        foreach(int numero in n){
            soma+=numero;
        }
        Console.WriteLine(soma);

    }
}
