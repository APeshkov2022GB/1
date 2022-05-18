//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine(" Введите первое число");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" Введите второе число");
int y = int.Parse(Console.ReadLine() ?? "0");
int x2 = x*x;
int y2 = y*y;
if (x2 == y) 
    Console.WriteLine("Второе число является квадратом первого ");
else if  (y2 == x)
    Console.WriteLine("Первое число является квадратом второго ");
else 
    Console.WriteLine("Введёные числа не являются квадратом ");
Console.WriteLine("Программа работу закончила");   

