﻿//2.Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static void Main()
    {
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            int value = rand.Next(100,201);
            Console.WriteLine(value);
        }
    }
}
