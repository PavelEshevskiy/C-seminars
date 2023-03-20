// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// double[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     double[,] myArray = new double[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//             myArray[i,j] = Math.Round((myArray[i,j] + new Random().NextDouble()), 2);;
//         }
//     }
//     return myArray;
// }

// void Show2DArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray (int rows, int columns)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(0, 20);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SearchElement (int[,] array, int indexRow, int indexColumn)
// {
//     if( indexRow < array.GetLength(0) && indexColumn < array.GetLength(1))
//     {
//         Console.WriteLine($"In index {indexRow}{indexColumn} is number {array[indexRow,indexColumn]}");
//     } 
//     else
//     {
//         Console.WriteLine("There is no such index");   
//     }
// }

// Console.Write("Input the quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the index of row : ");
// int indexRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the index of column : ");
// int indexColumn = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Create2DRandomArray(rows, columns);
// Show2DArray(myArray);
// SearchElement(myArray, indexRow, indexColumn);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2DRandomArray (int rows, int columns)
{
    int[,] myArray = new int[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0; j < columns;j++)
        {
            myArray[i,j] = new Random().Next(0, 10);
        }
    }
    return myArray;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MeanArifmeticColumns (int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
          sum = sum + array[i,j];
        }
        Console.WriteLine($"Mean arifmetic in column {j} -> {sum / array.GetLength(1)}");
        sum = 0;
    } 
}

Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2DRandomArray(rows, columns);
Show2DArray(myArray);
MeanArifmeticColumns(myArray);

