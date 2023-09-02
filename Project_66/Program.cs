Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

int sum = CalculateSum(M, N);

Console.WriteLine("Сумма натуральных элементов от " + M + " до " + N + " равна: " + sum);

Console.ReadLine();

static int CalculateSum(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}
