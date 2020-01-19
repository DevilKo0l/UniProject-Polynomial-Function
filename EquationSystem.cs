using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Function
{
    class EquationSystem: VendermodeMatrix
    {
        private readonly GaussianElimination _gausian;
        private readonly Coordinate _coordinates;

        public EquationSystem(Coordinate coordinate,GaussianElimination gaussian)
            :base(coordinate)
        {
            _coordinates = coordinate;
            _gausian = gaussian;
           
        }
        
        public void DisplayResult()
        {
            var result = _gausian.BackwardsSubstitution(matrix);
            Console.WriteLine("\nResult: ");
            int numX = result.Length;
            for (int i = 0; i < numX; i++)
            {
                Console.WriteLine("X{0}: {1}", i + 1, result[i]);
            }
        }


    }
}
