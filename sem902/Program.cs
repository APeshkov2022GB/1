// Написать программу возведения числа А в целую стень B

// Написать программу возведения числа А в целую стень B
int PowAB(int a, int b)
{
    if(b==0) return 1;
    else return PowAB(a, b - 1) * a;
}

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()?? "");

Console.WriteLine($"Число {A} в степени {B} равно {PowAB(A,B)}");
