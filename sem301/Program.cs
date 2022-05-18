//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "");
int i=1;

while (i <= n)
  {
    Console.Write(i*i + ", ");
    i = i + 1;
  }  
Console.WriteLine("Программа работу закончила");


// / Показать таблицу квадратов чисел от 1 до N
// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <=n; i++)
// {
// Console.Write($"{i * i} ");
// }