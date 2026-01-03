// MENU COM REPETIÇÃO

int escolha = 0;

while (escolha != 3)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1: Somar dois números");
    Console.WriteLine("2: Verificar se um número é par ou ímpar");
    Console.WriteLine("3: Sair");

    escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("Você escolheu somar dois números!");
            break;

        case 2:
            Console.WriteLine("Você escolheu par ou ímpar!");
            break;

        case 3:
            Console.WriteLine("Programa encerrado! Obrigada por participar!");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine();
}
