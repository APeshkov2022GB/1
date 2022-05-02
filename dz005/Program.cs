// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int x = int.Parse(Console.ReadLine());
if (x > 99 && x < 1000)  // проверка что число трёхзное
{
    Console.Write("Вторая цыфра 3-х значного числа = ");
    Console.WriteLine(x / 10 % 10);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}
Console.WriteLine("Программа работу закончила!!!");