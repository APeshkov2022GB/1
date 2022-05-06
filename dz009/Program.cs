// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Ведите число до 9999");
int namber = int.Parse(Console.ReadLine());
Console.WriteLine($"Дано число: {namber}");
if (namber / 100 > 0) 
    Console.WriteLine($" третьей цыфрой числа {namber} является цыфра {namber / 10 % 10}");
else 
    Console.WriteLine($"У числа {namber} нет третьей цыфры");
Console.WriteLine("Программа работу закончила!!!");  


// // Найти третью цифру числа или сообщить, что её нет
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()?? "0");
// if (n > 99 && n < 1000 || n > -1000 && n < -99)
// Console.WriteLine($"Третья цифра трёхзначного числа = {n%10} ");
// else if (n > -100 && n < 100)
// Console.WriteLine("Введено число, в котором нет третьей цифры! ");
// else
// {
//     while (n > 999 || n < -999)
//     n=n/10;
// Console.WriteLine($"Третья цифра четырёхзначного или большего числа = {Math.Abs(n%10)} ");
// }