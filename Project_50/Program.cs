// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// 

int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

Console.Write("Введите позицию элемента (строка, столбец), через запятую: ");
string input = Console.ReadLine();
string[] positions = input.Split(',');

if (positions.Length == 2 && int.TryParse(positions[0], out int row) && int.TryParse(positions[1], out int column))
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        int value = array[row, column];
        Console.WriteLine($"Значение элемента: {value}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод позиции.");
}