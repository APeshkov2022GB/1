//Программа проверяет пятизначное число на палиндромом.
// Console.WriteLine("Введите пятизначное число");
// int number = int.Parse(Console.ReadLine() ?? "0");
// int digit5 = number % 10; //Console.WriteLine(digit5);
// int digit4 = number / 10 % 10; //Console.WriteLine(digit4);
// int digit3 = number / 100 % 10; //Console.WriteLine(digit3);
// int digit2 = number / 1000 % 10; //Console.WriteLine(digit2); 
// int digit1 = number / 10000 % 10; //Console.WriteLine(digit1);
// int newnumber = digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
// Console.WriteLine(newnumber);
// if (number == newnumber)
// {
//     Console.WriteLine(" Заданное число является полиндромом");

// }
// else
// {
//     Console.WriteLine(" Заданное число не является полиндромом");
// }
//////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Введите пятизначное число");
int count = int.Parse(Console.ReadLine() ?? "0"); 
int count2 = count;
int index = 0;
while ( count > 0)
{
    int digit = count % 10; Console.WriteLine(digit);
    index = index *10 + digit; Console.WriteLine(index);
    count = count / 10; Console.WriteLine(count); 
}
if ( index == count2)
{
    Console.WriteLine("Это палиндром");    
}
else
{
    Console.WriteLine("Это не палиндром");
}


