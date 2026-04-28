namespace exercicioDia28_04;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Facil 1-7, Medio 1-9, Dificil 1-7");
        Console.Write("Digite qual exercicio quer ir: (exemplo: Facil1) ");
        string opcao=Console.ReadLine().ToLower();

        switch(opcao){

            
            case "facil1":
                //Facil 1
                Console.Write("Digite uma temperatura: ");
                int temp= int.Parse(Console.ReadLine());
                Console.WriteLine(temp >=15 ? "Ta agradável":"Ta frio");
                break;

            case "facil2":
                //Facil 2
                Console.Write("Digite um número: ");
                int n2= int.Parse(Console.ReadLine());
                Console.WriteLine(n2>100 ? "Maior que 100":"Menor que 100");
                break;

            case "facil3":
                //Facil 3
                Console.Write("Digite uma senha: ");
                string senha= Console.ReadLine();
                Console.WriteLine(senha == "123" ? "Senha Correta":"Senha errada");
                break;

            case "facil4":
                //Facil 4
                Console.Write("Digite um número: ");
                int n4= int.Parse(Console.ReadLine());
                Console.WriteLine(n4>0 ? "Número válido":"Número inválido");
                break;

            case "facil5":
                //Facil 5
                Console.Write("Digite sua idade: ");
                int idade= int.Parse(Console.ReadLine());
                Console.WriteLine(idade >= 16 ? "Cadastro Permitido":"Cadastro Negado");
                break;
            
            case "facil6":
                //Facil 6
                Console.Write("Digite um numero de 1 a 3: ");
                int turno= int.Parse(Console.ReadLine());
                switch(turno){
                    case 1:
                        Console.WriteLine("Manhã");
                        break;
                    case 2:
                        Console.WriteLine("Tarde");
                        break;
                    case 3:
                        Console.WriteLine("Noite");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                break;

            case "facil7":
                //Facil 7
                Console.Write("Digite um numero de 1 a 3: ");
                int menu= int.Parse(Console.ReadLine());
                switch(menu){
                    case 1:
                        Console.WriteLine("Novo Jogo");
                        break;
                    case 2:
                        Console.WriteLine("Carregar Jogo");
                        break;
                    case 3:
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                break;

            case "medio1":
                //medio 1
                Console.Write("Digite uma idade: ");
                int idade1= int.Parse(Console.ReadLine());

                if(idade1<=12){
                    Console.WriteLine("Criança");
                }else if(idade1>12 && idade1<=17){
                    Console.WriteLine("Adolescente");
                }else{
                    Console.WriteLine("Adulto");
                }
                break;
            
            case "medio2":
                //medio 2
                Console.Write("Digite um numero: ");
                int nm21= int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero: ");
                int nm22= int.Parse(Console.ReadLine());
                Console.WriteLine(nm21>nm22 ? "O primeiro digitado é maior": (nm22>nm21 ? "O segundo digitado é maior":"São iguais"));
                break;

            case "medio3":
                //medio 3
                Console.Write("Digite sua idade: ");
                int idade2= int.Parse(Console.ReadLine());
                Console.Write("Possui Convite?: Sim ou Não");
                string convite= Console.ReadLine().ToLower();
                if(idade2>=18 && convite=="sim"){
                    Console.WriteLine("Entre");
                }else if(idade2<18){
                    Console.WriteLine("idade insuficiente");
                }else{
                    Console.WriteLine("Não possui convite, não entra");
                }
                break;

            case "medio4":
                Console.Write("Digite um numero: ");
                int nm4= int.Parse(Console.ReadLine());
                Console.WriteLine(nm4>=0 && nm4<=10 ? "Valor válido":"valor inválido");
                break;

            case "medio5":
                Console.Write("Digite sua idade: ");
                int idade3= int.Parse(Console.ReadLine());
                Console.WriteLine(idade3<18 ? "Sem desconto":(idade3<60 ? "10% de desconto":"20% de desconto"));
                break;

            case "medio6":
                Console.Write("Digite o valor da sua compra: ");
                int compra= int.Parse(Console.ReadLine());
                Console.WriteLine(compra<200 ? "5% de desconto":"15% de desconto");
                break;

            case "medio7":
                Console.Write("Digite um número: ");
                int nm71= int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero: ");
                int nm72= int.Parse(Console.ReadLine());
                Console.Write("Digite uma operação +,-,*,/: ");
                string op= Console.ReadLine();

                switch(op){
                    case "+":
                        Console.WriteLine("Resultado: "+(nm72+nm71));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: "+(nm71-nm72));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: "+(nm71*nm72));
                        break;
                    case "/":
                        Console.WriteLine("Resultado: "+nm71/nm72);
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
                break;
            
            case "medio8":
                Console.Write("Digite um número de 1 a 7: ");
                int nm8= int.Parse(Console.ReadLine());
                switch(nm8){
                    case 1 or 7:
                        Console.WriteLine("Fim de semana");
                        break;
                    case 2 or 3 or 4 or 5 or 6:
                        Console.WriteLine("Dia Util");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                break;

            case "medio9":
                Console.Write("Digite uma opção (Básico,Intermediário,Premium): ");
                string plano= Console.ReadLine().ToLower();
                switch(plano){
                    case "basico":
                        Console.WriteLine("10MB");
                        break;
                    case "intermediario":
                        Console.WriteLine("50MB");
                        break;
                    case "premium":
                        Console.WriteLine("100MB");
                        break;
                    default:
                        Console.WriteLine("Inválido");
                        break;
                }
                break;

            case "dificil1":
                Console.Write("Digite sua nota: ");
                decimal nota=decimal.Parse(Console.ReadLine());
                if(nota>=7){
                    Console.WriteLine("Aprovado");
                }else if(nota>=5){
                    Console.WriteLine("Recuperação");
                }else{
                    Console.WriteLine("Reprovado");
                }
                break;
            
            case "dificil2":
                Console.Write("Digite um número: ");
                int nd21= int.Parse(Console.ReadLine());
                Console.Write("Digite outro número: ");
                int nd22= int.Parse(Console.ReadLine());
                Console.Write("Digite mais um número: ");
                int nd23= int.Parse(Console.ReadLine());
                if(nd21>=0 || nd22>=0 || nd23>=0){
                    Console.WriteLine("Existe 0 n da pra fazer triangulo");
                }else if((nd21+nd22+nd23)==180){
                    Console.WriteLine("Da pra formar um triangulo");
                }
                break;

            case "dificil3":
                Console.Write("Digite um número: ");
                int nd31= int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero: ");
                int nd32= int.Parse(Console.ReadLine());
                Console.Write("Digite uma operação +,-,*,/: ");
                string op1= Console.ReadLine();
                if(op1=="+"){
                    Console.WriteLine("Resultado:"+(nd31+nd32));
                }else if(op1=="-"){
                    Console.WriteLine("Resultado: "+(nd31-nd32));
                }else if(op1=="*"){
                    Console.WriteLine("Resultado: "+(nd31*nd32));
                }else if(op1=="/"){
                    Console.WriteLine("Resultado: "+(nd31/nd32));
                }else{
                    Console.WriteLine("Operação inválida");
                }
                break;
            
            case "dificil4":
                int tentativas=5;
                Console.Write("Usuario: ");
                string usuario=Console.ReadLine();
                Console.Write("Senha: ");
                string senha=Console.ReadLine();
                if(usuario=="admin"&&senha=="1234" && tentativas>=0){
                    Console.WriteLine("Logado");
                }else if(usuario!="admin"){
                    Console.WriteLine("Usuario não encontrado");
                    tentativas= tentativas-1;
                }else if(senha!="1234"){
                    Console.WriteLine("Senha incorreta");
                    tentativas=tentativas-1;
                }else if(tentativas<0){
                    Console.WriteLine("Acabou as tentativas");
                }
                break;
            
            case "dificil5":
                Console.Write("Digite um numero: ");
                int nd5= int.Parse(Console.ReadLine());
                Console.WriteLine(nd5>0 ? "Positivo": (nd5<0 ? "Negativo":"é 0"));
                break;

            case "dificil6":
                Console.Write("Digite um número: ");
                int nd61= int.Parse(Console.ReadLine());
                Console.Write("Digite outro numero: ");
                int nd62= int.Parse(Console.ReadLine());
                Console.Write("Digite uma operação +,-,*,/: ");
                string op2= Console.ReadLine();

                switch(op2){
                    case "+":
                        Console.WriteLine("Resultado: "+(nd61+nd62));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: "+(nd61-nd62));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: "+(nd61*nd62));
                        break;
                    case "/":
                        if(nd62==0){
                            Console.WriteLine("Divisão por 0 não existe");
                        }else{
                            Console.WriteLine("Resultado: "+nd61/nd62);
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
                break;

            case "dificil7":
                Console.Write("Digite um número de 1 a 3: ");
                int nd7= int.Parse(Console.ReadLine());
                switch(nd7){
                    case 1:
                        Console.WriteLine("Você escolheu Água, fica R$3,00");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Refrigerante, fica R$5,00");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Suco, fica R$7,00");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                break;
            
            default:
                Console.WriteLine("Opção inválida");
                break;    
        }

    }
}
