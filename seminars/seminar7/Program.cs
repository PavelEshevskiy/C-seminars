//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }
// // 1 2 3
// // 4 5 6
// // 7 8 9

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

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,] Create2DArray (int rows, int columns)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = i + j;
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

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DArray(rows, columns));


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса 
//чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
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

// int [,] EvenElementsArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j <array.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             array[i,j] = array[i,j] * array[i,j];
//         }
//     }
//     return array;
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// EvenElementsArray(myArray);
// Show2DArray(myArray);

//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
//Главная диагональ это когда i и j совпадают
//Например, задан массив:

//1 4 7 2                      
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] myArray = new int[rows, columns];
    for(int i = 0; i < rows;i++)
    {
        for(int j = 0; j < columns;j++)
        {
            myArray[i,j] = new Random().Next(minValue, maxValue + 1);
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

int SumMainDiagonal(int [,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            if(i == j)
            sum += array[i,j];
        }
    }
    return sum;
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);
Show2DArray(myArray);
Console.WriteLine($"Sum elements of the main diagonal: {SumMainDiagonal(myArray)}");