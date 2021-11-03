using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            //string nGood = JsonSerializer.Serialize(sr.ReadLine());
            //Console.WriteLine(nGood);
            Goods[] texGoods = new Goods[5];
            StreamReader sr = new StreamReader("Products.json");
            for (int i = 0; i < 5; i++)
            {
                string txt = sr.ReadLine();
                Goods newGoods = JsonSerializer.Deserialize<Goods>(txt);
                texGoods[i] = newGoods;
            }
            sr.Close();
            Console.ReadKey();
        }


        class Goods
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

        }
    }
}