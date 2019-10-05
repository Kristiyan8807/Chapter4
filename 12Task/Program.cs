//Напишете програма, която пресмята сумата(с точност до 0.001): 1+
//1/2 + 1/3 + 1/4 + 1/5 + ...
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        float sum = 0f;
        for (int i = 1; i <= number; i++)
        {
            sum += 1.0f / i;
        }
        Console.WriteLine(sum);

    }
}

