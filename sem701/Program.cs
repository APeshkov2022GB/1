// От Олега Голенищева. Разбор задачи про координаты и масштаб фигуры
int CountSymbol(string str, char symbol)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i] == symbol)
            count++;
    return count;
}
string[] Split(string str, char symbol)
{
    string[] coordinates = new string[CountSymbol(str, symbol) + 1];
    int amount = 0;
    for (int i = 0; i < str.Length; i++)
    {
        while (i < str.Length && str[i] != symbol)
        {
            coordinates[amount] += str[i];
            i++;
        }
        amount++;
    }
    return coordinates;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
string Substring(string str, int startIndex, int lastIndex)
{
    string result = "";
    for (int i = startIndex; i < lastIndex; i++)
        result += str[i];
    return result;
}
int[,] ParsePoints(string[] coordinates)
{
    int[,] points = new int[coordinates.Length, 2];
    for (int i = 0; i < coordinates.Length; i++)
    {
        string substring = Substring(coordinates[i], 1, coordinates[i].Length - 1); // string substring = coordinates[i].Substring(1,coordinates[i].Length-1)
        string[] pointCoordinates = Split(substring, ','); // string[] pointCoordinates = substring.Split(',');
        for (int j = 0; j < pointCoordinates.Length; j++)
            points[i, j] = int.Parse(pointCoordinates[j]);
    }
    return points;
}
Console.Write("Enter coordinates of figure: ");
string input = Console.ReadLine() ?? "";
if (input == null || input.Length == 0)
{
    Console.WriteLine("Enter not empty string");
    return;
}
Console.Write("Enter koefficient of scaling: ");
int k = int.Parse(Console.ReadLine() ?? "0");
string[] coordiates = Split(input, ' '); // string[] coordinates = input.Split(' ');
PrintArray(coordiates);
int[,] points = ParsePoints(coordiates);
PrintMatrix(points);
for (int i = 0; i < points.GetLength(0); i++)
    Console.Write($"({points[i, 0] * k}, {points[i, 1] * k}) ");