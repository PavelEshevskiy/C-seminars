//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


// using System.Linq;

// Console.Write("Input M integers numbers separated by spaces:");
// var numbers = Console.ReadLine();

// int[] array = numbers.Split(' ')
//                             .Select(int.Parse)
//                             .ToArray();
  
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// int OutputPosNum(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine();
// Console.WriteLine ($"Number of numbers greater than 0 -> {OutputPosNum(array)}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void IntersectionStraightLine(double b1, double k1, double b2, double k2)
{
    double x = Math.Round(-(b1 - b2) / (k1 - k2), 3);
    double y = Math.Round(k1 * x + b1, 3);
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Straight lines match");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Straight lines is parallel");
    }
    else
    {
        Console.WriteLine($"Lines do not intersect in point: ({x},{y})");
    }
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
 
IntersectionStraightLine(b1, k1, b2, k2);

 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
//Console.WriteLine($"Пересечение в точке: ({x};{y})");
