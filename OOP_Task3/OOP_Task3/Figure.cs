using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task3
{
    abstract class Figure
    {

        public abstract void Move(int aX, int aY, int bX, int bY, int cX, int cY);

        public abstract double GetAria();

        public abstract double GetPerimetr();
    }
}
