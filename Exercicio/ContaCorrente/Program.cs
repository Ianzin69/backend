using Model;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nomeTitular = Console.Readline();
        Console.WriteLine($"Bem-vindo a sua conta, {nomeTitular}");
        ContaCorrente titular = new ContaCorrente(nomeTitular);



        string opcao = "";

        do
        {
            Console.WriteLine("------ MENU ------");
            Console.WriteLine(" 1-Para ver o seu saldo ");
            Console.WriteLine(" 2-Para depositar seu dinheiro");
            Console.WriteLine(" 3-Para sacar fechar o sistema");
            Console.WriteLine(" 0-Para fechar o sistema");
            opcao = Console.Readline();
            Console.Clear();

            switch (opcao)
            {
                case "0";
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1";
                    titular.ConsultarSaldo();
                    break;
                case "2";
                    Console.WriteLine("Qual o valor que você quer depositar?");
                    decimal deposito = decimal.Parse(Console.Readline());
                    titular.depositar(deposito);
                    break;
                case "3";
                    Console.WriteLine("Qual o valor que você quer sacar?");
                    decimal saque = decimal.Parse(Console.Readline());
                    titular.Sacar(saque);
                    break;
                default;
                Console.WriteLine("Opção invalída");
                break;
            }

        } while (opcao)
    }
}