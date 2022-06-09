// Написать программу копирования массива
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
int[,] matrix1 = new int [m,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix1[i,j] = matrix[i,j]; 
        }  
    }
PrintArray(matrix1);

Console.WriteLine("Программа работу закончила");