//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine()); 
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine()); 

//if( num1 > num2 )
//{
    //Console.WriteLine($"First number {num1} is maximum, and second number {num2} is minimum");
//}
//else
//{
   // Console.WriteLine($"Second number {num2} is maximum, and first number {num1} is minimum");
//}

//Задача 2. Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine()); 
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine()); 
//Console.WriteLine("Input third number");
//int num3 = Convert.ToInt32(Console.ReadLine()); 

//if( num1 > num2 && num1 > num3 )
//{ 
    //Console.WriteLine($"First number {num1} is maximum");
//}
//if( num2 > num1 && num2 > num3 )
//{
    //Console.WriteLine($"Second number {num2} is maximum");
//}
//if( num3 > num1 && num3 > num2 )
//{ 
    //Console.WriteLine($"Third number {num3} is maximum"); 
//}

//Задача 3. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//Console.WriteLine("Input number");
//int num = Convert.ToInt32(Console.ReadLine());

//if( num % 2 == 0 )
//{ 
    //Console.WriteLine($"Your number {num} is even");
//}
//else
//{
    //Console.WriteLine($"Your number {num} is odd");
//}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine()); 

int current = 1;
while(current <= n)
{
    if( current % 2 == 0 )
    {
        Console.Write(current + " ");
    }
    
    current++;
}