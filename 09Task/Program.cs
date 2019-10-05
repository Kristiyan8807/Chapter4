//Напишете програма, която прочита едно цяло число n от конзолата.
//След това прочита още n на брой числа от конзолата и отпечатва
//тяхната сума.
using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.Write("Enter numbers count: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: " + sum);

    }
}
