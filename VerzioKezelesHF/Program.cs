using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int max;
            int min;
            List<int> lista = new List<int>();
            Console.WriteLine("Hány db számot kér?");
            db = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                Console.WriteLine("Kérek egy számot");
                szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
                ossz += szam;
                atlag = ossz / db;
            }
            while (lista.Count!=db);
            Console.WriteLine("Átlag: "+atlag);
            max = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
               
                if (max<lista[i])
                {
                    max = lista[i];
                }
            }
            Console.WriteLine("A legnagyobb elem: "+max);
            min = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {

                if (min> lista[i])
                {
                    min = lista[i];
                }
            }
            Console.WriteLine("A legkisebb elem: " + min);

            Console.ReadKey();

        }
    }
}
