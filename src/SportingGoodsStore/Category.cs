using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public abstract class Category
    {
        protected List<Good> goods = new List<Good>();
        public abstract void View();
        public void DisplayAllGoods()
        {
            foreach (var allGoods in goods)
            {
                Console.WriteLine(allGoods);
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }

}