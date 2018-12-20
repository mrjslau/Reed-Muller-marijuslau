using System.Collections.Generic;

namespace Reed_Muller_marijuslau
{
    class Encoder
    {
        public List<string> ResultList = new List<string>();

        // Vektorių kodavimo funkcija
        public string EncodeBits(string bitString, GenMatrixGenerator generator)
        {
            int[][] matrix = VectorMultiply(bitString, generator.Matrix, generator.Dimension, generator.N);

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

        // Vektoriaus * matricos daugybos funkcija
        private int[][] VectorMultiply(string bitString, int[][] genMatrix, int dimension, int lenght)
        {
            int[][] multipliedMatrix = new int[dimension][];
            int index = 0;
            foreach(char a in bitString)
            {
                multipliedMatrix[index] = new int[lenght];
                int newMatrixIndex = 0;
                foreach(int j in genMatrix[index])
                {
                    multipliedMatrix[index][newMatrixIndex] = (int)char.GetNumericValue(a) * j;
                    newMatrixIndex++;
                }
                index++;
            }
            return multipliedMatrix;
        }
    }
}
