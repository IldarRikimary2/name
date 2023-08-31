// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

SortRowsDescending(array);

// Вывод отсортированного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

static void SortRowsDescending(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        // Создаем временный массив для сортировки текущей строки
        int[] tempArray = new int[colCount];
        for (int j = 0; j < colCount; j++)
        {
            tempArray[j] = array[i, j];
        }

        // Сортируем временный массив в порядке убывания
        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        // Копируем отсортированные значения обратно в исходный массив
        for (int j = 0; j < colCount; j++)
        {
            array[i, j] = tempArray[j];
        }
    }
}