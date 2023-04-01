//Leia 2 números inteiros e exiba o resultado da soma

int num1;
int num2;
int Resultado;


Console.WriteLine("----Calculo de Somas----\n");

Console.Write("Digite seu primeiro valor:");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite seu segundo valor:");
num2 = int.Parse(Console.ReadLine()!);

Resultado = num1 + num2;

Console.WriteLine($"A soma entre {num1} e {num2} é igual a {Resultado}");
Console.WriteLine();
