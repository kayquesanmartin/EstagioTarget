// 5
Console.Write("Digite a string: ");
string stringOriginal = Console.ReadLine()!;
string stringAoContrario = InverteString(stringOriginal);

Console.WriteLine($"String invertida: {stringAoContrario}");

string InverteString(string texto)
{
    char[] arrayChar = texto.ToCharArray();
    int esquerda = 0;
    int direita = arrayChar.Length - 1;

    while (esquerda < direita)
    {
        char temp = arrayChar[esquerda];
        arrayChar[esquerda] = arrayChar[direita];
        arrayChar[direita] = temp;

        esquerda++;
        direita--;
    }
    return new string(arrayChar);
}