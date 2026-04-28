namespace condicionais;

class Program
{
    static void Main(string[] args)
    {
        
        // int numero=-6;
        // if(numero>0)
        // {
        //     Console.WriteLine("Número Positivo");
        // }else
        // {
        //     Console.WriteLine("Negativo");
        // }

        // Console.Write("Digite um número ");
        // int numero=int.Parse(Console.ReadLine());

        // if(numero>0){
        //     Console.WriteLine("Positivo");

        // }else if(numero<0){
        //     Console.WriteLine("Negativado");

        // }else if(numero==0){
        //     Console.WriteLine("É 0");

        // }



        // Console.Write("Digite sua idade: ");
        // int idade=int.Parse(Console.ReadLine());
        // if(idade>=16 && idade<18){
        //     Console.WriteLine("Pode votar, opcional");
        // }else if(idade>=18){
        //     Console.WriteLine("Pode votar, obrigatório");
        // }else{
        //     Console.WriteLine("Pode votar não");
        // }





        // Console.Write("Digite sua nota: ");
        // decimal nota=decimal.Parse(Console.ReadLine());
        // if(nota>=7){
        //     Console.WriteLine("Aprovado");
        //     if(nota>=9){
        //         Console.WriteLine("⭐");
        //     }
        // }else if(nota>=5){
        //     Console.WriteLine("Recuperação");
        // }else{
        //     Console.WriteLine("Reprovado");
        // }

        // int n1=2;
        // int n2=5;

        // if(n1>n2){
        //     Console.WriteLine("n1 maior");
        // }else if(n2>n1){
        //     Console.WriteLine("n2 é maior");
        // }else{
        //     Console.WriteLine("São iguais");
        // }

        // Console.Write("Usuario: ");
        // string usuario=Console.ReadLine();
        // Console.Write("Senha: ");
        // string senha=Console.ReadLine();
        // if(usuario=="admin"&&senha=="1234"){
        //     Console.WriteLine("Logado");
        // }else if(usuario!="admin"){
        //     Console.WriteLine("Usuario não encontrado");
        // }else{
        //     Console.WriteLine("Senha incorreta");
        // }






        // Console.Write("Digite um numero: ");
        // int numero=int.Parse(Console.ReadLine());

        //if ternário
        // string resultado = numero % 2 ==0 ? "par" : "impar";
        // Console.WriteLine(resultado);

        //if normal
        // if(numero %2==0){
        //     Console.WriteLine("Par");
        // }else{
        //     Console.WriteLine("Impar");
        // }



        // int idade=12;

        // Console.Write(idade >= 18 ? "Maior de idade":"menor de idade");



        // Console.WriteLine("Digite um número de 1 a 3:");
        // int opcao=int.Parse(Console.ReadLine());

        // switch(opcao){

        //     case 1:
        //         Console.WriteLine("Opcao 1");
        //         break;

        //     case 2:
        //         Console.WriteLine("Opcao 2");
        //         break;

        //     case 3:
        //         Console.WriteLine("Opcao 3");
        //         break;

        //     default:
        //         Console.WriteLine("vc digitou outro numero");
        //         break;
        // }



        Console.Write("Digite uma opção: A B ou C: ");
        string opcao=Console.ReadLine();//.ToUpper(); ou .ToLower();

        switch(opcao){

            case "A" or "a":
                Console.WriteLine("A");
                break;

            case "B" or "b":
                Console.WriteLine("B");
                break;
            case "C" or "c":
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("nenhum deles");
                break;
        }






    }
}
