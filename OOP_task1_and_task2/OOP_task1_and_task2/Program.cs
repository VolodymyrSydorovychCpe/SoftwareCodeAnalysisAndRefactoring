using System;

namespace OOP_task1_and_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");

            Circle circle = new Circle(10);
            circle.ShowLocationAndRadius();

            circle = new Circle(5, 5, 20);
            circle.ShowLocationAndRadius();

            Console.WriteLine("Aria of circle is: " + circle.GetAriaOfCircle());

            circle.MoveCircle(1, 1);
            circle.ShowLocationAndRadius();
            
            Console.WriteLine("Task2");

            Console.WriteLine(circle.XCoordinate);
            Console.WriteLine(circle.YCoordinate);
            Console.WriteLine(circle.Radius);

            circle.XCoordinate = 10;
            circle.YCoordinate = 10;
            circle.Radius = 10;

            circle.ShowLocationAndRadius();

            Console.WriteLine(circle[0]);
            Console.WriteLine(circle[1]);
            Console.WriteLine(circle[2]);
        }
    }
}
