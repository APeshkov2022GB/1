// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
        for (int n = 0; n < matrix.GetLength(1); n++)
            matrix[m, n] = m + n;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Программа работу закончила");