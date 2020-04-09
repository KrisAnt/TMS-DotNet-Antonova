using System;
using System.Collections.Generic;
using System.Text;

namespace SportingGoodsStore
{
    public class FitnessGoods : Category
    {
        public void AddNewDumbbell()
        {
            Console.WriteLine("Введите название товара");
            var nameOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            var priceOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            var quantityOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите вес товара");
            var weightOfTheGood = Console.ReadLine();
            var good = new Dumbbell
            {
                Description = nameOfTheGood,
                Price = priceOfTheGood,
                Weight = weightOfTheGood,
                Count = quantityOfTheGood
            };
            goods.Add(good);
        }
        public void AddNewFitnessMat()
        {
            Console.WriteLine("Введите название товара");
            var nameOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            var priceOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            var quantityOfTheGood = Console.ReadLine();
            Console.WriteLine("Введите цвет товара");
            var colorOfTheGood = Console.ReadLine();
            var good = new FitnessMat
            {
                Description = nameOfTheGood,
                Price = priceOfTheGood,
                Color = colorOfTheGood,
                Count = quantityOfTheGood
            };
            goods.Add(good);
        }
        public void RemoveDumbbell()
        {
            Console.WriteLine("Вы действительно хотите удалить этот товар из списка?");
            var yesNo = Console.ReadKey();
            if (yesNo.Key == ConsoleKey.Y)
            {
                goods.RemoveAll(good => good is Dumbbell);
            }
        }
        public void RemoveFitnessMat()
        {
            Console.WriteLine("Вы действительно хотите удалить этот товар из списка?");
            var yesNo = Console.ReadKey();
            if (yesNo.Key == ConsoleKey.Y)
            {
                goods.RemoveAll(good => good is FitnessMat);
            }
        }
        public override void View()
        {
            string userAnswer;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите действие");
                Console.WriteLine(" 1. Добавить гантелю");
                Console.WriteLine(" 2. Удалить гантелю из списка");
                Console.WriteLine(" 3. Добавить коврик для фитнеса");
                Console.WriteLine(" 4. Удалить коврик для фитнеса");
                Console.WriteLine(" 5. Просмотреть все существующие товары");
                userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "1":
                        {
                            AddNewDumbbell();
                            break;
                        }
                    case "2":
                        {
                            RemoveDumbbell();
                            break;
                        }
                    case "3":
                        {
                            AddNewFitnessMat();
                            break;
                        }
                    case "4":
                        {
                            RemoveFitnessMat();
                            break;
                        }
                    case "5":
                        {
                            DisplayAllGoods();
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
