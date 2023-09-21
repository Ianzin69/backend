using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros
        List<int> ListaNumeros = new List<int>();

        //Adicionando elementos à lista
        ListaNumeros.Add(10);  //posição [0]
        ListaNumeros.Add(20);  //posição [1]
        ListaNumeros.Add(45);  //posição [2]

        //Contando a quantidade de elementos em nossa Lista
        Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");

        //Acessando os dados da Lista pelo índice
        Console.WriteLine(ListaNumeros[1]);

        ListaNumeros.Add(6);  //posição [3]
        Console.WriteLine($"Neste momento temos {ListaNumeros.Count} números");

        Console.WriteLine("--------------------------");

        //Criem uma nova lista de nomes e adicionem alguns nomes a ela
        //e exibam a quantidade de nomes que contém nessa lista

        List<string> listaNomes = new List<string>();

        listaNomes.Add("KevinVaranda");
        listaNomes.Add("Alfonso");
        listaNomes.Add("Rapadura");

        Console.WriteLine($"Foram sorteados {listaNomes.Count} Nomes");

        Console.WriteLine("--------------------------");

        //  Criando uma lista já atribuindo valores
        ListaNumeros<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2);  //Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4);  //Remove o elemento pela posição (índice)
        numeros.Remove(2, 2);  //Remove  elemento da posição 2 e os próximos 2  

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova lista com objetos da Classes Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à listaAluno
        listaAlunos novoAluno = new Aluno("Marcos", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patrícia", 19));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome aluno")
        }

        //LINQ utizando Sintaxe de método
        var metodo = listaAlunos
                            .Where(novoAluno => novoAluno.idade < 18)
                            .OrderBy(novoAluno => novoAluno.nome)
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome Aluno: {item.nome} idade {item.idade}");
        }

    }
}