using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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
                int[] curRow = Console.ReadLine( ).Split( " " ).Select( int.Parse ).ToArray( );
                for ( int col = 0; col < matrix.GetLength( 1 ); col++ )
                {
                    matrix [ row, col ] = curRow [ col ];
                }
            }
            for ( int col = 0; col < matrix.GetLength( 1 ); col++ )
            {
                int sum = 0;
                for ( int row = 0; row < matrix.GetLength( 0 ); row++ )
                {
                    sum += matrix [ row, col ];
                }
                Console.WriteLine( sum );
            }
        }
    }
}
