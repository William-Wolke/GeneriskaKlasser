using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();

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

            System.Console.WriteLine("popcorn pris: " + goods["popcorn"]);
        }
    }
}
