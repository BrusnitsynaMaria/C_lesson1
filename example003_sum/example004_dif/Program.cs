﻿internal class Program
{
    private static void Main(string[] args)
    {
        int numberA = new Random().Next(1, 10);
        Console.WriteLine(numberA);
        int numberB = new Random().Next(1, 10);
        Console.WriteLine(numberB);
        Console.WriteLine(numberA / numberB);
    }
}