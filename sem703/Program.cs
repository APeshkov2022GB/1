// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
double MeanAriphm(int[,] matr, int column)
{
    double sum = 0; // int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
        sum = sum + matr[i,column];
        //Console.Write(sum + " ");
    return sum / matr.GetLength(0);  // return (double) sum / matr.GetLength(0);
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine()??"0");
int[,] matrix = new int [n,k];
FillArray(matrix);
Console.WriteLine("Полученный массив: ");
PrintArray(matrix);
for (int j = 0; j < matrix.GetLength(1); j++)
    Console.WriteLine($"Среднее арифметическое столбца {j+1} = {MeanAriphm(matrix, j)}"); 