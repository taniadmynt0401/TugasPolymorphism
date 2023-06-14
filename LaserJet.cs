using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("LaserJet display dimension : 12*45");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printng..");
        }
    }
}