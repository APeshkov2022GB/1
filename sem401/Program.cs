// написать программу замену элементов массива на противоположные
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
void change(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < array.Length; i++)
    {
        //array[i] = 0 - array[i];          или
        array[i] = - array[i];
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}, ");
    }
}
change(array);
PrintArray(array);
Console.WriteLine();
/*
void change1(int[] array)
{
    int count = array.Length;
    for (int z = 0; z < (count / 2); z++)
    {
        int tmp = array[z];
        array[z] = array[((count - 1) - z)];
        array[((count - 1) - z)] = tmp;
    }
    
}

change1(array);
PrintArray(array);
Console.WriteLine();
*/