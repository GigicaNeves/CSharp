// DICIONÁRIO EM C#

using System.Security.AccessControl;

Console.WriteLine("Quantas pessoas tem na sua família?");

int quantidadePessoa = int.Parse(Console.ReadLine());

Dictionary<string, int> pessoas = new Dictionary<string, int>();

for (int i = 1; i <= quantidadePessoa; i++)
{
    Console.WriteLine($"Qual é o nome da pessoa {i}?");
    string nome = Console.ReadLine();
    Console.WriteLine($"Qual é a idade de {nome} ");
    int idade = int.Parse(Console.ReadLine());

    pessoas.Add(nome, idade);

}

foreach (var pessoa in pessoas)
    {
        Console.WriteLine($"{pessoa.Key} - {pessoa.Value}");
    }
