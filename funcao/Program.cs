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







        // //DESAFIOOOOOOOOOOOOOOOOOOOOOOOO
        // static string VerificarSituacao(double notas){
        //     if(notas>=6){
        //         return "Aprovado";
        //     }else{
        //         return "Reprovado";
        //     }
        // }
        // double media=0;
        // string[] nomes=new string[3];
        // double[] notas=new double[6];
        // for(int i=0;i<nomes.Length;i++){
        //     int cont=1;
        //     Console.Write($"Digite o {cont}º nome: ");
        //     nomes[i]=Console.ReadLine();
        //     Console.Write($"Digite a {cont}º nota do {nomes[i]}: ");
        //     notas[i]=double.Parse(Console.ReadLine());
        //     Console.Write($"Digite a {cont+1}º nota do {nomes[i]}: ");
        //     notas[i+1]=double.Parse(Console.ReadLine());
        //     media=(notas[i]+notas[i+1])/2;
            
        //     Console.WriteLine($"Aluno {nomes[i]} foi {VerificarSituacao(media)}, nota final: {media}");
        //     Console.WriteLine("");

        // }
        





        //Funções matemáticas
        //Valor absoluto-> se tiver um valor negativo transforma em positivo
        //int valor = Math.Abs(-10); //10
        //Console.WriteLine(valor);

        //Potencia
        //double potencia = Math.Pow(2,3);

        // //raiz quadrada
        // double raiz=Math.Sqrt(25);
        // Console.WriteLine(raiz);
        

        // //Aredondamento
        // double numero=Math.Round(3.2);
        // Console.WriteLine(numero);


        //Numeros aleatorios
        // Random random=new Random();
        // int n = random.Next(1,101);//gera os numeros entre 1 e 100
        // int n = random.Next(1,101);//gera os numeros começando em 0
        // Console.WriteLine(n);




        //Funçoes de String
        //tamanho da string
        // string text="CSharp";
        // int tamanho=text.Length;
        // Console.WriteLine(tamanho);    


        // //substituir texto
        // string frase="Ola mundo";
        // frase=frase.Replace("mundo","C#");
        // Console.WriteLine(frase);


        // //Contains
        // string frase ="Estou aprendendo C#";
        // if(frase.Contains("C#")){
        //     Console.WriteLine("Contem");
        // }
        // bool existe=frase.Contains("C#");
        // Console.WriteLine(existe);

        // //ordenar
        // int[] numeros={1,2,3,6,5};
        // Array.Sort(numeros);
        // Console.WriteLine(string.Join(", ",numeros));
        // //inverso
        // Array.Reverse(numeros);
        // Console.WriteLine(string.Join(", ",numeros));



        // //Simular adicionar valores em array
        // string[] nomes={"ana","bruno","Carlos"};
        // string novoNome="Pedro";

        // string[] novoArray = new string[nomes.Length+1];
        // for(int i=0;i<nomes.Length;i++){
        //     novoArray[i]=nomes[i];
        // }
        // novoArray[novoArray.Length-1]=novoNome;
        // nomes=novoArray;
        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        //Adicionando elementos com List
        // List<string> nomes=new List<string>();
        // nomes.Add("ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        //removendo
        // nomes.Remove("Bruno");
        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        // //acessar por indice
        // Console.WriteLine(nomes[0]);

        // //contar
        // Console.WriteLine(nomes.Count());

        // //encontrar
        // if(nomes.Contains("ana")){
        //     Console.WriteLine("sim");
        // }

        // //inserindo nome por indice
        // nomes.Insert(2,"Paula");

        // //removendo por indice
        // nomes.RemoveAt(3);

        //limpando lista
        //nomes.Clear();

        //sisteminha: Removendo item digitado
        // List<string> produtos=new List<string>();
        // string[] novoprodutos={"mouse","teclado","monitor"};

        // foreach(string prod in novoprodutos){
        //     produtos.Add(prod);
        // }

        // for(int i=0;i<produtos.Count();i++){
        //     Console.WriteLine(produtos[i]);
        // }

        // Console.Write("Digite um produto pra remover: ");
        // string remover=Console.ReadLine();

        // if(produtos.Contains(remover)){
        //     produtos.Remove(remover);
        // }else{
        //     Console.WriteLine("Nao existe esse produto");
        // }


        //DESAFIO22222222222222222222222222222222222222222222
        List<string> tarefas=new List<string>();
        string loop="a";
        string op1="a";
        do{
            Console.WriteLine("---------------------------- \n1->Adicionar Tarefa \n2->Listar Tarefas \n3->Remover Tarefa \n4->Sair \n----------------------------");
            Console.Write("Escolha sua opção: ");
            int op=int.Parse(Console.ReadLine());
            string novamente="sim";
            switch(op){
                case 1:
                    loop="a";
                    while(novamente=="sim"){
                        Console.Write("\nDigite a Tarefa para ser adicionada: ");
                        tarefas.Add(Console.ReadLine());
                        Console.WriteLine("Tarefa adicionada com sucesso");
                        Console.Write("\nDeseja adicionar nova tarefa?(para voltar ao menu digite 'voltar'): ");
                        op1=Console.ReadLine().ToLower();
                        if(op1=="sim"){
                            loop="a";
                            novamente="sim";
                        }else if(op1=="voltar"){
                            novamente="a";
                            loop="voltar";
                        }else{
                            loop="a";
                            novamente="a";
                        }
                    }
                    break;

                case 2:
                    loop="a";
                    Console.WriteLine("Lista Abaixo:");
                    foreach(string taf in tarefas){
                        Console.WriteLine(taf);
                    }
                    Console.WriteLine("\n"); 
                    loop="voltar";               
                    break;

                case 3:
                    loop="a";
                    while(novamente=="sim"){
                        novamente="a";
                        Console.Write("\nDigite a Tarefa para ser removida: ");
                        string remover=Console.ReadLine();
                        if(tarefas.Contains(remover)){
                            Console.Write("Deseja Realmente excluir essa tarefa? ");
                            string confirm=Console.ReadLine().ToLower();
                            if(confirm=="sim"){
                                tarefas.Remove(remover);
                                Console.WriteLine("Tarefa removida com sucesso");
                                Console.Write("\nDeseja remover outra tarefa?(para voltar ao menu digite 'voltar'): ");
                                op1=Console.ReadLine().ToLower();
                                if(op1=="sim"){
                                    loop="a";
                                    novamente="sim";
                                }else if(op1=="voltar"){
                                    novamente="a";
                                    loop="voltar";
                                }else{
                                    loop="a";
                                    novamente="a";
                                } 
                            } 
                        }else{
                            Console.WriteLine("Tarefa Não existe");
                            novamente="sim";
                        } 
                    }
                    break;

                case 4:
                    loop="a";
                    Console.WriteLine("Encerrando");
                    break;
                default:
                    loop="a";
                    Console.WriteLine("Opção invalida");
                    loop="voltar";
                    break;
            }
        }while(loop=="voltar");
    }
}
