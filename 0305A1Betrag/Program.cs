using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305A1Betrag
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal z, wert=0;

            Console.Write("Bitte eingeben Sie eine Zahl: ");
            if (decimal.TryParse(Console.ReadLine(), out z)){
                if (z < 0)
                    wert = -z;
                else if (z == 0)
                    wert = 0;
                else
                    wert = z;
                Console.WriteLine("Der Betrag von |{0}| ist {1}", z, wert);
            }
        }
    }
}
