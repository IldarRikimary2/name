// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трёхзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());

bool isThreeDigits = input / 100 > 0;

if (isThreeDigits)
{
    int secondDigit = input % 10;
    Console.WriteLine("Третья цифра числа: " + secondDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}