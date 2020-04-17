using System;
using System.Collections.Generic;

namespace CashDeskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var locker = new object();
            Queue<Client> clients = new Queue<Client>();
            Random r = new Random();
            var countOfClients = r.Next(10, 20);
            for (int i = 0; i < countOfClients; i++)
            {
                AddClient(clients);
            }
            var cash = new Cash("касса № 1", locker);
            cash.Start(clients);
            var cash2 = new Cash("касса № 2", locker);
            cash2.Start(clients);
            var cash3 = new Cash("касса № 3", locker);
            cash3.Start(clients);
        }

        /// <summary>
        /// В методе AddClient рандомно создаются клиенты с рандомным количеством товаров
        /// </summary>
        /// <param name="clients"></param>
       
        private static void AddClient(Queue<Client> clients)
        {
            Client client1 = new Client();
            Random r = new Random();
            var countOfProducts = r.Next(1, 10);
            for (int i = 0; i < countOfProducts; i++)
            {
                client1.AddNewGood(r.Next(500,4000));
            }
            clients.Enqueue(client1);
        }
    }
}
