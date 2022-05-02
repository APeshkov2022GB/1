//Выяснить является ли число чётным
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine("Введенное число является четным");
}
else
{
    Console.WriteLine("Введенное число не является четным");
}
Console.WriteLine("Программа работу закончила!!!");