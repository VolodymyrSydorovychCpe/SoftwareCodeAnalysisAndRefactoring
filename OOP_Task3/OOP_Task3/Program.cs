using System;
using System.Collections.Generic;

namespace OOP_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Triangle(0, 0, 3, 6, 5, 8);
            Figure pyramide = new Pyramid(1, 1, 4, 7, 6, 8, 14);

            Figure[] figureList = new Figure[] { triangle, pyramide};

            figureList[0].Move(0, 0, 3, 6, 6, 9);
            figureList[1].Move(1, 1, 4, 7, 6, 8);

            foreach (Figure figure in figureList)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine("Perimetr = " + figure.GetPerimetr());
                Console.WriteLine("Aria = " + figure.GetAria());
            }
        }
    }
}
