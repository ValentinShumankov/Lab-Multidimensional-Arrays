using System;
using System.Linq;

namespace Square_with_Maximum_Sum
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
            int sum = int.MinValue;
            int bestRow = int.MinValue;
            int bestCol = int.MinValue;
            for ( int row = 0; row < matrix.GetLength( 0 ) - 1; row++ )
            {
                for ( int col = 0; col < matrix.GetLength( 1 ) - 1; col++ )
                {
                    var curSum = matrix [ row, col ] + matrix [ row, col + 1 ] +
                          matrix [ row + 1, col ] + matrix [ row + 1, col + 1 ];
                    if ( curSum > sum )
                    {
                        sum = curSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine( matrix [ bestRow, bestCol ] + " " + matrix [ bestRow, bestCol + 1 ] );
            Console.WriteLine( matrix [ bestRow + 1, bestCol ] + " " + matrix [ bestRow + 1, bestCol + 1 ] );
            Console.WriteLine( sum );
        }
    }
}
