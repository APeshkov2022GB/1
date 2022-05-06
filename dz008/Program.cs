// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для проверки кратности");
int kratno = int.Parse(Console.ReadLine());
if (number % kratno == 0) 
{
    Console.WriteLine($"Число {number} кратно {kratno} и делится без остатка");
}
else 
{
    int ost = number % kratno;
    Console.WriteLine("Остаток от деления = " + ost);
}
Console.WriteLine("Программа работу закончила!!!");


// // Выяснить, кратно ли число заданному, если нет, вывести остаток.
// Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// if (number1%number2 == 0) Console.WriteLine($"Число {number1} кратно числу {number2} ");
// else if (number2%number1 == 0) Console.WriteLine($"Число {number2} кратно числу {number1} ");
// else 
// {
//     Console.Write($"Числа {number1} и {number2} не кратны, ");
//     if (number1>number2) Console.WriteLine($"остаток от деления {number1} на {number2} = {number1%number2}. ");
//     else Console.WriteLine($"остаток от деления {number2} на {number1} = {number2%number1}. ");
// }






