//Напишете програма, която чете пет числа и отпечатва тяхната сума.
//При невалидно въведено число да се подкани потребителя да въведе
//друго число.
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
        int sum = number1 + number2 + number3 + number4 + number5;
        
    }

}

