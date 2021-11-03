using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            const int n = 5;
            string jsonString = "";
            Goods[] array = new Goods[n];
            for (int i = 0; i < n; i++)
            {
                Goods newGoods = new Goods();
                newGoods.readParam();
                array[i] = newGoods;
            }
            for (int i = 0; i < n; i++)
            {
                jsonString = jsonString + JsonSerializer.Serialize(array[i]);
            }
            FileInfo fi = new FileInfo("Products.json");
            fi.Create();
            StreamWriter sw = new StreamWriter("Products.json", false);
            sw.WriteLine(jsonString);
        }
    }
}
class Goods
{
    public int Code { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public void readParam()
    {
        Console.WriteLine("Введите параметры товара");
        Console.Write("Код: ");
        int code = Convert.ToInt32(Console.ReadLine());
        Code = code;
        Console.Write("Наименование: ");
        string name = Convert.ToString(Console.ReadLine());
        Name = name;
        Console.Write("Цена: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Price = price;
    }
}

