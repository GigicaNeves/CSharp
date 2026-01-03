// CÁLCULO DE MÉDIA NÃO OTIMIZADO

using System.Data;

Console.Write("Digite seu nome ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome}!");

Console.WriteLine("Vamos calcular a média da idade das pessoas da sua família!");
Console.WriteLine("Quantas pessoas tem na sua família?");

int quantidadePessoa = int.Parse(Console.ReadLine());

int montanteIdade = 0;
double mediaIdade = 0;
int maiorIdade = 0;
int menorIdade = 0;
List<string> nomes = new List<string>();

for (int i = 1; i <= quantidadePessoa; i++)
{
    Console.WriteLine($"Qual é o nome da pessoa {i}? ");
    nomes.Add(Console.ReadLine());

    if (i == 1)
    {
        Console.WriteLine($"Perfeito, fale a idade de {nomes[i-1]} ");
    } else if (i == quantidadePessoa)
    {
        Console.WriteLine($"Perfeito, fale a idade de {nomes[i-1]} ");
    } else
    {
        Console.WriteLine($"Fale a idade de {nomes[i-1]} ");
    }

    int idade = int.Parse(Console.ReadLine());
    montanteIdade += idade;
    mediaIdade = montanteIdade/quantidadePessoa;

    if (maiorIdade < idade)
    {
        maiorIdade = idade;
    }

    if (i == 1)
    {
        menorIdade = idade;
    } else if (menorIdade > idade)
    {
        menorIdade = idade;
    }

}

Console.WriteLine($"A soma das idades é {montanteIdade}");
Console.WriteLine($"A média das idades é {mediaIdade}");
Console.WriteLine($"A maior idade é {maiorIdade}");
Console.WriteLine($"A menor idade é {menorIdade}");

