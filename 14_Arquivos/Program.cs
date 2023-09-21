using System.IO;

public class Program
{

    public static void main(string[] args)
    {
        GravarArquivo()
        
    }
    public static void GravarArquivo()
    {
        try
        
    }
    public static void Main()
    {
        try
        {
            //Gravando no arquivo de texto
            using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
            {
                arquivo.WriteLine("Texto de teste porque foi mim que fez");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }

    public static void LerArquivo()
    {
        using (StreamWriter arquivo = new StreamWriter("arquivo.txt"))
        {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine(Linha);
            }
        }
    }
}