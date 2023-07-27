Console.WriteLine("Введите пятизначное число:");
int input = Convert.ToInt32(Console.ReadLine());

if (input <= 10000 && input >= 99999)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите пятизначное число.");
    return;
}

int num1 = input / 10000;
int num2 = (input / 1000) % 10;
int num3 = (input / 10) % 10;
int num4 = input % 10;

if (num1 == num4 && num2 == num3)
{
    Console.WriteLine("Число палиндромное");
}
else
{
    Console.WriteLine("Число не палиндромное");
}
