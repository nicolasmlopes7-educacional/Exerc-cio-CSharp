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
// int numeroSecreto = 10;
// int contador = 0;
// int palpite = 0;


// while (palpite != numeroSecreto)
// {
//     Console.Write("Digite o palpite: ");
//     palpite = int.Parse(Console.ReadLine());

//     if (palpite > numeroSecreto)
//     {
//         Console.WriteLine($"O {palpite} foi maior que o número secreto!");
//     }

//     else if (palpite < numeroSecreto)
//     {
//         Console.WriteLine($"O {palpite} foi menor que o número secreto!");
//     }

//     else
//     {
//         Console.WriteLine($"O {palpite}, está correto e o número secreto é: {numeroSecreto}");
//     }
//     contador++;
//     Console.WriteLine($"O usuário realizou {contador} tentativa(s).");
// }

//! Ex4
// static void Somar()
// {
//     Console.Write("Digite o primeiro número: ");
//     int num1 = int.Parse(Console.ReadLine());

//     Console.Write("Digite o segundo número: ");
//     int num2 = int.Parse(Console.ReadLine());

//     Console.WriteLine($"A soma dos números é: {num1 + num2}");
// }

// static void Multiplicar()
// {
//     Console.Write("Digite o primeiro número: ");
//     int num1 = int.Parse(Console.ReadLine());

//     Console.Write("Digite o segundo número: ");
//     int num2 = int.Parse(Console.ReadLine());

//     Console.WriteLine($"A multiplicação dos números é: {num1 * num2}");
// }

// Somar();
// Multiplicar();

//! Ex5
// int[] notas = new int[3];

// int contador = 0;

// while (contador < 3)
// {
//     Console.Write("Digite a nota: ");
//     notas[contador] = int.Parse(Console.ReadLine());
//     contador++;
// }

// foreach (var item in notas)
// {
//     Console.WriteLine($"A nota é: {item}");
// }

// double soma = 0;

// foreach (var item in notas)
// {
//     soma += item;
// }

// double media = soma / notas.Length;

// Console.WriteLine($"A média entre as notas é: {media}");

//! Ex6
// List<string> produtos = new();

// for (int i = 1; i <= 3; i++)
// {
//     Console.Write($"O nome do produto {i}º é: ");
//     produtos.Add(Console.ReadLine()!);
// }

// Console.WriteLine("\nProdutos cadastrados: ");
// foreach (var p in produtos)
// {
//     Console.WriteLine($"- {p}");
// }

// Console.Write("Nome do produto para buscar na lista: ");
// string nome = Console.ReadLine()!;

// if (produtos.Contains(nome))
// {
//     Console.WriteLine($"O produto {nome} está na lista!");
// }
// else
// {
//     Console.WriteLine("O produto não está na lista!");
// }

// Console.Write("Nome do produto: ");
// string nome1 = Console.ReadLine();

// if (produtos.Contains(nome1))
// {
//     produtos.Remove(nome1);
//     Console.WriteLine($"O produto {nome1}, foi removido da lista com sucesso!");

//     Console.WriteLine("\nLista atualizada: ");
//     foreach (var p in produtos)
//     {
//         Console.WriteLine($"- {p}");
//     }
// }