using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 11*2.3");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printng..");
        }
    }
}
