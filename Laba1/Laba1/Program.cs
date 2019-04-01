using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Vladik = new Product();
            Vladik.inputInfo();
            Vladik.Info();

            Console.WriteLine("\nНажмите любую клавишу для выхода из программы");
            Console.ReadKey();
        }
    }
}
