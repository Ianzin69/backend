class Program
{
    public static string[] poltronas = new string[51];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao Butão Viagens");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Contamos com 50 lugares para você sentar gostoso");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine("######## M E N U ########");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponíveis");
            Console.WriteLine("3- Número de poltronas disponíveis");
            Console.WriteLine("4- Lista de passsageiros");
            Console.WriteLine("0- Para fechar sistema");
            
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, nunca mais voltem !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;

                case "1":
                    ComprarPassagem();
                    break;

                case "2":
                    poltronasDisponíveis();
                    break;

                case "3":
                    PassagensDisponíveis();
                    break;

                case "4":
                ListaPassageiros();
                break;

                default:
                    Console.WriteLine("Opção invalída!!!");
                    break;
            }

        } while (opcao != "0");

    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona de {i}ª passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }

    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;

    }

    public static void poltronasDisponíveis()
    {
        Console.WriteLine("Lista de Poltronas disponíveis");
        for (int i = 1; i <= 50; i++)
        {

            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }

    }

    public static void PassagensDisponíveis()
    {
        int total = 0;
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                total++;
            }
        }
        Console.WriteLine("Atualmente temos " + total + " Poltronas disponíveis");
    }

    public static void ListaPassageiros()
    {
        Console.WriteLine("Lista de Passageiros");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] == null) {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

}