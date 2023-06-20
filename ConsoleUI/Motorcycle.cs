using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract method in motorcycle class");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This is my virtual method in motorcycle class");
        }

    }
}
