using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class RotateImage
    {
        // 1 2 3
        // 4 5 6
        // 7 8 9

        // 7 2 1
        // 4 5 2
        // 9 8 3

        // 1,1 => 1,3
        // 1,3 => 3,3
        // 3,3 => 3,1
        // 3,1 => 1,1

        public void Rotate(int[][] matrix)
        {
            //i = row
            for (int i = 0; i < matrix.GetLength(1)/2; i++)
            {
                //j = column
                for(int j = 0 + i; j < matrix.GetLength(0)/2; j++)
                {
                    //Rotate
                    Swap(matrix, i, j);
                }
            }
        }

        private void Swap(int[][] matrix, int row, int column)
        {
            for (int k = 0; k < 4; k++)
            {
                int nextRow = matrix.GetLength(1) / 2 + row;
                int nextColumn = matrix.GetLength(0) - column;
                int temp = matrix[nextRow][nextColumn];

                matrix[nextRow][nextColumn] = matrix[row][column];
                row = nextRow;
                column = nextColumn;
            }
        }



        public void Rotate2(int[][] matrix)
        {
            //i = row
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                //j = column
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i][j] = matrix[matrix.GetLength(0) - j][i]; 
                }
            }
        }
    }
}
