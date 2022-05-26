// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();

Console.Write("Введите размер массива: ");
int arrSize = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];
int counteven = 0;
int countodd = 0;
for (int i = 0; i < arrSize; i++)
    array[i] = new Random().Next(100, 999);

for (int i = 0; i < arrSize; i++)

{
    Console.Write(array[i] + ", ");
}
for (int i = 0; i < arrSize; i++)
{
    if (array[i] % 2 == 0)
        counteven = counteven + 1;
    else
        countodd = countodd + 1;
}
Console.WriteLine();
Console.WriteLine($" Количество чётных чисел в массиве = {counteven}");
Console.WriteLine($" Количество нечётных чисел в массиве = {countodd}");
Console.WriteLine(" Программа работу закончила");
Console.WriteLine();
