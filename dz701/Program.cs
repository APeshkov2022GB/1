// Написать программу, которая обменивает элементы первой строки и последней строки
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
void ChangeElements(int[,] matr, int row1, int row2)
{
    int tmp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       tmp = matr[row2, j];
       matr[row2, j] = matr[row1, j];
       matr[row1, j] = tmp;
    }
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Начальный полученный массив: ");
PrintArray(matrix);
ChangeElements(matr: matrix, row1: 0, row2: n - 1);
Console.WriteLine("Массив после замены элементов первой и последней строк: ");
PrintArray(matrix);
Console.WriteLine("Программа работу закончила");