// В матрице чисел найти сумму элементов главной диагонали
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
int SumOfDiagonal(int[,] matr)
{
    int sum = 0;
    for (int i =0; i < matr.GetLength(0); i++)
    {
        sum = sum + matr[i,i];
    }
    return sum;
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов квадтраной матрицы ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] square = new int[k,k];
FillArray(square);
Console.WriteLine("Такая получилась матрица:");
PrintArray(square);
Console.WriteLine($"Сумма элементов главной диагонали: {SumOfDiagonal(square)}");
