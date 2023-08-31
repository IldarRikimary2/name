int n = 4;
int[,] array = new int[n, n];

FillSpiralArray(array, n);

PrintArray(array);

static void FillSpiralArray(int[,] array, int n)
{
    int currentValue = 1;
    int rowStart = 0, rowEnd = n - 1;
    int colStart = 0, colEnd = n - 1;

    while (currentValue <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = currentValue;
            currentValue++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = currentValue;
            currentValue++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = currentValue;
            currentValue++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = currentValue;
            currentValue++;
        }
        colStart++;
    }
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j].ToString("D2") + " ");
        }
        Console.WriteLine();
    }
}