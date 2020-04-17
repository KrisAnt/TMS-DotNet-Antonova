using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace CashDeskApp
{
    public class Cash
    {
        Queue<Client> _queue;
        object _locker;
        Thread _cashThread;
        string _name;

        public Cash(string name, object locker)
        {
            _cashThread = new Thread(Run);
            _name = name;
            _locker = locker;
        }

        /// <summary>
        /// Метод Start запускает работу потоков
        /// </summary>
        /// <param name="queue"></param>
       
        public void Start(Queue<Client> queue)
        {
            _queue = queue;
            _cashThread.Start();
        }

        /// <summary>
        /// Метод Run включает в себя запуск работы касс и обработку клиентов
        /// </summary>
       
        void Run()
        {
            Console.WriteLine($"{_name} начала свою работу");
            while (true)
            {
                var client = GetClient();
                if (client == null)
                {
                    break;
                }
                Service(client);
            }
            Console.WriteLine($"{_name} закончила свою работу");
        }

        /// <summary>
        /// В методе GetClient рписана функция, выбирающая клиентов из очереди
        /// </summary>
        /// <returns></returns>
      
        Client GetClient()
        {
            lock (_locker)
            {
                Client client;
                try
                {
                    client = _queue.Dequeue();
                }
                catch (InvalidOperationException)
                {
                    client = null;
                }
                return client;
            }
        }
       
        /// <summary>
        /// Метод Service создан для обработки одного клиента и его продуктовую корзину
        /// </summary>
        /// <param name="client"></param>
       
        void Service(Client client)
        {
            Console.WriteLine($"{_name}: Обсулживается клиент с количеством " + client.Products.Count);
            foreach (var product in client.Products)
            {
                Thread.Sleep(product.Time);
            }
        }
    }
}
