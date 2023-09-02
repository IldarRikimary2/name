Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Результат: ");
PrintNumbersFromNto1(N);

Console.ReadLine();

static void PrintNumbersFromNto1(int n)
{
    if (n >= 1)
    {
        Console.Write(n);
        if (n > 1)
            Console.Write(", ");
        PrintNumbersFromNto1(n - 1);
    }
}