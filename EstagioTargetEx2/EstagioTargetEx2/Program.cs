// 2
Console.Write("Informe um número inteiro positivo: ");
int numeroInformado = int.Parse(Console.ReadLine()!);

if (VerificaFibonacci(numeroInformado))
    Console.WriteLine($"{numeroInformado} pertence à sequência de Fibonacci.");
else
    Console.WriteLine($"{numeroInformado} não pertence à sequência de Fibonacci.");

Console.ReadKey();

bool VerificaFibonacci(int num)
{
    int a = 0;
    int b = 1;

    while (b < num)
    {
        int temp = a + b;
        a = b; 
        b = temp;
    }
    return b == num;
}