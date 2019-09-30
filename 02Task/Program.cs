//Напишете програма, която чете от конзолата радиуса "r" на кръг и
//отпечатва неговото лице и обиколка
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задайте радиус на кръга: ");
        int radius = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Лицето на кръга е: " + Math.PI * radius * radius);
        Console.WriteLine("Обиколката на кръга е: " + 2 * Math.PI * radius);

    }
}
