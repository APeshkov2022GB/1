// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координату x1");
double x1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату y1");
double y1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату x2");
double x2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату y2");
double y2 = double.Parse(Console.ReadLine() ?? "0");
double distance = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");

// Найти расстояние между точками в пространстве 3D

Console.WriteLine("Введите координату x1");
double x1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату y1");
double y1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату z1");
double z1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату x2");
double x2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату y2");
double y2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату z2");
double z2 = double.Parse(Console.ReadLine() ?? "0");

double distance = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)+(z2 - z1) * (z2 - z1)));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
