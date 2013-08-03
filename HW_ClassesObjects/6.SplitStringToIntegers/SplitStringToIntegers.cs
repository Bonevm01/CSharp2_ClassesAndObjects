//6.You are given a sequence of positive integer values written into a string, separated by spaces.
//  Write a function that reads these values from given string and calculates their sum.
//  Example: string = "43 68 9 23 318"  result = 461

using System;

class SplitStringToIntegers
{
    static void Main()
    {
        Console.Write("Please enter some integers separated by space:");
        string input = Console.ReadLine();
        Console.WriteLine("The sum of the integers parts of your string is {0}.", CalcSumInAString(input));

    }
    static int CalcSumInAString(string str)
    {
        int sum = 0;
        
        string[] numbers = str.Split(' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            sum += num;
        }

        return sum;
    }
}
