using System;
using System.Collections.Generic;

namespace CalendarHandler_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, string> dates = new Dictionary<DateTime, string>();
            while (true)
            {
                Console.WriteLine("Введите дату");
                var userInput = Console.ReadLine();
                try
                {
                    var afterParse = DateTime.Parse(userInput);
                    string value;
                    if (dates.TryGetValue(afterParse, out value))
                    {
                        Console.WriteLine($"На эту дату у вас запланировано: {value}");
                    }
                    else
                    {
                        Console.WriteLine("Введите новую запись");
                        string taskToAdd = Console.ReadLine();
                        dates.Add(afterParse, taskToAdd);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Возникло исключение {ex.Message}");
                }
            }
        }
    }
}