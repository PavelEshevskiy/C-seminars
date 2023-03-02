//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

bool Palindrome(int num)
{
    int tenThou = num / 10000 ;
    int thou = num % 10000 / 1000;
    int dec = num % 100 / 10;
    int ed = num % 100 % 10;
    return (tenThou == ed && thou == dec);
}

Console.WriteLine("Input five-digit number");
int num = Convert.ToInt32(Console.ReadLine());

if( num > 9999 && num <= 99999)
{
    Console.WriteLine(Palindrome(num));
}
else 
{
    Console.WriteLine("is not five-digit number");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
//{
//    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
//}

//Console.WriteLine("Input coordinate X of A point: ");
//double x1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of A point: ");
//double y1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Z of A point: ");
//double z1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate X of B point: ");
//double x2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of B point: ");
//double y2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Z of B point: ");
//double z2 = Convert.ToDouble(Console.ReadLine());

//double distance = FindDistance(x1, y1, z1, x2, y2, z2);
//Console.WriteLine($"Distance between A and B is {distance}");

//Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//void TableCubes(double N)
//{
//    double i = 1;
 //   while(i <= N)
//    {
//        Console.WriteLine($"{i} -> {i}^3 -> {Math.Pow(i, 3)}");
//        i++;
//    }
//}
//Console.WriteLine("Input the number N:");
//double N = Convert.ToDouble(Console.ReadLine());
//TableCubes(N);