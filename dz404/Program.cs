// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] arr = new int[123];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100,100); 
    Console.Write($"{arr[i]} ");
    if (arr[i] >= 10 && arr[i] <= 99) count++;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов массива из отрезка [10,99] равно {count}!");
Console.WriteLine("Программа работу закончила");