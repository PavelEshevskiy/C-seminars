//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int OutputNum(string s)
{
    int[] Array = new int[s.Length];
    //string s = (int) char [] array = s.ToCharArray();
    // string s = char[] array = new char [s.Length];
    // for(int i = 0; i < s.Length; i++)
    // {
    // array[i] = s[i];
    // }
    return Array;
}

void ShowArray(int [] Array)
{
    Console.Write($"Получившийся массив -> ");

    for(int i = 0;i < array.Length;i++ )
    {
        Array[i] = Convert.ToInt32(s[i]);
        Console.Write (array[i]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите numbers");
string s = Console.ReadLine();

OutputNum(s);
Console.WriteLine();
ShowArray(Array);


// int [] CreateRandomArray(int size, int minValue,int maxValue)  //min нижнее ограничение max верхнее ограничение
// {
// int [] newArray = new int [size]; //тип массива int, выделяем память под тип int size штук 

//     for(int i=0;i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int [] array)
// {
//     Console.Write($"Получившийся массив -> ");

//     for(int i = 0;i < array.Length;i++ )
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int [] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array [i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// myArray = ReverseArray(myArray);
// ShowArray(myArray);

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)