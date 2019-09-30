//Напишете програма, която чете от конзолата три числа от тип int и
//отпечатва тяхната сума.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numbers: ");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        int result = a + b + c;
        Console.WriteLine("Result is: " + result);

    }
}
