using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task3
{
    class Pyramid:Triangle
    {
        private int high;

        public Pyramid(Dot a, Dot b, Dot c, int high):base(a, b, c)
        {
            this.high = high;
        }

        public Pyramid(int aX, int aY, int bX, int bY, int cX, int cY, int high):base(aX, aY, bX, bY, cX, cY)
        {
            this.high = high;
        }

        public override double GetAria()
        {
            return GetPerimetr() / 2 + high;
        }

        public override string ToString()
        {
            return base.ToString() + " ; high = " + high;
        }
    }
}
