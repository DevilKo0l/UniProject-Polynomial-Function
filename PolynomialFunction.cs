using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Function
{
    class PolynomialFunction
    {
        public int exponent;
        public double[] coefficients;
        public PolynomialFunction(double[] newCoefficients)
        {
            coefficients = newCoefficients;
            exponent = coefficients.Length - 1;
            
        }

        public void DisplayPolynomial()
        {
            Console.WriteLine("Calculated polynomial: ");
            Console.Write("f(x) = ");
            
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (exponent==0)
                {                    
                    Console.Write(Math.Round(coefficients[i], 2));
                }
                else
                {
                    Console.Write("{0}x^{1}", Math.Round(coefficients[i], 2), exponent);
                }
                
                exponent--;
            }
            Console.WriteLine();
        }



    }
}
