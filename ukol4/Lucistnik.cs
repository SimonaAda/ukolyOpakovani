using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol4
{
    internal class Lucistnik
    {
        public int PocetSipu;


        public void VystrelVsechnySipy()
        {
            PocetSipu = PocetSipu - 10;
            Console.WriteLine($"Počet šípu je {PocetSipu}.");
        }
    }
}
