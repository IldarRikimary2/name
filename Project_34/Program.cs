// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = GenerateRandomArray(4, 100, 999);
PrintArray(numbers);

int evenCount = CountEvenNumbers(numbers); // Получаем количество четных чисел в массиве
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

// Метод для генерации массива случайных чисел
static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

// Метод для вывода массива на экран
static void PrintArray(int[] array)
{
    Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");
}

// Метод для подсчета количества четных чисел в массиве
static int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }

    return count;
}