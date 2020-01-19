using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polynomial_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input points in x y representation.");
            Console.WriteLine("Type END to finish.");
            Coordinate newCoordinate = new Coordinate();
            newCoordinate.SetCoordinates();
            var coordinate = newCoordinate.GetCoordinates();

            EquationSystem newEquation = new EquationSystem(newCoordinate, new GaussianElimination());

        }
    }
}
