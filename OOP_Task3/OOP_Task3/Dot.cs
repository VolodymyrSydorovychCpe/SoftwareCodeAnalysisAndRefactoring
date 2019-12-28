using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task3
{
    class Dot
    {
        private int x;
        public int Xcoordinate
        {
            get
            {
                return x;
            }
        }

        private int y;
        public int Ycoordinate
        {
            get
            {
                return y;
            }
        }

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override String ToString()
        {
            return base.ToString() + " - x:" + x + ", y:" + y;
        }
    }
}
