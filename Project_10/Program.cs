// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());

bool isThreeDigits = input / 100 > 0;

if (isThreeDigits)
{
    int secondDigit = (input / 10) % 10;
    Console.WriteLine("Вторая цифра числа: " + secondDigit);
}
else
{
    Console.WriteLine("Ошибка! Введите корректное трёхзначное число.");
}