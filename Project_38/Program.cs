// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
PrintArray(numbers);

double diff = FindDifference(numbers); // Находим разницу между максимальным и минимальным элементами
Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");

// Метод для вывода массива на экран
static void PrintArray(double[] array)
{
    Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
}

// Метод для нахождения разницы между максимальным и минимальным элементами
static double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

    // Находим минимальный и максимальный элементы
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max - min;
}