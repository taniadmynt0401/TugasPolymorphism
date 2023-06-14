using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void show()
        {
            Console.WriteLine("Nomor Printer Window [1..3]");
        }
        public virtual void Print()
        {
            Console.WriteLine("Nomor Printer Windows [1..3]");
        }
    }
}
