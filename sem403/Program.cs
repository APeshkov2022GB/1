// найти сумму одномерного массива стоящих на нечётной позиции.

Console.Clear();
int[] array = {5, 3, 2, 1, 23, 5, 4, 6};
int result = 0;
int len = array.Length;
for (int i = 0; i < len; i++)
{
    if (i % 2 != 0 )
    {
        result = result + array[i];
        //int position = i;
        //Console.Write($" индекс {position}");
    }
    
}
Console.WriteLine();
Console.WriteLine(result);
