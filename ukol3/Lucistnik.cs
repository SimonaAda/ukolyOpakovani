using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol3
{
    internal class Lucistnik
    {
        public int PocetSipu;

        public void Vystrel()
        {
            
            PocetSipu--;
            if (PocetSipu == 0)
            {
                Console.WriteLine("Nemám šípy.");
            }
            else
            {
                Console.WriteLine("Vždy se trefím přímo do středu.");
            }

        }
    }
}
