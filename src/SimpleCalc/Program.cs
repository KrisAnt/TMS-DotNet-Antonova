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
            Console.WriteLine("Введите первое число");
            var userInput = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            var userInput2 = Console.ReadLine();
            var result = Convert.ToDouble(userInput) + Convert.ToDouble(userInput2);
            Console.WriteLine("Сумма введеных вами чисел :" + " " + result);
        }

        static void Subtraction()
        {
            Console.WriteLine("Вычитание");
            Console.WriteLine("Введите первое число");
            var userInput = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            var userInput2 = Console.ReadLine();
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            var result = double.Parse(userInput, formatter) - double.Parse(userInput2, formatter);
            Console.WriteLine("Разность введеных вами чисел :" + " " + result);
        }
        static void Multiplication()
        {
            Console.WriteLine("Умножение");
            Console.WriteLine("Введите первое число");
            var userInput = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            var userInput2 = Console.ReadLine();
            var result1 = double.TryParse(userInput, out double number);
            var result2 = double.TryParse(userInput2, out double number2);
            Console.WriteLine("Произведение введеных вами чисел:" + number * number2);
        }
    }

}
