//  Найти точку пересечения двух прямых
// заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Clear();
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine() ?? "");
if (k1 == k2)
    Console.WriteLine(" Прямые параллельны, точек переcечения нет");
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k2 * x + b2;
    Console.WriteLine($"Прямые пересекаются в точке с координатой х= {x},y = {y}");
}
Console.WriteLine("Программа работу закончила!!! ");
