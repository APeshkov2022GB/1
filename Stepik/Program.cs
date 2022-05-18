//Console.WriteLine("Ура!\n Сегодня \"Информатика\"!!!");
//double x= Math.E; 
 // Console.WriteLine("E={0,25}", x); //E=   2,718281828459045
 //Console.WriteLine("E={0,10}", x);// E=2,718281828459045

//   Console.WriteLine("{0:0.0000}", X*Y);
       // double X = double.Parse(Console.ReadLine());
       // double Y = double.Parse(Console.ReadLine());
       // Console.WriteLine("{0:0.000}", X/Y);
//Console.WriteLine("{0:0.000}", X/Y);  
///Console.WriteLine("Сумма денег = {0:C2}",X*Y); выводит денежный знак

//  Console.WriteLine("Введите значение");
//  double X = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("{0:0.000}", X);
//  int sum = 0;
//            for(int i = 0; i < 3; i++)
//           {
//               int number = int.Parse(Console.ReadLine());
//               sum += number;
//           }
//              Console.WriteLine(sum);


// Console.WriteLine ( "{0}, твой год рождения {1}",name, 2019 - age);

        // string name = Console.ReadLine();
        // int x = int.Parse(Console.ReadLine());
        // //int y = 2019 - x;
        // //Console.WriteLine($"{name}, твой год рождения {god}");

        // string Name = Console.ReadLine();
        //     int Age = Convert.ToInt32(Console.ReadLine());
            
        //     int Year = 2019 - Age; //Считаем год рождения

        //     Console.WriteLine("{0}, твой год рождения {1}", Name, Year);


//  string userName = Console.ReadLine();
//             int userAge = int.Parse(Console.ReadLine());
//             Console.WriteLine("{0}, твой год рождения {1}", 
//                               userName, 2019 - userAge);
        


// int  x=5; int y=9;
//   int max = (x > y) ? x : y;
//   Console.WriteLine(max);

//   int z = int.Parse(Console.ReadLine());
//         string dou = (99 >= z && z >= 10) ? "Yes" : "No";
//         Console.WriteLine(dou);

//         int x = int.Parse(Console.ReadLine());
// string twoChar = (x > 9) ? "Yes" : "No";
// Console.WriteLine(twoChar);

//  int x = int.Parse(Console.ReadLine());
//             if (x > 3 && x <= 17)
//             {
//                 Console.WriteLine("Ребёнок");
//             }
//             if (x >= 18 && x <= 69)
//             {
//                 Console.WriteLine("Взрослый");
//             }
//             if (x >= 70)
//             {
//                 Console.WriteLine("Старик");
//             }

//         int x = int.Parse(Console.ReadLine()); 
//         int y = int.Parse(Console.ReadLine()); 
//         Console.WriteLine("{0}", x>=-40 && x<=40 && y<=40 && y>=-40?"Да":"Нет");


//         int x = int.Parse(Console.ReadLine());
//         int y = int.Parse(Console.ReadLine());
//         if ((x >=-40 && x<=40) && (y >= -40 && y <=40))
//         {
//           Console.WriteLine("Да");
//         }
//         else 
//         {
//             Console.WriteLine("Нет");     
//         }


// int x = int.Parse(Console.ReadLine());

//             if (x >= 0)
//             {
//                 int y = 2 * x - 10;
//                 Console.WriteLine(y);
//             }
//             else 
//             {
//                 int y = 2 * (x * -1) -1;
//                 Console.WriteLine(y);
//             }

//             int x = int.Parse(Console.ReadLine());
// //             int y = (x>=0)? (2 * x - 10) : (2 * Math.Abs(x) - 1);
//             Console.WriteLine(y);

//  int x = int.Parse(Console.ReadLine());
//             Console.WriteLine(x >= 0? 2 * x - 10 : 2 * Math.Abs(x) - 1 );

// int x = Convert.ToInt32(Console.ReadLine());
//             if (x >= 0)
//             {
//                 Console.WriteLine((2 * x) - 10);
//             }
//             else
//             {
//                 Console.WriteLine((2 * -x) - 1);
//             }


//             int x = int.Parse(Console.ReadLine());
//             int f;
//             if (x>=0)
//             {
//                 f = 2 * x - 10;
//             }
//             else
//             {
//                 f = 2 * (-x) - 1;
//             }
//             Console.WriteLine("{0}",f);
            

            // int n = int.Parse(Console.ReadLine());
            // if (n > 7 && n <= 14) n = n - 7;
            // if (n > 14 && n <= 21) n = n - (7 * 2);
            // if (n > 21 && n <= 28) n = n - (7 * 3);
            // if (n > 28 && n <= 31) n = n - (7 * 4);
            // switch (n)
            // {
            //     case 1:
            //         Console.WriteLine("Понедельник");
            //         break;
            //     case 2:
            //         Console.WriteLine("Вторник");
            //         break;
            //     case 3:
            //         Console.WriteLine("Среда");
            //         break;
            //     case 4:
            //         Console.WriteLine("Четверг");
            //         break;
            //     case 5:
            //         Console.WriteLine("Пятница");
            //         break;
            //     case 6:
            //         Console.WriteLine("Суббота");
            //         break;
            //     case 7:
            //         Console.WriteLine("Суббота");
            //         break;
