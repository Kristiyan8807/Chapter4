//Напишете програма, която чете пет числа от конзолата и отпечатва
//най-голямото от тях.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишете пет числа: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());
        if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
        {
            Console.WriteLine("Най-голямото число е : " + number1);

        }
        else if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
        {

            Console.WriteLine("Най-голямото число е : " + number2);
        }
        else if (number3 > number1 && number3 > number2 && number3 > number4 && number2 > number5)
        {

            Console.WriteLine("Най-голямото число е : " + number3);
        }
        else if (number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
        {

            Console.WriteLine("Най-голямото число е : " + number4);
        }
        else
        {
            Console.WriteLine("Най-голямото число е : " + number5);
        }
        
    }
}
