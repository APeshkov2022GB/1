// Показать четные числа от 1 до N
Console.WriteLine("Введите число от 1 до N");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        Console.Write(i + " ");
    }
Console.WriteLine("Программа работу закончила!!!");

