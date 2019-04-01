using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Product
    {
        string Name { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }

        public Product()
        {
            Name = "";
            Quantity = 0;
            Price = 0;
        }

        //echo 3 parametrs
        public void Info()
        {
            Console.WriteLine("Артибуты товара");
            Console.WriteLine($"Название товара {Name}");
            Console.WriteLine($"Название товара {Quantity}");
            Console.WriteLine($"Название товара {Price}");
        }
        
        public void getInfo(string name, int quantity, double price)
        {
            Console.WriteLine("Введите наименование товара");
            Name = Console.ReadLine();
            Console.WriteLine("Введите количество товара");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену товара");
            Price = Convert.ToDouble(Console.ReadLine());
        }


    }
}
