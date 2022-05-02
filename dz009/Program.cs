// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Ведите число до 9999");
int namber = int.Parse(Console.ReadLine());
Console.WriteLine($"Дано число: {namber}");
if (namber / 100 > 0) 
    Console.WriteLine($" третьей цыфрой числа {namber} является цыфра {namber / 10 % 10}");
else 
    Console.WriteLine($"У числа {namber} нет третьей цыфры");
Console.WriteLine("Программа работу закончила!!!");  
