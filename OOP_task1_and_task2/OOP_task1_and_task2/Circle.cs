using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_task1_and_task2
{
    class Circle
    {
        private double x;
        public double XCoordinate        
        { 
            get 
            {
                Console.WriteLine("Method get for x was invoked");
                return x;
            }
            set 
            {
                Console.WriteLine("Method set for x was invoked");
                x = value; 
            }
        }

        private double y;
        public double YCoordinate
        { 
            get
            {
                Console.WriteLine("Method get for y was invoked");
                return y;
            }
            set
            {
                Console.WriteLine("Method set for y was invoked");
                y = value;
            }
        }

        private double r;
        public double Radius
        { 
            get
            {
                Console.WriteLine("Method get for r was invoked");
                return r;
            }
            set
            {
                Console.WriteLine("Method set for r was invoked");
                r = value;
            }
        }

        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return GetAriaOfCircle();
                }
                if (i == 1)
                {
                    return GetCirclePeremiter();
                }
                if (i == 2)
                {
                    return GetCircleDiameter();
                }
                return 0;
            }
        }

        public Circle(double radius)
        {
            this.x = 0;
            this.y = 0;
            this.r = radius;
        }

        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.r = radius;
        }

        public void ShowLocationAndRadius()
        {
            Console.WriteLine("Circle location is: " + x + ", " + y);
            Console.WriteLine("Circle radius is: " + r);
        }

        public double GetAriaOfCircle()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public void MoveCircle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private double GetCirclePeremiter()
        {
            return 2 * Math.PI * r;
        }

        private double GetCircleDiameter()
        {
            return 2 * r;
        }
    }
}
