//Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт
//и мениджър.Мениджърът има име, фамилия и телефонен номер.
//Напишете програма, която чете информацията за фирмата и ней-
//ния мениджър и я отпечатва след това на конзолата.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля попълнете данни за фирмата: име, адрес, телефонен номер, факс номер, уеб сайт и мениджър");
        Console.Write("Име: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Адрес: ");
        string address = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Телефонен номер: ");
        string phone = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Факс: ");
        string fax = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Уеб сайт: ");
        string webSite = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Мениджър: ");
        string manager = Console.ReadLine();
        Console.WriteLine();

    }
}
