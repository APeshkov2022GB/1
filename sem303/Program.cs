//Определить количество цифр в числе
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "");
int digits = 0;
while (n > 0)
{
    n = n / 10;
    digits ++;
}
Console.WriteLine("Количество цыфр:" +digits ); 
Console.WriteLine("Программа работу закончила");


// //Определить количество цифр в числе
// Console.WriteLine("Insert ur number");
// int number = int.Parse(Console.ReadLine() ?? "0");
// string c;
// c = number.ToString();
// int c1 = c.Length;
// Console.WriteLine($"Digits in {number} is {c1}");