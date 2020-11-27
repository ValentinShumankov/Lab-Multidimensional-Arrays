using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sizeRow = sizeMatrix[0];
            int sizeCol = sizeMatrix[1];
            int[,] matrix = new int[sizeRow,sizeCol];
            for ( int row = 0; row < matrix.GetLength( 0 ); row++ )
            {
                int[] curRow = Console.ReadLine( ).Split( ", " ).Select( int.Parse ).ToArray( );
                for ( int col = 0; col < matrix.GetLength( 1 ); col++ )
                {
                   matrix [ row, col ] = curRow [ col ];
                }
            }
            int sum = 0;
            for ( int row = 0; row < matrix.GetLength(0); row++ )
            {
                for ( int col = 0; col < matrix.GetLength(1); col++ )
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sizeRow);
            Console.WriteLine(sizeCol);
            Console.WriteLine(sum);
        }
    }
}
