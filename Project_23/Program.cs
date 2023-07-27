Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < n)
{
    int num = 1;
    num *= i * i * i; // **3
    Console.WriteLine(num);
    i++;
}