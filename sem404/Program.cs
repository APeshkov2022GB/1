// В массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arr = new double [10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().NextDouble()*1000;
    arr[i] = Math.Round(arr[i],2);
    Console.WriteLine($"{arr[i]}");
}
double max = arr[0];   // присваивание значение мин и макс
double min = arr[0];

for (int i = 1; i < arr.Length; i++)  // цыкл поиска минимально и максимального значения в массиве
{
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];    
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница = {max-min}");


//-----------------------------------------------------------------
/*
Console.Clear();
double[] array = {5, 352.26, 3.33, 2.56 };
double max = array[1];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"{max} - {min} = {max-min}");
*/