//             // }
            
// Console.Write("OPER= "); 
//   char oper=char.Parse(Console.ReadLine()); 
//   bool ok=true; 
//   Console.Write("A= "); 
//   double a=double.Parse(Console.ReadLine()); 
//   Console.Write("B= "); 
//   double b=double.Parse(Console.ReadLine()); 
//   double res=0; 
//   switch (oper) 
//   { 
//     case '+' : 
//            res = a + b;   
//            break; //1
//     case '-' : 
//            res = a - b; 
//            break; 
//     case '*' : 
//            res = a * b; 
//            break; 
//     case ':' : 
//            if (b != 0) //2 
//            { 
//              res = a / b; 
//              break; 
//            } 
//           else 
//           { 
//             goto default; 
//           } 
//      default: 
//           ok = false; 
//           break; 
//   } 
//   if (ok) 
//   { 
//     Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, res); 
//   }
//   else 
//   { 
//     Console.WriteLine("error"); 
//   } 


//  Console.WriteLine("Введите первое число: ");
//             int num1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите второе число: ");
//             int num2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение 4.Деление");

//             int operation = Convert.ToInt32(Console.ReadLine());
//             int result = 0;
//             switch (operation)
//             {
//                 case 1:
//                     result = num1 + num2;
//                     goto case 5;
//                 case 2:
//                     result = num1 - num2;
//                     goto case 5;
//                 case 3:
//                     result = num1 * num2;
//                     goto case 5;
//                 case 4:
//                     result = num1 / num2;
//                     goto case 5;
//                 case 5:
//                     if(result >= 0)
//                     {
//                         Console.WriteLine(result);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Результат отрицательный");
//                     }
//                     break;   
//                 default:
//                     Console.WriteLine("Неизвестная операция");
//                     break;
//             }
            
//  int x = int.Parse(Console.ReadLine());
//             int y = int.Parse(Console.ReadLine());
//             int s = 0;
//             if (x*y > 0) {
//                 s = 2*x + y;                
//             } else if (x*y < 0) {
//                 s = 2*Math.Abs(x) - y;
//             } else {
//                 s = 0;
//             }
//             Console.WriteLine(s);


// double x = Convert.ToDouble(Console.ReadLine());
//             double y = double.Parse(Console.ReadLine());
//             double s = (x * y > 0) ? 2 * x + y : (x * y < 0) ? 2 * Math.Abs(x) - y : 0;
//             Console.WriteLine(s);

//   int x = int.Parse(Console.ReadLine());
//             int y = int.Parse(Console.ReadLine());
            
//             Console.WriteLine((x*y) < 0 ? 2*Math.Abs(x)-y : (x*y) > 0 ? 2*x+y : 0);


// { 
//   Console.Write("N= "); 
//   int n=int.Parse(Console.ReadLine()); 
//   int i = 1; 
//   while (i <= n) //пока i меньше или равно n
//   { 
//     Console.Write(" {0}", i++ ); //выводим i на экран, затем увеличиваем его на 1
//   } 
// }


// { 
//   Console.Write("N= "); 
//   int n=int.Parse(Console.ReadLine()); 
//   int i = 0;
//   int um = 0;
//   while (i <= n && ) 
//   { 
//     um = um + 2;
//     Console.Write(n + 2 - um +" ");
//     i = i + 1; 
//   } 
// }


//  int days = 1;
//             double boost = 1.0;
//             double distance = 1000;
//             double speed = 150;
//             while (distance > 0)
//             {
//                 distance -= speed;
//                 Console.WriteLine(distance);
//                 boost += 0.1;
//                 Console.WriteLine(boost);
//                 speed *= boost;
//                 Console.WriteLine(speed);
//                 days++;
//                 Console.WriteLine(days);
//             }
//             Console.WriteLine(days + " дней");




//Console.WriteLine(Math.Pow(4, 2)); // возведение в степень  4 в степени 2


// static void Main(string[] args)
//     {
//         char selection;
//         Double x1, x2, y1, y2, z1, z2, distance;

//         Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
//         Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
//         Console.WriteLine("Выберите нужный пункт (1 или 2):");

//         selection = Convert.ToChar(Console.ReadLine());

//         switch (selection)
//         {
//             case '1':
//                 Console.Write("Введите координаты x1: ");
//                 x1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты x2: ");
//                 x2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y1: ");
//                 y1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y2: ");
//                 y2 = Convert.ToDouble(Console.ReadLine());

//                 distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//                 Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
//                 Console.ReadKey();
//                 break;
//             case '2':
//                 Console.Write("Введите координаты x1: ");
//                 x1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты x2: ");
//                 x2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y1: ");
//                 y1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты y2: ");
//                 y2 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z1: ");
//                 z1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Введите координаты z2: ");
//                 z2 = Convert.ToDouble(Console.ReadLine());

//                 distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//                 Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
//                 Console.ReadKey();
//                 break;
//             default:
//                 Console.WriteLine("Вы ввели неверный символ");
//                 Console.ReadKey();
//                 break;
//         }

//     }
// }