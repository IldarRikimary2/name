// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

int rows = array.GetLength(0);
int columns = array.GetLength(1);

double[] columnAverages = new double[columns];

for (int j = 0; j < columns; j++)
{
    int columnSum = 0;
    for (int i = 0; i < rows; i++)
    {
        columnSum += array[i, j];
    }
    columnAverages[j] = (double)columnSum / rows;
}

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < columns; j++)
{
    Console.Write(columnAverages[j].ToString("0.0"));
    if (j < columns - 1)
    {
        Console.Write("; ");
    }
}