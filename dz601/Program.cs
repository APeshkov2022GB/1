// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
            matrix[i,k] = rnd.NextDouble() * 100;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write(matrix[i,k] + " ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Enter the number of lines: ");
int m = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("Enter the number of columnes: ");
int n = int.Parse(Console.ReadLine()?? "");

double[,] matrix = new double[m,n];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Программа работу закончила");