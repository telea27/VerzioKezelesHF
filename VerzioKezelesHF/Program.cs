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
            int szam;
            List<int> lista = new List<int>();
            do
            {
                Console.WriteLine("Kérek egy számot");
                szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
            }
            while (lista.Count!=10);
            foreach (var item in lista)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();

        }
    }
}
