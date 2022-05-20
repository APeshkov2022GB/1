// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int i=1;
int sum = 0;

while (i <= n)
  {
    sum = i*i*i;
    Console.WriteLine($" Квадрат числа {i}*{i}*{i} = {sum}");
    i = i + 1;
  }  
//Console.WriteLine($"Сумма чисел от 1 до {n} ={sum}");
Console.WriteLine("Программа работу закончила");