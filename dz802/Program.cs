// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] IndexesOfMinElementIn2DArray(int[,] matr)
{
    int[] indexes = new int[2];
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}
int[,] DeleteRowAndColumn(int[,] matr, int row, int column)
{
    int[,] newMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (i >= row && j < column)
                newMatr[i, j] = matr[i + 1, j];
            else if (j >= column && i < row)
                newMatr[i, j] = matr[i, j + 1];
            else if (i >= row && j >= column)
                newMatr[i, j] = matr[i + 1, j + 1];
            else
                newMatr[i, j] = matr[i, j];
        }
    }
    return newMatr;
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Полученный массив целых чисел:");
PrintArray(matrix);
Console.WriteLine($"Индексы минимального элемента: строка = {IndexesOfMinElementIn2DArray(matrix)[0] + 1} "
                                                + $"столбец = {IndexesOfMinElementIn2DArray(matrix)[1] + 1}");
Console.WriteLine("Массив после удаления строки и столбца,"
                + " на пересечении которых расположен наименьший элемент:");
PrintArray(DeleteRowAndColumn(matr: matrix,
                              row: IndexesOfMinElementIn2DArray(matrix)[0],
                              column: IndexesOfMinElementIn2DArray(matrix)[1]));
Console.WriteLine("Программа работу закончила");