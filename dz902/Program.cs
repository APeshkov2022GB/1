// Найти сумму элементов от M до N, N и M заданы
int RecursionSum(int min, int max)
{
    int sum = min;
    if (max == min)
        return sum;
    return(sum + RecursionSum(min + 1, max));
}
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (m > n)
{
    Console.WriteLine("Число M больше числа N, меняем их местами");
    int tmp = m; 
    m = n; 
    n = tmp;
}
Console.WriteLine($"Сумма чисел от {m} до {n} = {RecursionSum(m, n)}");
Console.WriteLine(" Программа работу закончила");