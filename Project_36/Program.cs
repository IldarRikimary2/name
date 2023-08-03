// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = GenerateRandomArray(4, -100, 100);
PrintArray(numbers);

int sum = SumOddPositionElements(numbers); // Находим сумму элементов на нечетных позициях
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

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

// Метод для нахождения суммы элементов на нечетных позициях
static int SumOddPositionElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }

    return sum;
}