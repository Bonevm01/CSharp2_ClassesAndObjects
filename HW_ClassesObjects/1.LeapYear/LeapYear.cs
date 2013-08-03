//1.Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        DateTime endFeb = new DateTime(year, 2, 28);
        endFeb = endFeb.AddDays(1);
        if (endFeb.Day==29)
        {
            Console.WriteLine("{0} is leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year.", year);
        }
    }
}
