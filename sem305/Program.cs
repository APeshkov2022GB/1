// Задать массив из 8 элементов и вывести их на экран
/*

int[] array = { 0, 0, 0, 1, 0, 1, 1, 1 };

for (int i = 0; i < array.Length; i++)
{
    Console.Write(numbers[i]+", ");
}
*/

/*
int[] array = { 0, 0, 0, 1, 0, 1, 1, 1 };
for (int i = 0; i < array.Length; i++)
{
   Console.Write($"{array[i]}, ");
}
*/



Console.Clear();
Console.WriteLine("Введите 8 элементов");

int[] array = new int[8];
for (int i = 1; i <= 8; i++)
{
    Console.Write($"Введите элемент № {i}: \n");
    array[i-1] = int.Parse(Console.ReadLine()?? "");
}
Console.WriteLine();
PrintArray(array);
// вывод на экран массива
void PrintArray(int[] array) // метод вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write(array[i]+", ");
    }
}


/*
Console.Clear();
Console.WriteLine(" Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива: ");
int arrSize = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int [arrSize];

for (int i = 0; i < arrSize; i++)
    array[i] = new Random().Next(0,100);
 
 int count = 1;

 foreach (int k in array)
 {
     Console.WriteLine($"{count} элемент массива - {k}");
     count ++;

 }
 

*/





