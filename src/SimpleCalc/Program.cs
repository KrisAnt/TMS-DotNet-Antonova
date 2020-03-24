using System;
using System.Globalization;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в SimpleCalc");
            Sum();
            Subtraction();
            Multiplication();
        }
        static void Sum()
        {
            Console.WriteLine("Сложение");
            var userInput = ConvertMethod("первое");
            var userInput2 = ConvertMethod("второе");
            var result = userInput + userInput2;
            Console.WriteLine("Сумма введеных вами чисел :" + " " + result);
        }

        static double ConvertMethod(string index)
        {
            Console.WriteLine($"Введите {index} число");
            var userInput = Console.ReadLine();
            return Convert.ToDouble(userInput);
        }

        static void Subtraction()
        {
            Console.WriteLine("Вычитание");
            var userInput = ParseMethod("первое");
            var userInput2 = ParseMethod("второе");
            var result = userInput - userInput2;
            Console.WriteLine("Разность введеных вами чисел :" + " " + result);
        }

        static double ParseMethod(string index)
        {
            Console.WriteLine($"Введите {index} число");
            var userInput = Console.ReadLine();
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            return double.Parse(userInput, formatter);
        }

        static void Multiplication()
        {
            Console.WriteLine("Умножение");
            var userInput = TryParseMethod("первое");
            var userInput2 = TryParseMethod("второе");
            var result = userInput * userInput2;
            Console.WriteLine("Произведение введеных вами чисел:" + result);
        }

        static double TryParseMethod(string index)
        {
            Console.WriteLine($"Введите {index} число");
            var userInput = Console.ReadLine();
            double.TryParse(userInput, out double number);
            return number;
        }
    }

}
