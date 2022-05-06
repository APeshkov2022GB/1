// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число из отрезка 10-99 ");
int x = int.Parse(Console.ReadLine());

if (x > 9 && x < 100)  // проверка что число принадлежит отрезку 10-99
{
    int A = x % 10;
    int B = x / 10 % 10;
    //Console.WriteLine(A);
    //Console.WriteLine(B);
    if (A > B)
        Console.WriteLine("Наибольшая цыфра в числе = " + A);
    else 
    {
        Console.WriteLine("Наибольшая цыфра в числе = " + B);
    }
}
else
{
    Console.WriteLine("Число не принадлежит отрезку!");
}
Console.WriteLine("Программа работу закончила!!!");

// // Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// Console.WriteLine("Hello, World!");
// int n = new Random().Next(10,100);
// Console.WriteLine($"Случайно выбранное число из интервала [10, 99] = {n} ");
// int d1 = n/10;
// int d2 = n%10;
// int maxDigit = d1;
// if (d2>d1) maxDigit = d2;
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit} ");

