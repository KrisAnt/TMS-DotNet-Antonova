using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Management
{
    class ATMScreen
    {
        /// <summary>
        /// Метод DisplayMenu отображает главное окно банкомата
        /// </summary>
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("|           ATM Management Menu                  |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|           1. Check Balance                     |");
            Console.WriteLine("|           2. Withdrawal                        |");
            Console.WriteLine("|           3. Another operation with the card   |");
            Console.WriteLine("|           4. Log out                           |");
        }
        
        /// <summary>
        /// Метод DisplayAnotherOperations отображает окно 
        /// для дополнительных операций со счетом
        /// </summary>
       
        public void DisplayAnotherOperations()
        {
            Console.Clear();
            Console.WriteLine("|           1. Pay the bills                     |");
            Console.WriteLine("|           2. Transfer funds to another card    |");
            Console.WriteLine("|           3. Back                              |");

        }
    }
}
