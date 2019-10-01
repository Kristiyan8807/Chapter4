//Напишете програма, която чете от конзолата две цели числа(int) и
//отпечатва колко числа има между тях, такива, че остатъкът им от де-
//ленето на 5 да е 0. Пример: в интервала(14, 25) има 3 такива числа:
//15, 20 и 25.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишете две числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        for (int i = number1; i <= number2; i++)
        {
            if (i % 5 == 0)
                Console.WriteLine(i);
        }

    }
}
