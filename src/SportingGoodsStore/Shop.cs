using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public class Shop
    {
        List<Category> categories = new List<Category>();
        public Shop()
        {
            FitnessGoods fitnessGoods = new FitnessGoods();
            categories.Add(fitnessGoods);
            SportsWear sportsWear = new SportsWear();
            categories.Add(sportsWear);
        }
        public void Run()
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите категорию");
                Console.WriteLine(" 1. FitnessGoods");
                Console.WriteLine(" 2. SportsWear");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            categories[0].View();
                            break;
                        }
                    case "2":
                        {
                            categories[1].View();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильный ввод");
                            break;
                        }
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }

    }
}
