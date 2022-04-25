//Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int y = int.Parse(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("Большее число");
    Console.WriteLine(x);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(y);
}
else
{
    Console.WriteLine("Большее число");
    Console.WriteLine(y);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(x);
}
