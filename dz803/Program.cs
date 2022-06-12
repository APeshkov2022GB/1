// Сформировать трехмерный массив не повторяющимися двузначными числами,
//  показать его построчно на экран выводя индексы соответствующего элемента.
void Fill3DArray(int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = count;
                count++;
            }
}
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
                Console.Write($"Элемент[{i},{j},{k}] = {matr[i, j, k]} ");
            Console.WriteLine();
        }
}
Console.Clear();
Console.Write("Введите 1-е измерение массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е измерение массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3-е измерение массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = new int[n, m, k];
if (n * m * k + 9 > 99)
{
    Console.WriteLine($"Невозможно заполнить 3-х мерную матрицу с измерениями {n}, {m}, {k}");
    Console.WriteLine("не повторяющимися двухзначными числами! Будут также использованы трехзначные числа.");
}
Fill3DArray(matrix);
Print3DArray(matrix);
Console.WriteLine("Программа работу закончила");