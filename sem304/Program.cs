// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int i=1;
int sum = 1;

while (i <= n)
  {
    sum = sum*i;
    //Console.Write(sum + ", ");
    i = i + 1;
  }  
Console.WriteLine($"Сумма чисел от 1 до {n} ={sum}");
Console.WriteLine("Программа работу закончила");
