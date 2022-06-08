//  Написать программу масштабирования фигуры
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
void FillArray(int[,] mas)// ввод координат x и y в двумерный массив
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.WriteLine($" Введите Х{i + 1}");
                mas[i, j] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($" Введите Y{i + 1}");
                mas[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
}

Console.Clear();
Console.WriteLine("Введите кол-во вершин фигуры: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] mas = new int[n, 2];
FillArray(mas);
PrintArray(mas);

Console.WriteLine(" Введите коэффициент масштабирования k = ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] mas1 = new int[n, 2];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas1[i, j] = mas[i, j] * k;
    }
}
PrintArray(mas1);
Console.WriteLine("Программа работу закончила");

