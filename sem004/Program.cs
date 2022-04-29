// показать числа от -N до N
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());

int min = -x;

while(min <= x)
{
    //Console.WriteLine(" " + min);  или // console.WriteLine(min); столбиком виведет значения
    Console.Write(" " + min);
    //min = min +1; min += 1;
    min++;
}
Console.WriteLine(" ");    
Console.WriteLine("Программа работу закончила!!!");    
