using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //ovning 1
            Console.WriteLine("");
            string inmatat = Console.ReadLine();
            double x = double.Parse(inmatat);

            if (x < 1.6)
            {
                Console.WriteLine("olaglig däck!");
            }
            else
            {
                Console.WriteLine("Lagligt däck!");
            }
            Console.ReadLine();

            //ovning 2
            Console.WriteLine("");
            string inmatat2 = Console.ReadLine();
            int y = int.Parse(inmatat);

            if (y <= 12) 
            {
                Console.WriteLine("vit");
            }
            else if(y <= 18 && y > 12)
            {
                Console.WriteLine("grön");
            }
            else if(y <= 25 && y > 18)
            {
                Console.WriteLine("red");
            }
            else if(y <= 99 && y > 25)
            {
                Console.WriteLine("blå");
            }
            else

            {
                Console.WriteLine("Ogiltlig ålder");
            }

            //ovning 3
            Console.WriteLine("Mata in tal 1");
            string inmatat3 = Console.ReadLine();
            Console.WriteLine("Mata in tal 2");
            string inmatat4 = Console.ReadLine();
            int z = int.Parse(inmatat3);
            int b = int.Parse(inmatat4);

            if (z > b)
            {
                Console.WriteLine(" tal 1 var störst ");
            }
            else if (z == b)
            {
                Console.WriteLine(" tal 1 och 2 var lika stora");
            }
            else
            {
                Console.WriteLine(" tal 2 var störst");
            }

            //ovning 4
            Console.WriteLine("Mata in ett tal");
            string inmatat5 = Console.ReadLine();
            int p = int.Parse(q);

            q = q % 7;

            if (q == 0)
            {
                Console.WriteLine(" Talet är jämt med 7");
                    }
            else
            {
                Console.WriteLine("Talen är ej jämt med 7 resten är:"  + q);
                    }


        }
    }
}
