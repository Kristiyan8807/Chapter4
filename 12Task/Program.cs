//Напишете програма, която пресмята сумата(с точност до 0.001): 1+
//1/2 + 1/3 + 1/4 + 1/5 + ...
using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine(1 / 1);
        //Console.WriteLine(1.0f / 2);
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        //float sum = 0f;
        //sum = 1.0f / 1 + 1.0f / 2 + 1.0f / 3 + 1.0f / 4 + 1.0f / 5 + 1.0f / 6 + 1.0f / 7 + 1.0f / 8 + 1.0f / 9 + 1.0f / 10;
        //Console.WriteLine(sum);

        float sum = 0f;
        for (int i = 1; i <= number; i++)
        {
            sum += 1.0f / i;
        }
        Console.WriteLine(sum);

    }
}

