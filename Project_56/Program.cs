int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

int minSumRow = FindRowWithMinSum(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("\nСтрока с наименьшей суммой элементов: " + (minSumRow + 1));

static int FindRowWithMinSum(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);
    int minSum = int.MaxValue;
    int minSumRow = -1;

    for (int i = 0; i < rowCount; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < colCount; j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRow = i;
        }
    }

    return minSumRow;
}

static void PrintArray(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}