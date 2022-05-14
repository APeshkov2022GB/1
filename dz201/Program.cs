//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine(" Введите число обозначающий день недели.");
int day = int.Parse(Console.ReadLine() ?? "0");
if (day == 6 || day == 7)
{
    Console.WriteLine(" Номер дня недели является выходным");
}
else Console.WriteLine(" Номер дня недели не является выходным");
Console.WriteLine("Программа работу закончила");
