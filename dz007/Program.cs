// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int x = int.Parse(Console.ReadLine());
if (x > 99 && x < 1000)  // проверка что число трёхзначное
{
    int odin = x / 100 % 10;
    int dva = x / 10 % 10;
    int tri = x % 10;
    Console.Write("Первая цыфра 3-х значного числа = ");
    Console.WriteLine(odin);
    Console.Write("Вторая цыфра 3-х значного числа = ");
    Console.WriteLine(dva);
    Console.Write("Третья цыфра 3-х значного числа = ");
    Console.WriteLine(tri);
    int chislo = odin * 10 + tri;
    Console.Write("Число после удаления второй цыфры =  ");
    Console.WriteLine(chislo);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}
Console.WriteLine("Программа работу закончила!!!");
