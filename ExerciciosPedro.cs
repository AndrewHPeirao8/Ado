
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("\n=== MENU ===");
Console.WriteLine("1 - Horário");
Console.WriteLine("2 - Disciplina");
Console.WriteLine("3 - Sala");
Console.WriteLine("4 - Sair");
Console.WriteLine("Escolha uma opção");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    Console.WriteLine("Horário: Segunda a sexta das 18:00 as 22:00");
    break;

    case 2:
    Console.WriteLine("Disciplina: Lógica de Programação");
    break;

    case 3:
    Console.WriteLine("Sala: Laboratorio 03");
    break;

    case 4:
    Console.WriteLine("Encerrando...");
    break;

    default:
    Console.WriteLine("Opção Invalida");

}

static void AvaliacaoSemReturn (double nota)
{
 if (nota >=7)
{
    Console.WriteLine("Aprovado");
}

{
if (nota >=7)
    Console.WriteLine("O aluno pode fazer a Matrícula");
}
{
    Console.WriteLine("Fim da Análise");
}

}   