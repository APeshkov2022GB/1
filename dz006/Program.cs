// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число из отрезка 10-99 ");
int x = int.Parse(Console.ReadLine());

if (x > 9 && x < 100)  // проверка что число трёхзное
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

