using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM_Management
{

    /// <summary>
    /// Класс Bank предоставляет функции для 
    /// совершения различных действий над лицевым счетом
    /// </summary>
    
    class Bank
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        private Account _currentAccount;
        List<Account> accountList;
        public Bank()
        {
            Initialization();
        }
      
        /// <summary>
        /// Метод Initialization предоставляет список 
        /// возможных паролей и аккаунт номеров
        /// </summary>
       
        public void Initialization()
        {
            accountList = new List<Account>
            {
                new Account() { Balance = 700, AccountNumber = 8745476, PinCode = "4411"},
                new Account() { Balance = 200, AccountNumber = 1234566, PinCode = "1213"},
                new Account() { Balance = 1700, AccountNumber = 9476788, PinCode = "5533"}
             };
        }

        public bool CheckPassword(string userInput)
        {
            _currentAccount = accountList.FirstOrDefault(x => x.PinCode.Equals(userInput, StringComparison.InvariantCultureIgnoreCase));
            return _currentAccount != null;
        }
        public void CheckBalance()
        {
            var balance = _currentAccount.Balance;
            Console.WriteLine($"Your balance is {balance} rubles");
        }
        public void Withdrawal()
        {
            var balance = _currentAccount.Balance;
            Console.WriteLine("Please, enter the sum");
            string answer = Console.ReadLine();
            if (balance >= Convert.ToInt32(answer))
            {
                _currentAccount.Balance -= Convert.ToInt32(answer);
                Notify?.Invoke($"Withdrawls from the account: {answer}");
            }
            else
            {
                Notify?.Invoke($"Withdrawal NOT possible, lNSUFFlClENT FUNDS Current balance: {balance}");
            }
        }
       
        /// <summary>
        /// Метод AnotherAction реализовывает функции для 
        /// совершения дополнительных операций над лицевым счетом
        /// </summary>
     
        public void AnotherAction()
        {
            string user;
            ATMScreen atm = new ATMScreen();
            atm.DisplayAnotherOperations();
            do
            {

                user = Console.ReadLine();
                switch (user)
                {
                    case "1":
                        {
                            PayTheBills();
                            break;
                        }
                    case "2":
                        {
                            Transfer();
                            break;
                        }
                    case "3":
                        {
                            atm.DisplayMenu();
                            break;
                        }
                }
            } while (user != "3");
        }
        public void PayTheBills()
        {
            Console.WriteLine("Please enter the sum and the operation");
            var answerUser = Console.ReadLine();
            string operation = Console.ReadLine();
            var balance = _currentAccount.Balance;
            if (balance >= Convert.ToInt32(answerUser))
            {
                _currentAccount.Balance -= Convert.ToInt32(answerUser);
                Notify?.Invoke($"Withdrawls from the account: {answerUser}");
            }
            else
            {
                Notify?.Invoke($"Withdrawal NOT possible, lNSUFFlClENT FUNDS Current balance: {balance}");
            }
        }
        public void Transfer()
        {
            Console.WriteLine("Please, enter the card number");
            Console.WriteLine("Please, enter the sum to transfer");
            var cardNumber = Convert.ToInt32(Console.ReadLine());
            var sumToTransfer = Convert.ToInt32(Console.ReadLine());
            var balance = _currentAccount.Balance;
            if (balance >= sumToTransfer)
            {
                _currentAccount.Balance -= sumToTransfer;
                Notify?.Invoke($"Withdrawls from the account: {sumToTransfer}");
            }
            else
            {
                Notify?.Invoke($"Transfer NOT possible, lNSUFFlClENT FUNDS Current balance: {balance}");
            }
        }

   
    }
}
