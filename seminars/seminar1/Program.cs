//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine()); 
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine()); 

//if( num2 * num2 == num1)
//{
  //  Console.WriteLine($"First number {num1} is quad of second number {num2}");
//}
//else
//{
   // Console.WriteLine($"First number {num1} is not quad of second number {num2}");
//}

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine()); 

int current = n * (-1);
while(current <= n)
{
    Console.Write(current + " ");
    current++;
}