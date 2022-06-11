// Найти сумму цифр числа РЕКУРСИЕЙ

int NumberSum(int n)
{
    if(n == 0) return 0;
    else 
    {
        return(n % 10 + NumberSum(n / 10));;
    }
}
Console.WriteLine(" Введите Число");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(NumberSum(n));


