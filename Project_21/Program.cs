Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double deltaX = x2 - x1;
double deltaY = y2 - y1;
double deltaZ = z2 - z1;

double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
Console.WriteLine($"Distance: {distance}");
