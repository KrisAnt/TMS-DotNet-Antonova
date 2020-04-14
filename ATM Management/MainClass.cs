using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Management
{
    class MainClass
    {
        public void Run()
        {
            string input;
            Console.WriteLine("Welcome");
            Console.WriteLine("Insert your card, please");
            Console.ReadKey();
            Console.WriteLine("Please, enter your password");
            var userInput = Console.ReadLine();
            Bank bank = new Bank();
            bank.Notify += (string s) => { Console.WriteLine(s); };
            var isValid = bank.CheckPassword(userInput);
            if (isValid)
            {
                var atmScreen = new ATMScreen();
                atmScreen.DisplayMenu();
            }
            else
            {
                Console.WriteLine("Invalid PIN number");
            }
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            bank.CheckBalance();
                            break;
                        }
                    case "2":
                        {
                            bank.Withdrawal();
                            break;
                        }
                    case "3":
                        {
                            bank.AnotherAction();
                            break;
                        }
                }
            } while (input != "4");
        }
    }
}
