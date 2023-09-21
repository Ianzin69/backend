using Models;

public class Program
{
    public static void main()
    {
        //Criar um obleto da classe Pessoa
        /*
        //Instanciando objeto sem método construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Elisa Sanches";
        pessoa1.idade = 18;
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Judas Alves" 99);

        pessoa1.Cantar()

        Pessoa pessoa2 = new Pessoa("Alves" 77);

        pessoa2.Cantar()

        Pessoa.pessoa3 = new Pessoa("Abella Danger" 88);

        pessoa3.Cantar()

        //Chamando o método Cantar da classe Pessoa
        pessoa1.cantar();

    }
}