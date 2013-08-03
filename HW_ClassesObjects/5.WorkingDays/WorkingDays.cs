//5.Write a method that calculates the number of workdays between today and given date, passed as parameter.
//  Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class WorkingDays
{
    static void Main()
    {
        Console.WriteLine("The following program is going to calculate working days between today and\na random date in the past or in the future.Escluding both dates.");
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        DateTime input = new DateTime(year, month, day);

        Console.WriteLine("Working days between today and {0:d.M.yyyy} are {1}.", input, CalcWorkingDays(input));
    }

    private static int CalcWorkingDays(DateTime input)
    {
        DateTime now = DateTime.Now;
        DateTime startDate;
        DateTime endDate;
        if (now > input)
        {
            startDate = input.AddDays(1);//To exclude start date and to calculate only between start and end
            endDate = now;
        }
        else
        {
            startDate = now.AddDays(1);//To exclude start date and to calculate only between start and end
            endDate = input;
        }
        int workingDays = 0;
        do
        {
            if (!IsOfficiaHoliday(startDate) && startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                workingDays++;
            }

            startDate = startDate.AddDays(1);
        } while (startDate < endDate);//To exclude the end date and to calculate only between start and end
        return workingDays;
    }

    private static bool IsOfficiaHoliday(DateTime startDate)
    {
        int[,] holidays =
                        {
                        {1,3,5,5,9,9,12,12,12 },
                        {1,3,6,24,6,22,24,25,31}
                        };
        bool isOfficialHoliday = false;
        for (int i = 0; i < holidays.GetLength(1); i++)
        {
            if (startDate.Day == holidays[1, i] && startDate.Month == holidays[0, i])
            {
                isOfficialHoliday = true;
                break;
            }
        }
        return isOfficialHoliday;
    }
}

