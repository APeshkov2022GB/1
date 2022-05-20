// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int count = int.Parse(Console.ReadLine() ?? "0"); 
int index = 0;
while ( count > 0)
{
    int digit = count % 10; //
    index = index + digit; //
    count = count / 10; //
}

Console.WriteLine(index);
