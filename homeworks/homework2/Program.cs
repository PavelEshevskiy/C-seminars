//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//int SecondDigit(int num)
//{
   // return num % 100 / 10;
//}

//Console.WriteLine("Input three-digit number");
//int num = Convert.ToInt32(Console.ReadLine());

//if( num > 99 && num <= 999)
//{
    //Console.WriteLine(SecondDigit(num));
//}
//else 
//{
    //Console.WriteLine("is not three-digit number");
//}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdDigit( int num)
{
    while( num > 999 )
    {
        num /= 10;
    }
    return num % 10;
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if( num < 100 )
{
    Console.WriteLine("No third digit");
}
else
{
    Console.WriteLine(ThirdDigit(num));
}


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
