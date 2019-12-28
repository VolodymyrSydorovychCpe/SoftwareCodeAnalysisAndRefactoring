using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task3
{
    class Triangle : Figure
    {
        private Dot highA;
        private Dot highB;
        private Dot highC;

        public Triangle(Dot a, Dot b, Dot c)
        {
            this.highA = a;
            this.highB = b;
            this.highC = c;
        }
        
        public Triangle(int aX, int aY, int bX, int bY, int cX, int cY)
        {
            this.highA = new Dot(aX, aY);
            this.highB = new Dot(bX, bY);
            this.highC = new Dot(cX, cY);
        }

        public override void Move(int aX, int aY, int bX, int bY, int cX, int cY)
        {
            this.highA = new Dot(aX, aY);
            this.highB = new Dot(bX, bY);
            this.highC = new Dot(cX, cY);
        }

        public override double GetAria()
        {
            return Math.Abs((highA.Xcoordinate - highC.Xcoordinate) *
                (highB.Ycoordinate - highC.Ycoordinate) -
                (highB.Xcoordinate - highC.Xcoordinate) *
                (highA.Ycoordinate - highC.Ycoordinate) / 2);
        }

        public override double GetPerimetr()
        {
            double abDistance = Math.Sqrt((highB.Xcoordinate - highA.Xcoordinate) ^ 2
                + (highB.Ycoordinate - highA.Ycoordinate) ^ 2);
            double bcDistance = Math.Sqrt((highC.Xcoordinate - highB.Xcoordinate) ^ 2
                + (highC.Ycoordinate - highB.Ycoordinate) ^ 2);
            double acDistance = Math.Sqrt((highC.Xcoordinate - highA.Xcoordinate) ^ 2
                + (highC.Ycoordinate - highA.Ycoordinate) ^ 2);


            return abDistance + bcDistance + acDistance;
        }

        public override string ToString()
        {
            return base.ToString() + " - Dot A: " + highA + "; Dot B: " + highB + " ; Dot C: " + highC;
        }
    }
}
