//Напишете програма, която чете две числа от конзолата и отпечатва
//по-голямото от тях.Решете задачата без да използвате условни
//конструкции.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишете две числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("По-голямото число е: ");
        Console.WriteLine(Math.Max(number1, number2));
        

    }

}
