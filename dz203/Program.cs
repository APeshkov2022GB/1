// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine() ?? "0");
if (number == 1)
{
    Console.WriteLine(" Диапазон координат  (x > 0 и y > 0)");
}
if (number == 2)
{
    Console.WriteLine(" Диапазон координат  (x > 0 и y < 0)");
}
if (number == 3)
{
    Console.WriteLine(" Диапазон координат  (x < 0 и y < 0)");
}
if (number == 4)
{
    Console.WriteLine(" Диапазон координат (x < 0 и y > 0)");
}
Console.WriteLine("Программа работу закончила");