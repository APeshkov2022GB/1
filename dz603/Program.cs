// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(0, 10);
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

void SqIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) 
                matrix[i, j] = matrix[i, j] * matrix[i, j];
}

Console.Clear();
Console.Write("Введите кол-во строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
Console.WriteLine("Массив с квадратами элементов с четными индексами: ");
SqIndex(matrix);
PrintArray(matrix);
Console.WriteLine("Программа работу закончила");