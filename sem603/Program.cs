// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
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
void FindElement(int[,] matr, int find)
{
    int check = 0;
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == find) 
            {
                Console.WriteLine($"В массиве найден элемент {find}, строка {i+1}, столбец {j+1}!");
                check = 1;
            }
        }  
    }
    if (check == 0) Console.WriteLine($"В массиве не найден элемент {find}!");
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [n,k];

Console.WriteLine("Введите число для поиска в массиве: ");
int num = int.Parse(Console.ReadLine()??"0");

FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
FindElement(matrix, num);
