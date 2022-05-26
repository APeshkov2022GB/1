//В двумерном массиве n×k заменить четные элементы на противоположные
// В двумерном массиве n×k заменить четные элементы на противоположные
/*

int[,] matr = new int [3,4];
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,10);
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          
            if(matr[i,j] % 2 == 0)  matr[i,j] = -matr[i,j];
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }

*/

//

// В двумерном массиве n×k заменить четные элементы на противоположные
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
void EvenToOposite(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] % 2 == 0) matr[i,j] = - matr[i,j];
        }  
    }
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [n,k];

FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
EvenToOposite(matrix);
Console.WriteLine("Массив после замены нечетных элементов на противоположные: ");
PrintArray(matrix);

/*

//В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] array)
{
    Random rnd           = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.Next(-100,101);
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void ChangeEvenElements(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j]%2 == 0) array[i,j] = -array[i,j];
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();      
    }

}
//--------------------------------------------------------------------------------------------+
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количество строк в массиве: ");
int columns = int.Parse(Console.ReadLine()?? "");

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
ChangeEvenElements(array);
PrintArray(array);
*/

//---------------------------------------------------------------------------------------------------------------