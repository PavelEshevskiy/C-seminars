// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// int EvenNum(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if( array[i] % 2 == 0) sum++;
//     }
//     return sum;
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Number of even numbers: {EvenNum(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine ();
}

int SumOddPos (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0) sum += array[i];
    }
    return sum;
}


Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray (size, minValue, maxValue);
ShowArray (array);

Console.WriteLine();
Console.WriteLine($"Sum of odd positions: {SumOddPos(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     double[] newArray = new double[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//         newArray[i] = Math.Round((newArray[i] + new Random().NextDouble()), 2);
//     }
//     return newArray;
// }

// void ShowArray (double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// void Difference(double[] array)
// {
//     double iMin = 0;
//     double iMax = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > iMax) iMax = array[i];
//         if(array[i] < iMin) iMin = array[i];
//     }

//     Console.WriteLine ($"Difference between {iMax} & {iMin} -> {iMax - iMin}");
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);

// Difference (myArray);
