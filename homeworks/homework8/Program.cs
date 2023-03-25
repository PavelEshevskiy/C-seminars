// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

// int[,] SortedArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = SortedArray(myArray);

// Show2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

// int[] SumRows(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Array is not rectangular");
//         return null;
//     }
//     else
//     {
//         int[] arraySumRows = new int[array.GetLength(0)];
//         for(int i = 0; i < array.GetLength(0);i++)
//         {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 arraySumRows[i] = arraySumRows[i] + array[i,j];
//             }
//         }
//         return arraySumRows;
//     }
// }

// void FindRowWithMinSum(int[] array)
// {
//     int minSumRow = array[0];
//     int minRow = 0;
//     for(int i = 0; i < array.Length;i++)
//     {
//         if(array[i] < minSumRow)
//         {
//             minSumRow = array[i];
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"Number of the row with the smallest sum of elements: {minRow + 1}");
// }

// Console.Write("Input the number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);
// int[] arraySumRows = SumRows(myArray);
// FindRowWithMinSum(arraySumRows);


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateFirstMatrix (int rows1, int columns1)
// {
//     int[,] firstMatrix = new int[rows1, columns1];
//     for(int i = 0; i < rows1;i++)
//     {
//         for(int j = 0; j < columns1;j++)
//         {
//             firstMatrix[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return firstMatrix;
// }

// int[,] CreateSecondMatrix (int rows2, int columns2)
// {
//     int[,] secondMatrix = new int[rows2, columns2];
//     for(int i = 0; i < rows2;i++)
//     {
//         for(int j = 0; j < columns2;j++)
//         {
//             secondMatrix[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return secondMatrix;
// }

// int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
//     {
//         Console.WriteLine("Multiplication matrix is not possible");
//     }
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for(int i = 0; i < firstMatrix.GetLength(0);i++)
//     {
//         for(int j = 0; j < secondMatrix.GetLength(1);j++)
//         {
//             resultMatrix[i,j] = 0;
//             for(int k = 0; k < firstMatrix.GetLength(1);k++)
//             {
//                 resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// void ShowMatrix (int[,] array)
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

// Console.Write("Input the number of rows for the first matrix: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns for the first matrix: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of rows for the second matrix: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of columns for the second matrix: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Input minimal value: ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Input maximal value: ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = CreateFirstMatrix(rows1, columns1);
// Console.WriteLine("First matrix: ");
// ShowMatrix(firstMatrix);

// int[,] secondMatrix = CreateSecondMatrix(rows2, columns2);
// Console.WriteLine("Second matrix: ");
// ShowMatrix(secondMatrix);

// int[,] multiplicationMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
// Console.WriteLine("Result multiplication matrix: ");
// ShowMatrix(multiplicationMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray (int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] myArray = new int[x, y, z];
//     for(int i = 0; i < x;i++)
//     {
//         for(int j = 0; j < y;j++)
//         {
//             for(int k = 0; k < z;k++)
//             {
//                 myArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//                 //(int)(Math.Round(Math.Pow(minValue, i) + Math.Pow(maxValue, j) + Math.Pow(maxValue, k)));
//             }
//             //myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show3DArray (int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             for(int k = 0; k < array.GetLength(2);k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input the number of x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the number of z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z, minValue, maxValue);

// Show3DArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillArraySpiral(int rowP, int colP, int count, int[,] array)
// {
//         // заполнение периметра
//     for (int j = 0; j < colP; j++)
//     {
//         array[0, j] = count;
//         count++;
//     }
//     for (int i = 1; i < rowP; i++)
//     {
//         array[i, colP - 1] = count;
//         count++;
//     }
//     for (int j = colP - 2; j >= 0; j--)
//     {
//         array[rowP - 1, j] = count;
//         count++;
//     }
//     for (int i = rowP - 2; i > 0; i--)
//     {
//         array[i, 0] = count;
//         count++;
//     }
//         // заполнение массива по спирали
//     int row = 1;
//     int col = 1;

//     while (count < rowP * colP)
//     {
//         while (array[row, col + 1] == 0)        // >> 6
//         {
//             array[row, col] = count;
//             count++;
//             col++;
//         }

//         while (array[row + 1, col] == 0)        // v 5
//         {
//             array[row, col] = count;
//             count++;
//             row++;
//         }

//         while (array[row, col - 1] == 0)        // << 4
//         {
//             array[row, col] = count;
//             count++;
//             col--;
//         }

//         while (array[row - 1, col] == 0)        // ^ 8
//         {
//             array[row, col] = count;
//             count++;
//             row--;
//         }
//     }
//         // Заменяем оставшийся 00 в центре крайним числом из последовтельности
//     for (int i = 0; i < rowP; i++)
//     {
//         for (int j = 0; j < colP; j++)
//         {
//             if (array[i, j] == 0)
//             {
//                 array[i, j] = count;
//             }
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
//             else Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int rowP = 4;
// int colP = 4;
// int count = 1;

// int[,] array = new int[rowP, colP];

// array = FillArraySpiral(rowP, colP, count, array);

// Show2DArray(array);