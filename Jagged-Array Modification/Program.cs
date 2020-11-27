using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int[][] matrix = new int[int.Parse(Console.ReadLine())][];
            for ( int i = 0; i < matrix.GetLength( 0 ); i++ )
            {
                int[] curRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix [ i ] = new int [ curRow.Length ];
                for ( int k = 0; k < curRow.Length; k++ )
                {
                    matrix [ i ] [ k ] = curRow [ k ];
                }
            }
            string[] input = Console.ReadLine().Split().ToArray();
            while ( input [ 0 ] != "END" )
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if ( row < matrix.Length && row >= 0 )
                {
                    if ( col < matrix [ row ].Length && col >= 0 )
                    {
                        switch ( input [ 0 ] )
                        {
                            case "Add":
                                matrix [ row ] [ col ] += value;
                                break;
                            case "Subtract":
                                matrix [ row ] [ col ] -= value;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine( "Invalid coordinates" );

                    }
                }
                else
                {
                    Console.WriteLine( "Invalid coordinates" );

                }
                input = Console.ReadLine( ).Split( ).ToArray( );
            }
            foreach ( var item in matrix )
            {
                Console.WriteLine( string.Join( " ", item ) );
            }
        }
    }
}
