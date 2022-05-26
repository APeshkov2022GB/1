// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.Write("Введите размер массива: ");
int array = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[array];
int[] result = new int [array/2];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-5,5); 
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.Write(" Произведение пар чисел: ");
for (int i = 0; i < array / 2; i++)
{
    result[i]= arr[i] * arr[array - 1 - i];
    Console.Write($"{result[i]} ");
}
Console.WriteLine();
Console.WriteLine("Программа работу закнчила");