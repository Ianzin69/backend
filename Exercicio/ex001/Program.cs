Console.WriteLine ("Informe o nome do aluno"); 
string nome = Console.ReadLine ();  

Console.WriteLine ("Digite a primeira nota do aluno"); 
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Digite a segunda nota do aluno"); 
int nota2 = int.Parse(Console.ReadLine());   

Console.WriteLine ("Digite a terceira nota do aluno"); 
int nota3 = int.Parse(Console.ReadLine());

int soma = (nota1 + nota2 + nota3) / 3;

Console.WriteLine ("Média: " + soma);
Console.WriteLine($"A média do aluno {nome} foi de {soma}");

string media = (soma >= 7) ? "Aprovado" : "Reprovado";