// Показать кубы чисел, заканчивающихся на четную цифру
/*
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0"); 
if (number % 2 == 0)
    Console.WriteLine($"Куб числа = {Math.Pow(number, 3)}");
else 
    Console.WriteLine("Число заканчивается на нечетную цыфру");
Console.WriteLine("Программа работу закончила");
*/


Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int i=1;
int sum = 0;

while (i <= n)
  { 
    if (i % 2 == 0)
    {
       sum = i*i*i;
       Console.WriteLine($" Квадрат числа {i}*{i}*{i} = {sum}");
       i = i + 1;
    }
    else 
       i++;
  }  
//Console.WriteLine($"Сумма чисел от 1 до {n} ={sum}");
Console.WriteLine("Программа работу закончила");
