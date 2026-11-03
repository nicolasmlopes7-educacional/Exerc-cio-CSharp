//! Ex1

// Console.Write("Digite o nome do produto: ");
// string produto = Console.ReadLine();

// Console.Write("Digite a quantidade comprada do produto: ");
// int quantidadeComprada = int.Parse(Console.ReadLine());

// Console.Write("Digite o preço unitário do produto: ");
// decimal precoUnitario = decimal.Parse(Console.ReadLine());

// Console.WriteLine(produto);
// Console.WriteLine(quantidadeComprada);
// Console.WriteLine(precoUnitario);

// decimal valortotalCompra = precoUnitario * quantidadeComprada;
// Console.WriteLine($"O valor total da compra do {produto} é {valortotalCompra:C}");

//! Ex2
// Console.Write("Digite o nome do aluno: ");
// string aluno = Console.ReadLine();

// Console.Write("Digite a nota do aluno: ");
// int nota = int.Parse(Console.ReadLine());

// if (nota >= 7 && nota < 11)
// {
//     Console.WriteLine($"O {aluno}, foi aprovado!");
// }

// else if (nota >= 5 && nota < 7)
// {
//     Console.WriteLine($"O {aluno}, está de recuperação!");
// }

// else if (nota < 5)
// {
//     Console.WriteLine($"O {aluno}, está reprovado!");
// }

// else
// {
//     Console.WriteLine("Algum dado está inválido!");
// }

//! Ex3
int numeroSecreto = 10;
int contador = 0;
int palpite = 0;


while (palpite != numeroSecreto)
{
    Console.Write("Digite o palpite: ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite > numeroSecreto)
    {
        Console.WriteLine($"O {palpite} foi maior que o número secreto!");
    }

    else if (palpite < numeroSecreto)
    {
        Console.WriteLine($"O {palpite} foi menor que o número secreto!");
    }

    else
    {
        Console.WriteLine($"O {palpite}, está correto e o número secreto é: {numeroSecreto}");
    }
    contador++;
    Console.WriteLine($"O usuário realizou {contador} tentativa(s).");
}