using System;
using System.Collections.Generic;

namespace Polynomial_Function
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input points in x y representation");
            List<Point> points = new List<Point>() { new Point(1, -1), new Point(-2, 3), new Point(5, 1) };
            CartesianCoordinate cooridnate = new CartesianCoordinate(points);
            //cooridnate.SetCoordinates();
            cooridnate.DisplayCoordinate();

            EquationSystem equation = new EquationSystem(cooridnate);
            equation.SetMatrix();
            equation.DisplayMatrix();
            equation.DisplayResult();

            PolynomialFunction poly = new PolynomialFunction(equation.GetRoot());
            poly.DisplayPolynomial();
            poly.CalculatePolynomial();
            poly.DisplayPolynomialResult();
            poly.getDerivativeCoefficient();
            poly.DisplayDerivative();
        }
    }
}