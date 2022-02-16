using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraiGITfeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Random random = new Random();
            int dobaszam = random.Next(6)+1;
            Console.WriteLine(dobaszam);
            Console.ReadKey();
        }
    }
}
