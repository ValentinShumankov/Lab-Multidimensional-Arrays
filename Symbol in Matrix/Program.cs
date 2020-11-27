using System;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size,size];
            bool found = false;
            for ( int row = 0; row < matrix.GetLength( 0 ); row++ )
            {
                char[] curRow = Console.ReadLine( ).ToCharArray();
                for ( int col = 0; col < matrix.GetLength( 1 ); col++ )
                {
                    matrix [ row, col ] = curRow [ col ];
                }
            }
            char toLookForSymbol =char.Parse( Console.ReadLine());
            for ( int row = 0; row < matrix.GetLength( 0 ); row++ )
            {
                for ( int col = 0; col < matrix.GetLength( 1 ); col++ )
                {
                    if ( matrix [ row, col ]  == toLookForSymbol)
                    {
                        found = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if ( found )
                {
                    break;
                }
            }
            if ( found == false )
            {
                Console.WriteLine(toLookForSymbol + " does not occur in the matrix" );
            }
        }
    }
}
