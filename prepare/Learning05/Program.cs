using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Fraction fraction1 = new Fraction(3, 4);
        Console.WriteLine(fraction1.GetFractionString());
    }
}