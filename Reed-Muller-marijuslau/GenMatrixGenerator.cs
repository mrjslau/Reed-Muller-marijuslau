using System;

namespace Reed_Muller_marijuslau
{
    class GenMatrixGenerator
    {
        public int R, M, N, Dimension;
        public int[][] Matrix;

        public GenMatrixGenerator(int r, int m)
        {
            R = r;
            M = m;
            N = Convert.ToInt32(Math.Pow(2, m));
            GenerateMatrix();
        }

        void GenerateMatrix()
        {
            Console.WriteLine("[R=" + R + ", M=" + M + "]");
            int dimension = 1;
            for (int r = 1; r <= R; r++)                                   
            {
                dimension += Factorial(M) / (Factorial(r) * Factorial(M - r));
                Dimension = dimension;
            }
            Console.WriteLine("Turi būti k = " + dimension + " " + N + "-ilgio vektoriu");
     
            Matrix = new int[dimension][];
            Matrix[0] = new int[N];
            for(int i = 0; i < N; i++)
            {
                Matrix[0][i] = 1;
            }
            if (R > 0)
            {
                int take = 1;
                for (int m = 1; m <= M; m++)
                {
                    int[] nextVec = GetIntVector(N, take);
                    Matrix[m] = nextVec;
                    take *= 2;
                }


                // DEBUG PRINT
                for (int i = 0; i < dimension; i++)
                {
                    string vec = "";
                    for (int j = 0; j < N; j++)
                    {
                        vec = vec + Matrix[i][j].ToString();
                    }
                    Console.WriteLine(i + " vektorius: " + vec);
                }
                // ----------
            }
        }

        private static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }

        public static int[] GetIntVector(int length, int take)
        {
            int[] vector = new int[length];
            int index = 0;

            for(int i = 0; i < length; i++)
            {
                for (int j = 0; j < take; j++)
                {
                    // Console.WriteLine("Index: " + index + " i:" + i + " j:" + j);
                    vector[index] = 0;
                    index++;
                }
                for (int j = 0; j < take; j++)
                {
                    // Console.WriteLine("Index: " + index + " i:" + i + " j:" + j);
                    vector[index] = 1;
                    index++;
                }
                i += take * 2;
            }

            return vector;
        }
    }
}
