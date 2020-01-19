using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_Function
{
    public class VendermodeMatrix
    {
        public int nRow;
        public int nCol;
        public double[,] matrix;
        private readonly Coordinate _coordinate;
        
        public VendermodeMatrix(Coordinate coordintate)
        {
            _coordinate = coordintate;
            nRow = coordintate.GetCoordinates().Count;
            nCol = coordintate.GetCoordinates().Count+1;
            matrix = new double[nRow, nCol];           
        }
        
        public void SetVandermondeMatrix()
        {
            int exponent = _coordinate.coordinatesList.Count() - 1;            
            double[,] matrix = new double[nRow, nCol];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (j == nCol - 2)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == nCol - 1)
                    {
                        matrix[i, j] = _coordinate.coordinatesList[i].y;
                    }
                    else
                    {
                        matrix[i, j] = Math.Pow(_coordinate.coordinatesList[i].x, exponent);
                    }
                    exponent--;
                }
                exponent = _coordinate.coordinatesList.Count() - 1;
            }            
        }

        public double[,] GetVandermoodeMatrix()
        {
            return this.matrix;
        }
        public void DisplayMatrix()
        {
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("{0}  ",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
