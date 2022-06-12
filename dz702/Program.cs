// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.
void PrintMatrix(double[,] dMatrix)
{
    for (int i = 0; i < dMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            Console.Write($"{dMatrix[i, j]} ");
        Console.WriteLine();
    }
}
double[,] GetFilledMatrix(int rows, int columns)
{
    double[,] dMatrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            dMatrix[i, j] = Math.Round(rnd.NextDouble() * 10, 2);

    return (dMatrix);
}
void MatrixDescendingSort(double[,] dMatrix)
{
    for (int i = 0; i < dMatrix.GetLength(0); i++)
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            for (int k = 0; k < dMatrix.GetLength(1) - 1; k++)
                if (dMatrix[i, k] < dMatrix[i, k + 1])
                {
                    double tmp               = dMatrix[i, k];
                           dMatrix[i, k]     = dMatrix[i, k + 1];
                           dMatrix[i, k + 1] = tmp;
                }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] dMatrix = GetFilledMatrix(rows, columns);
PrintMatrix(dMatrix);
Console.WriteLine();
MatrixDescendingSort(dMatrix);
PrintMatrix(dMatrix);
Console.WriteLine("Программа работу закончила");