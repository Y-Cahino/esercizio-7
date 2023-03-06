using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tot;
            Console.WriteLine("Inserire prezzo prodotto:");
            int x=int.Parse(Console.ReadLine());
            tot=x;
            Console.WriteLine("inserire n pezzi ordinati:");
            int y=int.Parse(Console.ReadLine());
            while(y!=0)
            {
                if(y<=3)
                {
                    x = (tot * 5) / 100;
                }
                else if (y <= 5)
                {
                    x = (tot * 5) / 100;
                }
                else if (y <= 10)
                {
                    x = (tot * 20) / 100;
                }
                else if (y > 10)
                {
                    x = (tot * 30) / 100;
                }
            }
            Console.WriteLine("Il prezzo scontato è di: " + x + "€");
        }
    }
}
