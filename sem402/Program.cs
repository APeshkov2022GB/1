// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();
int[] arr = {-3, 5, 2, 1211, 323, 5, -23, 4, -6};
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}, ");

}
Console.WriteLine("Введите число для поиска в мвссиве");
int num = int.Parse(Console.ReadLine()?? "0");
int check = 0;
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] == num)
    {
        Console.WriteLine($" Заданное число {num} найдено в массиве!}");
        check = 1;
        break;
    }
}
if (check == 0) Console.WriteLine($"Заданное число {num} не найдено в массиве");










