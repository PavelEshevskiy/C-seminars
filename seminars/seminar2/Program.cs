//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//78 -> 8

//12-> 2

//85 -> 8
//int BiggestDigit (int num)
//{
    //int ed = num % 10;
    //int dec = num / 10;

    //if(dec>ed) return dec;
   // else return ed;

//}

//int randomnum = new Random().Next(10, 100);

//int result = BiggestDigit(randomnum);
//Console.WriteLine($"Biggest digit of {randomnum} -> {result}");

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98
//int DeleteDigit(int num)
//{
    //int sot = num / 100;
    //int ed = num % 10;
    //return sot * 10 + ed;
//}

//int randomnum = new Random().Next(100, 1000);

//Console.WriteLine(randomnum);

//Console.WriteLine(DeleteDigit(randomnum));
//задача 1
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да
//bool Number7_23(int num)
//{
   //if(num % 7 == 0 && num % 23 == 0)
   //return true;
   //else return false;
//}

//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Number multipl 7 and 23 ? {Number7_23(num)}");
//задача 2
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool MultiplNumbers(double num1, double num2)
{
    //if(num1 / num2 == num2 || num2 / num1 == num1)
    //return true;
    //else return false; можно так
    return (num1 / num2 == num2 || num2 / num1 == num1); //а можно так
} 

//double firstRandom = new Random().Next(1, 100);
//Console.WriteLine(firstRandom);
//double secondRandom = new Random().Next(1, 100);
//Console.WriteLine(secondRandom);
//Console.WriteLine(MultiplNumbers(firstRandom, secondRandom));

Console.WriteLine("Input first number");
double num1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input second number");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultiplNumbers(num1, num2));