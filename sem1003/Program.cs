// Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
/*
void PrintNums(int first, int second, int n)
{
    if(n==0) return ;
    Console.WriteLine(first + second);
    int tmp = first;
    first = second;
    second += tmp;
    PrintNums(first,second,n-1);
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите первый элемент : ");
int first = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите второй элемент : ");
int second = int.Parse(Console.ReadLine()?? "");

PrintNums(first,second,N);
*/

int SumTwoPrevious(int number1, int number2, int n)
{
    if (n == 1) return number1;
    if (n == 2) return number2;
    else return SumTwoPrevious(number1, number2, n - 1) + SumTwoPrevious(number1, number2, n - 2);

}

int number1=2;
int number2=3;
int n=10;
for (int i = 1; i <= n; i++)
{
    Console.Write(SumTwoPrevious(number1, number2, i) + " ");
}
