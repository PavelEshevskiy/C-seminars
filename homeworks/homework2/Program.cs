//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int SecondDigit(int num)
{
    if( num > 99 && num <= 999)
    return num % 100 / 10;
    else 
    return Console.WriteLine("is not three-digit number");
}

Console.WriteLine("Input three-digit number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondDigit(num));


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
//недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//bool DaysWeek( int numDay )
//{
    //return ( numDay == 6 || numDay == 7);
//}

//Console.WriteLine("Input № day weeks");
//int numDay = Convert.ToInt32(Console.ReadLine());

//if( numDay <= 0 || numDay > 7 )
//{
    //Console.WriteLine("Is not day weeks");
//}
//else
//{
    //Console.WriteLine($"№ day weeks is weekend ? - {DaysWeek (numDay)}");
//}
