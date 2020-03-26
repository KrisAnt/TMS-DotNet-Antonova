using System;

namespace CalendarHandler
{
    class Program
    {
        const string M = "Mon";
        const string T = "Tue";
        const string W = "Wed";
        const string Th = "Thu";
        const string F = "Fri";
        const string S = "Sat";
        const string Sn = "Sun";
        enum Days
        {
            Monday = 0,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            var dayOfTheWeek = new string[7];
            while (true)
            {
                Console.Write("Введите день недели. Допустимый формат: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Mon, Monday");
                Console.ForegroundColor = ConsoleColor.White;
                var userInput = Console.ReadLine();
                Days day = GetDay(userInput);
                if (dayOfTheWeek[(int)day] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Введите новую запись");
                    Console.ForegroundColor = ConsoleColor.White;
                    dayOfTheWeek[(int)day] = Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(dayOfTheWeek[(int)day]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static Days GetDay(string userInput)
        {
            Days result;
            if (userInput.Contains(M))
            {
                result = Days.Monday;
            }
            else if (userInput.Contains(T))
            {
                result = Days.Tuesday;
            }
            else if (userInput.Contains(W))
            {
                result = Days.Wednesday;
            }
            else if (userInput.Contains(Th))
            {
                result = Days.Thursday;
            }
            else if (userInput.Contains(F))
            {
                result = Days.Friday;
            }
            else if (userInput.Contains(S))
            {
                result = Days.Saturday;
            }
            else if (userInput.Contains(Sn))
            {
                result = Days.Sunday;
            }
            else
            {
                result = Days.Monday;
            }
            return result;
        }
    }
}
