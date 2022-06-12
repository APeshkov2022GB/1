// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).
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
int[,] Change(int[,] matr)
{
    int length = matr.GetLength(0);
    int[,] newMatr = new int[length, length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            newMatr[i, j] = matr[j, i];
        }
    }
    return newMatr;
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[n, k];
if (matrix.GetLength(0) != matrix.GetLength(1))
    Console.WriteLine("Матрица не квадратная, замена строк на столбцы невозможна!");
else
{
    FillArray(matrix);
    Console.WriteLine("Начальный полученный массив: ");
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    matrix = Change(matrix);
    Console.WriteLine("Массив после замены строк на столбцы: ");
    Console.WriteLine();
    PrintArray(matrix);
}
Console.WriteLine("Программа работу закончила");