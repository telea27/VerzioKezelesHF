using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int db;
            int szam;
            int atlag;
            int ossz=0;
            List<int> lista = new List<int>();
            Console.WriteLine("Hány db számot kér?");
            db = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                Console.WriteLine("Kérek egy számot");
                szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
                ossz += szam;
                atlag = ossz / 10;
            }
            while (lista.Count!=db);
            Console.WriteLine("Átlag: "+atlag);

            Console.ReadKey();

        }
    }
}
