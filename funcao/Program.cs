namespace funcao;

class Program
{
    static void Main(string[] args)
    {
        /*
            tipoDoretorno  NomeDafuncao(parametros){
                comandos da função
            }
        */

        // //sem parametro e sem retorno
        // static void MostrarMensagem(){
        //     Console.WriteLine("Ola boa tarde");
        // }
        // MostrarMensagem();


        // //com parametro e sem retorno
        // static void Saudacao(string nome){
        //     Console.WriteLine($"Ola,{nome}");
        // }
        // Console.WriteLine("Digite seu nome: ");
        // string nome=Console.ReadLine();
        // Saudacao(nome);


        // //com parametro e com retorno
        // static int Somar(int a,int b){
        //     return a+b;
        // }
        // int resultado= Somar(3,4);
        // Console.WriteLine(resultado);





        ///Arrays -> armazena vários valores do mesmo tipo em uma mesma variável
        /// 
        // int[] numeros=new int[5];
        // Console.WriteLine(numeros[0]);

        // numeros[0]=2;
        // numeros[1]=5;
        // numeros[2]=6;
        // numeros[3]=3;
        // numeros[4]=9;
        // Console.WriteLine(numeros[0]);

        //Console.WriteLine(string.Join(", ",numeros));

        // string[] nomes={"Eu","Eu mesmo","eu ainda"};

        // for(int i=0;i<nomes.Length;i++){
        //     Console.WriteLine(nomes[i]); 
        // }
        // foreach(string nome in nomes){
        //     Console.WriteLine(nome);
        // }

        

        //FUNÇÃO + ARRAY
        // static double CalcularMedia(double[] notas){
        //     double soma=0;
        //     foreach(double nota in notas){
        //         soma+=nota;
        //     }
            
        //     return soma/notas.Length;
        // }
        // double[] notas={4,4,5,7,10};
        // double resultado=CalcularMedia(notas);
        // Console.WriteLine(resultado);


        // int[] numeros=new int[5];
        // int soma=0;
        // for(int i=0;i<numeros.Length;i++){
        //     Console.WriteLine($"Digite o {i+1}º numero: ");
        //     numeros[i]=int.Parse(Console.ReadLine());

        //     soma+=numeros[i];
        // }
        // Console.WriteLine(string.Join(", ",numeros));
        // Console.WriteLine(soma);







        //DESAFIOOOOOOOOOOOOOOOOOOOOOOOO
        static string VerificarSituacao(double notas){
            if(notas>=6){
                return "Aprovado";
            }else{
                return "Reprovado";
            }
        }
        double media=0;
        string[] nomes=new string[3];
        double[] notas=new double[6];
        for(int i=0;i<nomes.Length;i++){
            int cont=1;
            Console.Write($"Digite o {cont}º nome: ");
            nomes[i]=Console.ReadLine();
            Console.Write($"Digite a {cont}º nota do {nomes[i]}: ");
            notas[i]=double.Parse(Console.ReadLine());
            Console.Write($"Digite a {cont+1}º nota do {nomes[i]}: ");
            notas[i+1]=double.Parse(Console.ReadLine());
            media=(notas[i]+notas[i+1])/2;
            
            Console.WriteLine($"Aluno {nomes[i]} foi {VerificarSituacao(media)}, nota final: {media}");
            Console.WriteLine("");

        }
        

        
    }
}
