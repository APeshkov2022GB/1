//  Найти сумму чисел от 1 до А
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "");
int i=0;
int sum = 0;

while (i <= n)
  {
    sum = sum+i;
    //Console.Write(sum + ", ");
    i = i + 1;
  }  
Console.WriteLine($"Сумма чисел от 1 до {n} ={sum}");
Console.WriteLine("Программа работу закончила");