// Задать массив из 12 элементов, заполненных числами из [-9,9]. 
//Найти сумму положительных/отрицательных элементов массива
int[] array = {9, -1, 1, 1, 9, 9, 1, 1, 1, 1, 1, 9};

int positiv = 0;
int negative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        positiv = positiv + array[i];
    else 
        negative = negative + array[i];    
}
Console.WriteLine($"Сумма  чисел в массиве array:\n положительных = {positiv}, \n отрицательных = {negative}");
Console.WriteLine("Программа работу закончила");
Console.WriteLine();