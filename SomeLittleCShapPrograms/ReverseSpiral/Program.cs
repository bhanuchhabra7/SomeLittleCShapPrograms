using System;

namespace ReverseSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 6;
            const int columns = 6;

            char[,] inputArray = { 
                { 'N',' ','C','S','H','A' },
                {'I',' ','P','R','O','R' },
                {' ','E','I',' ','G','P' },
                {'G','V','O','L','R',' ' },
                {'N','I','M','M','A','L' },
                {'O','G','S','\'','T','E' }};

            ReversespiralPrint(rows, columns, inputArray);
        }

        private static void ReversespiralPrint(int rows, int columns, char[,] inputArray)
        {
            var size = rows * columns;
            var destinationArray = new char[size];
            var rowStart = 0;
            var rowEnd = rows - 1;
            var colStart = 0;
            var colEnd = columns - 1;
            var z = 0;

            while (z != size)
            {
                char val;

                // Bottom row from remaining
                for (var i = colStart; i <= colEnd; i++)
                {
                    val = inputArray[rowEnd, i];
                    destinationArray[z] = val;
                    z++;
                }
                rowEnd--; // bottom row is copied from array

                // Right column from remaining
                for (var i = rowEnd; i >= rowStart; i--)
                {
                    destinationArray[z++] = inputArray[i, colEnd];
                }
                colEnd--; // right column is copied from array

                // Top row from remaining
                for (var i = colEnd; i >= colStart; i--)
                {
                    destinationArray[z++] = inputArray[rowStart, i];
                }
                rowStart++; // top row is copied from array

                // Left column from remaining
                for (var i = rowStart; i <= rowEnd; i++)
                {
                    destinationArray[z++] = inputArray[i, colStart];
                }
                colStart++; // left column is copied from array
            }

            // basically reverse print
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(destinationArray[i]);
            }
        }
    }
}
