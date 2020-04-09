using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public class SportsWear : Category
    {
        public void AddNewSportSuit()
        {
            Console.WriteLine("Введите название товара");
            var nameOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            var priceOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            var quantityOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите цвет товара");
            var colorOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите размер товара");
            var sizeOfTheGood = Console.ReadLine();
            var good = new SportSuit
            {

                Description = nameOfTheGood,
                Price = priceOfTheGood,
                Color = colorOfTheGood,
                Count = quantityOfTheGood,
                Size = sizeOfTheGood
            };
            goods.Add(good);
        }
        public void RemoveSportSuit()
        {
            Console.WriteLine("Вы действительно хотите удалить этот товар из списка?");
            var yesNo = Console.ReadKey();
            if (yesNo.Key == ConsoleKey.Y)
            {
                goods.RemoveAll(good => good is SportSuit);
            }
        }
        public override void View()
        {
            string userAnswer;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите действие");
                Console.WriteLine(" 1. Добавить спортивный костюм");
                Console.WriteLine(" 2. Удалить спортивный костюм");
                Console.WriteLine(" 3. Просмотреть все существующие товары");
                userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "1":
                        {
                            AddNewSportSuit();
                            break;
                        }
                    case "2":
                        {
                            RemoveSportSuit();
                            break;
                        }
                    case "3":
                        {
                            DisplayAllGoods();
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    case "0":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильный ввод");
                            break;
                        }
                }
            } while (userAnswer != "0");
        }
    }
}
