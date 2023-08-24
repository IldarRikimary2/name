// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = GenerateRandomMatrix(m, n);

// Вывод массива на консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j].ToString("0.0") + "\t");
    }
    Console.WriteLine();
}

static double[,] GenerateRandomMatrix(int m, int n)
{
    Random random = new Random();
    double[,] matrix = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = (random.NextDouble() * 20) - 10; // Генерация случайного вещественного числа от -10 до 10 с одним знаком после запятой
        }
    }

    return matrix;
}