//Задача 1. Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
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

// void FindSum (int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }

//     Console.WriteLine ($"Sum of positive digits is -> {sumPos}, Sum of negative digits is -> {sumNeg}");
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray (myArray);

// FindSum (myArray);

//Задача 2. Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, 
//и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

//начало в первой задаче
// int[] ChangeElementsOfArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// myArray = ChangeElementsOfArray (myArray);
// ShowArray(myArray);

//Задача 3.Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
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

// bool Check(int[] array, int number)
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i] == number) return true;
//     }
//     return false;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input number to find:");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue,maxValue);
// ShowArray(array);
// Console.WriteLine(Check(array, number));

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

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

int Check(int[] array, int range_min, int range_max)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= range_min && array[i] <= range_max) sum++;
    }
    return sum;
}


Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal range:");
int range_min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal range:");
int range_max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"The amount of numbers is {Check(array, range_min, range_max)}");


//обновленный вариант
// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// int Check(int[] array, int range_min, int range_max)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= range_min && array[i] <= range_max) sum++;
//     }
//     return sum;
// }


// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal range:");
// int range_min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal range:");
// int range_max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"The amount of numbers is {Check(array, range_min, range_max)}");


//дз
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76