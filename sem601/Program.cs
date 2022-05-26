// Показать двумерный массив размером m×n заполненный целыми числами

/*
Console.Clear();
Console.Write("Введите кол-во строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(-10,11);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

*/
// Показать двумерный массив размером m×n заполненный целыми числами
void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }  
    }
} 
Console.WriteLine("Введите число m, n: ");
int m = int.Parse(Console.ReadLine()??"0");
int n = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [m,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


