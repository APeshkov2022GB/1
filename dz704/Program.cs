// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void PrintMatrix(double[,] dMatrix)
{
    for (int i = 0; i < dMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            Console.Write($"{dMatrix[i, j]} ");
        Console.WriteLine();
    }
}
void PrintArray(double[] array)
{
    foreach(double value in array)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine();
}
double[,] GetFilledMatrix(int rows, int columns)
{
    double[,] dMatrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            dMatrix[i, j] = Math.Round(rnd.NextDouble() * 10, 2);

    return (dMatrix);
}
double[] GetSumDMatrixElements(double[,]dMatrix)
{
    double[] sumDMatrixElements = new double[dMatrix.GetLength(0)];
    for (int i = 0; i < dMatrix.GetLength(0); i++)
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            sumDMatrixElements[i] += dMatrix[i,j];
    return(sumDMatrixElements);
}
int SearchMinIndex(double[] array)
{
    int minIndex = 0;
    double min      = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return(minIndex);
}

Console.Clear();

Console.Write("Введите количество рядов: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество колонок: ");
int columns = int.Parse(Console.ReadLine() ?? "");
if(columns != rows)
{
    Console.WriteLine("Матрица должна быть прямоугольной!!!");
    return;
}
else
{
    double[,] dMatrix = GetFilledMatrix(rows, columns);
    Console.WriteLine("Сгенерированная матрица равна: ");
    PrintMatrix(dMatrix);
    Console.WriteLine();
    double[]  sumDMatrixElements = GetSumDMatrixElements(dMatrix);
    Console.WriteLine("Суммы элементов в строках: ");
    PrintArray(sumDMatrixElements);

Console.WriteLine($"Наименьшая сумма элементов в строке {SearchMinIndex(sumDMatrixElements)+1}.");
}
Console.WriteLine("Программа работу закончила");

