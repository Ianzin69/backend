using System;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i} vez do bloco");
        }

        // Criando uma tabuada utilizando o for

        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            // num é a variavel que estou gerando a tabuada
            // cont é a variavel contadora até 10

            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }

        // Declarando um vetor do tipo inteiro com 4 espaços

        int[] notas = new int[4];

        // Declarar um vetor atribuindo valores

        string[] meses = { "Jan", "Fev" };

        notas = 10;
        nota2 = 8;
        nota3 = 7;
        nota4 = 9;

        int[] notas = { 10, 8, 7, 9 };


        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[4] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor 10000;

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }

        foreach (int item in alunos)
        {
            soma = soma + item;

            if (item > maior)
            {
                maior = item;
            }

            if (item < menor)
            {
                menor = item;
            }
        }

        Console.WriteLine($"Soma é {soma} o maior é {maior} e o menor é {menor}");

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }
    }
}