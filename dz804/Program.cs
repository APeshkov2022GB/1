// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.
void PrintPascalTriangle(int[,] pascal)
{
    for (int i = 0; i < pascal.GetLength(0); i++)
    {
        string pascalPrint = String.Empty;
        for (int j = 0; j < pascal.GetLength(1); j++)
        {
            if (pascal[i, j] == 0)
                Console.Write("    ");
            else
            {
                pascalPrint = Convert.ToString(pascal[i, j]);
                while (pascalPrint.Length < 4) 
                    pascalPrint += " ";
                Console.Write(pascalPrint);
            }
        }
        Console.WriteLine();
    }
}
int[,] FillPascalTriangle(int height)
{
    int[,] pascal = new int[height, height * 2 + 1];
    pascal[0, height] = 1;
    for (int i = 1; i < height; i++)
        for (int j = 1; j < height * 2; j++)
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j + 1];
    return pascal;
}
Console.Clear();
Console.Write("Введите высоту треугольника Паскаля: ");
int height = int.Parse(Console.ReadLine() ?? "0");
PrintPascalTriangle(FillPascalTriangle(height));
Console.WriteLine("Программа работу закончила");
