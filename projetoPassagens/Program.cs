namespace projetoPassagens;

class Program
{
    static void Main(string[] args)
    {
        int cont=0;
        List<Passagens> p=new List<Passagens>();
        Console.WriteLine($"Digite a senha para entrar no sistema: ");
        if(Console.ReadLine()=="123456"){
            string loop="a";
            do{
                Console.WriteLine("---------------------------- \n1->Cadastrar Passageiros \n2->Listar Passageiros \n3->Sair \n----------------------------");
                Console.Write("Escolha sua opção: ");
                int op=int.Parse(Console.ReadLine());
                switch(op){
                    case 1:
                        if(cont==0){
                            Console.WriteLine($"\nVoce tem o limite de duas passagens!!\n");
                            for(int i=1;i<=2;i++){
                                Console.Write($"\nDigite o nome do {i}º passageiro: ");
                                string nomeDigitado=Console.ReadLine();
                                Console.Write($"\nDigite a origem do {i}ºpassageiro: ");
                                string origemDigitado=Console.ReadLine();
                                Console.Write($"\nDigite o destino do {i}º passageiro: ");
                                string destinoDigitado=Console.ReadLine();
                                Console.Write($"\nDigite a data da viagem do {i}º passageiro: ");
                                string dataDigitado=Console.ReadLine();
                                p.Add(new Passagens(nomeDigitado,origemDigitado,destinoDigitado,dataDigitado));
                            }
                            loop="voltar";
                            cont++;
                        }else{
                            Console.WriteLine($"Limite de passagens estourado!!");
                            loop="voltar";
                        }
                        break;

                    case 2:
                        Console.WriteLine("Lista de Passageiros abaixo:");
                        foreach(Passagens pas in p){
                            pas.ExibirInformacao();
                            Console.WriteLine($"\n");
                        }
                        Console.WriteLine("\n"); 
                        loop="voltar";
                        break;
                    case 3:
                        Console.WriteLine("Encerrando");
                        loop="a";
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        loop="voltar";
                        break;
                }
            }while(loop=="voltar");
        }else{
            Console.WriteLine("Senha incorreta, reinicie o programa");
        }
    }
}
