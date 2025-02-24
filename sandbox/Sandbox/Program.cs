using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Bob's World!");
        Console.WriteLine("Input your name: ");

        // int name = Console.Read();
        string name = Console.ReadLine();

        Console.WriteLine($"{name}");

    }

}