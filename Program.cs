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
            Console.WriteLine("Please input points in x y representation");
            //List<Point> points = new List<Point>() { new Point(2, 5), new Point(3, 6), new Point(7,4) };
            CartesianCoordinate cooridnate = new CartesianCoordinate();
            cooridnate.SetCoordinates();
            cooridnate.DisplayCoordinate();


            EquationSystem equation = new EquationSystem(cooridnate);
            equation.SetMatrix();
            equation.DisplayMatrix();
            equation.DisplayResult();

            PolynomialFunction poly = new PolynomialFunction(equation.GetRoot());
            poly.DisplayPolynomial();

        }
    }
}
