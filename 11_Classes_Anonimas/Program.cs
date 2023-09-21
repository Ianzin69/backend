public class Program
{

    public static void Main()
    {
        var pessoa1 = new { "Jão", idade = 20 };

        var pessoa2 = new { "Maria", idade = 17 };

        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a Pessoa");

        Console.WriteLine("Dijite o modelo do carro");
        string modeloDigitado = Console.ReadLine();

        Console.WriteLine("Dijite o marca do carro");
        string marcaDigitado = Console.ReadLine();

        Console.WriteLine("Dijite o ano do carro");
        string anoDigitado = Console.ReadLine();

        var carro1 = new
        {
            marca = modeloDigitado,
            modelo = marcaDigitado,
            ano = anoDigitado
        };

        Console.WriteLine($"Meu carro da marca {carro1.marca} modelo {carro1.modelo} e ano {carro1.ano}");

    }

}
