// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату Х");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координату Y");
int y = int.Parse(Console.ReadLine() ?? "0");
if (x > 0 && y > 0)
{
    Console.WriteLine(" Первая четверть");
}
if (x > 0 && y < 0)
{
    Console.WriteLine(" Второй четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine(" Третьей четверти");
}
if (x < 0 && y > 0)
{
    Console.WriteLine(" Четвёртая четверть");
}
Console.WriteLine("Программа работу закончила");