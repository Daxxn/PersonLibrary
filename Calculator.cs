using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary
{
    partial class Calculator
    {
        public int One { get => 1; }
        public int Two { get => 2; }
        public int Three { get => 3; }
        public int Four { get => 4; }
        public int Five { get => 5; }
        public int Six { get => 6; }
        public int Seven { get => 7; }
        public int Eight { get => 8; }
        public int Nine { get => 9; }
        public int Ten { get => 10; }

        public Calculator() { }

        public double Add(int X, int Y)
        {
            return X + Y;
        }
    }
}
