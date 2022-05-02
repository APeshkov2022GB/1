// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для проверки кратности");
int kratno = int.Parse(Console.ReadLine());

if (number % kratno == 0) 
{
    Console.WriteLine($"Число {number} кратно {kratno} и делится без остатка");
}
else 
{
    int ost = number % kratno;
    Console.WriteLine("Остаток от деления = " + ost);
}
Console.WriteLine("Программа работу закончила!!!");









