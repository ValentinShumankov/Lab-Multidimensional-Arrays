using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int size = int.Parse(Console.ReadLine());
            int cols = 1;
            long[][] array = new long[size][];
            for ( int row = 0; row < array.Length; row++ )
            {
                array [ row ] = new long [ cols ];
                array [ row ] [ 0 ] = 1;
                array [ row ] [ array [ row ].Length - 1 ] = 1;
                if ( row > 1 )
                {
                    for ( int col = 1; col < array [ row ].Length - 1; col++ )
                    {
                        long[] previousRow = array [ row - 1 ];
                        long firstNum = previousRow[col];
                        long secondNum = previousRow[col - 1];
                        array [ row ] [ col ] = firstNum + secondNum;
                    }
                }
                cols++;
            }
            for ( int i = 0; i < array.Length; i++ )
            {
                for ( int k = 0; k < array[i].Length; k++ )
                {
                    Console.Write(array[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
