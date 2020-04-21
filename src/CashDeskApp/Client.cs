using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CashDeskApp
{
   public class Client
    {
        public List<Product> Products { get; }

        public Client()
        {
            Products = new List<Product>();
        }

        public void AddNewGood(int time)
        {
            Product product = new Product(1000);
            Products.Add(product);
        }
    }
}
