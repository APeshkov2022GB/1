//Показать последнюю  цыфру трёхзначного числа.
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());
Console.Write("Последняя цыфра 3-х значного числа = ");
Console.WriteLine(x % 10);
