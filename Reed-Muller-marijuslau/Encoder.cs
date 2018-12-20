using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reed_Muller_marijuslau
{
    class Encoder
    {
        public List<string> ResultList = new List<string>();

        public string EncodeBits(string bitString, GenMatrixGenerator generator)
        {
            int[][] matrix = vectorMultiply(bitString, generator.Matrix, generator.Dimension, generator.N);

            Console.WriteLine("----------");
            for(int i = 0; i < generator.Dimension; i++)
            {
                for(int j = 0; j < generator.N; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("----------");

            string encodedVector = "";
            for(int d = 0; d < generator.N; d++)
            {
                int buf = 0;
                foreach (int[] i in matrix)
                {
                    buf += i[d];
                }
                if (buf % 2 == 1)
                {
                    encodedVector += "1";
                }
                else
                {
                    encodedVector += "0";
                }
            }
            
            return encodedVector;
        }

        private int[][] vectorMultiply(string bitString, int[][] genMatrix, int dimension, int lenght)
        {
            Console.WriteLine("***");
            int[][] multipliedMatrix = new int[dimension][];
            int index = 0;
            foreach(char a in bitString)
            {
                multipliedMatrix[index] = new int[lenght];
                int newMatrixIndex = 0;
                foreach(int j in genMatrix[index])
                {
                    
                    Console.Write(((int)char.GetNumericValue(a) * j).ToString());
                    

                    multipliedMatrix[index][newMatrixIndex] = (int)char.GetNumericValue(a) * j;
                    newMatrixIndex++;
                }
                index++;
                Console.Write("\n");
            }
            Console.WriteLine("***");
            return multipliedMatrix;
        }
    }
}
