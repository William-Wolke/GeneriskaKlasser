using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();
            Queue<string> lootedProducts = new Queue<string>();
            List<int> checkoutPrice = new List<int>();

            goods.Add("popcorn", 20);
            goods.Add("banana", 10);
            goods.Add("keso", 25);
            goods.Add("vegan bratwurst", 30);
            goods.Add("taco sauce", 35);
            goods.Add("frozen shrimp", 50);
            goods.Add("sambal oelek", 25);
            goods.Add("billys pizza", 15);
            goods.Add("gorbys pirog", 15);
            goods.Add("grill spice", 40);
            goods.Add("basmati rice", 50);
            goods.Add("caramel sauce", 15);

            goods.Remove("gorbys pirog");

            lootedProducts.Enqueue("popcorn");
            lootedProducts.Enqueue("vegan bratwurst");
            lootedProducts.Enqueue("sambal oelek");
            lootedProducts.Enqueue("caramel sauce");

            System.Console.WriteLine("Number of items in cart " + lootedProducts.Count);

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine(lootedProducts.Peek());
                checkoutPrice.Add(goods[lootedProducts.Dequeue()]);
                System.Console.WriteLine("Item price " + checkoutPrice[i]);
                System.Console.WriteLine("Item " + (i+1) + " of " + 4); 
            }

            System.Console.WriteLine("popcorn price: " + goods["popcorn"]);
            System.Console.ReadLine();
        }
    }
}
