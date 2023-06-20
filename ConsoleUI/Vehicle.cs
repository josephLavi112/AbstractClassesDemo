﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2023";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("this is my virtual method in vehicle class");
        }

    }
}
