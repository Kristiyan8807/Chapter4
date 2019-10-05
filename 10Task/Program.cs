//Напишете програма, която прочита цяло число n от конзолата и отпе-
//чатва на конзолата всички числа в интервала[1…n], всяко на
//отделен ред.
using System;
class Program
{
    static void Main()
    {
        Console.Write("Напишете число: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i < number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
