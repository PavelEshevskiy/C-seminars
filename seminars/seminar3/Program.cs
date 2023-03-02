//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
//эта точка.

//int FindQuart(int x, int y)
//{
    //if (x > 0 && y > 0)
       // return 1;
   // if(x < 0 && y > 0)
      //  return 2;
   // if(x < 0 && y < 0)
    //    return 3;
    //if(x > 0 && y < 0)
   //     return 4;
    
   // return 0;

//}

//Console.WriteLine("Input X: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input Y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Point located at {FindQuart(x, y)} quart");

//Задача 3. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 2D 
//пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//double FindDistance(double x1, double y1, double x2, double y2)
//{
 //   return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)), 2);
//}

//Console.WriteLine("Input coordinate X of A point: ");
//double x1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of A point: ");
//double y1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate X of B point: ");
//double x2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of B point: ");
//double y2 = Convert.ToDouble(Console.ReadLine());

//double distance = FindDistance(x1, y1, x2, y2);
//Console.WriteLine($"Distance between A and B is {distance}");

//Задача 2.Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных координат точек 
//в этой четверти (x и y).

// void ShowRange(int quat)
// {
//     if(quat == 1) Console.WriteLine($"X range is (0, +inf), Y range is (0, +inf)");
//     if(quat == 2) Console.WriteLine($"X range is (0, -inf), Y range is (0, +inf)");
//     if(quat == 3) Console.WriteLine($"X range is (0, -inf), Y range is (0, -inf)");
//     if(quat == 4) Console.WriteLine($"X range is (0, +inf), Y range is (0, -inf)");
// }
// Console.WriteLine("Input the quater:");
// int quad = Convert.ToInt32(Console.ReadLine());
// if(quad < 1 | quad > 4)
// {
//     Console.WriteLine("You input wrong number");
// }
// else
// {
//     ShowRange(quad);
// }

//Задача 4. Напишите программу которая принимает на вход 
//число (N) и выдает на консоль квадраты чисел от 1 до N

//1 вариант
//double Power(double N)
//{
    //return Math.Pow(N, 2);
//}
//Console.WriteLine("Input the number N:");
//double N = Convert.ToDouble(Console.ReadLine());

//double i = 1;
//while(i <= N)
//{
//      Console.WriteLine($"{i} -> {Power(i)} ");
//      i++;
//}

//2 вариант
void Power(double N)
{
    double i = 1;
    while(i <= N)
    {
        Console.WriteLine($"{i} -> {i}^2 -> {Math.Pow(i, 2)}");
        i++;

    }
}
Console.WriteLine("Input the number N:");
double N = Convert.ToDouble(Console.ReadLine());
Power(N);