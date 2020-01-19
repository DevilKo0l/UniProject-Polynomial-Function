using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Function
{
    public class Coordinate
    {
        public double x;
        public double y;
        public List<Coordinate> coordinatesList;

        public Coordinate(List<Coordinate> newCoordinatesList)
        {
            coordinatesList = newCoordinatesList;
        }
        public Coordinate(double newX, double newY)
        {
            x = newX;
            y = newY;
        }

        public Coordinate()
        {

        }
        public void SetCoordinates()
        {
            bool cont = true;
            int nPoint = 1;            
            while (cont)
            {
                string input;
                Console.Write($"Point#{nPoint}: ");
                input = Console.ReadLine();
                var spl = input.Split(' ');

                if (input.ToUpper() != "END")
                {
                    this.coordinatesList.Add(new Coordinate(double.Parse(spl[0]), double.Parse(spl[1])));
                    nPoint++;
                }
                else
                {
                    cont = false;
                }
            }            
        }

        public List<Coordinate> GetCoordinates()
        {
            return this.coordinatesList;
        }

    }
}
