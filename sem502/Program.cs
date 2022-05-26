// Написать программу преобразования десятичного числа в двоичное
/*
Console.WriteLine("Enter decimal number: ");
int number10 = int.Parse(Console.ReadLine() ?? "0");
string number2 = "";
while (number10 > 0 )
{
    number2 = number10%2 + number2;
    number10 = number10/2;
}
Console.WriteLine($"number2 = {number2} ");
*/
/*
Console.WriteLine("Enter decimal number: ");
int number10 = int.Parse(Console.ReadLine() ?? "0");
int number2 = 0;
while (number10 > 0 )
{
    number2 = number10%2 + number2;
        Console.WriteLine($"number2 = {number2} ");
    number10 = number10/2;
        Console.WriteLine($"number10 = {number10} ");
}
Console.WriteLine($"number2 = {number2} ");
*/
----------------------------------------------------
/*
void FillArray(int[] array) 
{
    int tmp = 0;
    int index = 0;
    int length = array.Length;
    while(index < length)
    {
        tmp = number % 2;
        number = number /2;
        array[index] = tmp;

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
//Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int tmpnumber = number;
int tmp = 0;
int count = 0;
while(tmpnumber > 0)
    {
        tmp = tmpnumber % 2;
        tmpnumber = tmpnumber /2;
        count++;
    }

int[] array = new int[count];
FillArray(array);
PrintArray(array.Reverse().ToArray()); //Reverse array
*/
----------------------------------------------------------------------------------------
//Написать программу преобразования десятичного числа в двоичное
/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;
string result = " ";
//int result = 0;

while(a > 0)
{
    b = a % 2;
    result = b + result;
    a = a / 2;
  
}
Console.WriteLine(result);
*/

/*
// Показать числа Фибоначчи меньше заданного числа N
Console.Write("Введите конец диапазона от 1 до : ");
int end = int.Parse(Console.ReadLine() );
int j = 1;
for (int i = 1; i <= end; i += j)
{
    Console.Write("{0} ", i);
    j = i - j;
}
Console.ReadLine();
*/

//Показать числа Фибоначчи меньше заданного числа N
/*
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;
int b = 0;
int result;
for (int i =0;i < n;i++)
{
    result = a + b;
    Console.WriteLine(result + " ");
    a = b;
    b = result;
}
*/

// Показать числа Фибоначчи меньше заданного числа N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "");

int firstValue  = 0;
int secondValue = 1;
int result      = 0;
Console.Write($"{firstValue} {secondValue} ");

while(firstValue + secondValue < N)
{
    result = firstValue + secondValue;
    Console.Write(result + " ");
    firstValue = secondValue;
    secondValue = result;
}

