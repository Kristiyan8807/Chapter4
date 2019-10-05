//Напишете програма, която отпечатва на конзолата първите 100 числа
//от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,
//233, 377, ...
using System;

class Program
{
    static void Main()
    {
        ulong prev1 = 0;
        ulong prev2 = 1;
        ulong current = 0;
        Console.WriteLine(prev1);
        Console.WriteLine(prev2);
        for (int i = 0; i < 100; i++)
        {
            current = prev1 + prev2;
            Console.WriteLine(current);
            prev1 = prev2;
            prev2 = current;
        }
    }
}
