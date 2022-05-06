// Показать четные числа от 1 до N
Console.WriteLine("Введите число от 1 до N");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        Console.Write(i + " ");
    }
Console.WriteLine("Программа работу закончила!!!");
 
//   Показать четные числа от 1 до N
//  Console.WriteLine("Введите число > 1: ");
//  int n = int.Parse(Console.ReadLine());
//  int n1 = 1;
//  if (n < 1) Console.WriteLine("Введённое значение не удовлетворяет условию 'Введите число > 1' ");
//  else Console.WriteLine($"Четные числа в интервале от 1 до {n}: ");
//  while (n1 <= n)
//  {
//    if (n1%2 == 0)
//    {
//    Console.Write($"{n1} ");
//    }
//    n1++;
//  }