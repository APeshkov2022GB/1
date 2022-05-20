// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите степень B");
int b = int.Parse(Console.ReadLine() ?? "");
for (int i = 0; i <= b; i++)   
    Console.WriteLine($"{a}^{i} = {Math.Pow(a, i)}");
Console.WriteLine("Программа работу закончила");
  
