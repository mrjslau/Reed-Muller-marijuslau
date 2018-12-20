using System;
using System.Linq;

namespace Reed_Muller_marijuslau
{
    class GenMatrixGenerator
    {
        public int R, M, N, Dimension;
        public int[][] Matrix;
        public int[][] WorkMatrix;
        public bool StartFlag = false;

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
                int take = N / 2;
                for (int m = 1; m <= M; m++)
                {
                    int[] nextVec = GetIntVector(N, take);
                    Matrix[m] = nextVec;
                    take /= 2;
                }
                int currLenght = M + 1;

                if (R > 1)
                {
                    WorkMatrix = Matrix;
                    int loopCount = 1;
                    for (int cl = currLenght; cl < Dimension; cl++)
                    {
                        int[] checkVector = GetAdditionalVector(currLenght, loopCount);

                        if (checkVector == null && !StartFlag)
                        {
                            Console.WriteLine("PATEKO CIA");
                            loopCount = currLenght;
                            currLenght = cl;
                            checkVector = GetAdditionalVector(cl, loopCount);
                        }
                        else if (StartFlag)
                        {
                            loopCount++;
                            StartFlag = false;
                            Console.WriteLine("*Start flag reset*");
                            checkVector = GetAdditionalVector(cl, loopCount);
                        }
                        Matrix[cl] = checkVector;


                        // DEBUG LOOP PRINT
                        for (int xi = 0; xi < cl+1; xi++)
                        {
                            string vec = "";
                            for (int xj = 0; xj < N; xj++)
                            {
                                vec = vec + Matrix[xi][xj].ToString();
                            }
                            Console.WriteLine(xi + " gen matricos vektorius: " + vec);
                        }
                        Console.WriteLine("----------------------cl was:" + cl);
                    }
                }
            }
        }

        int[] GetAdditionalVector(int lenght, int startPoint)
        {
            int[] vector = null;
            int currLenght = lenght;
            for (int i = startPoint; i < currLenght; i++)
            {
                if (i > startPoint)
                {
                    StartFlag = true;
                    Console.WriteLine("Start point:" + startPoint);
                    return vector;
                }
                for (int j = i + 1; j < currLenght; j++)
                {
                    vector = VectorsAnd(Matrix[i], Matrix[j]);
                    if (!IsThereAnEqual(vector))
                        return vector;
                }
                vector = null;
            }
            return vector;
        }

        int[] VectorsAnd(int[] vec1, int[] vec2)
        {
            int[] resVec = new int[N];
            for(int i = 0; i < N; i++)
            {
                if (vec1[i] == vec2[i] && vec1[i] == 1)
                {
                    resVec[i] = 1;
                }
                else
                {
                    resVec[i] = 0;
                }
            }
            return resVec;
        }

        bool IsThereAnEqual(int[] vec)
        {
            foreach(int[] v in Matrix)
            {
                if (v != null)
                {
                    if (vec.SequenceEqual(v))
                    {
                        return true;
                    }
                }
            }
            return false;
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

            int i = 0;
            while (i < length)
            {
                for (int j = 0; j < take; j++)
                {
                    vector[index] = 1;
                    index++;
                }
                for (int j = 0; j < take; j++)
                {
                    vector[index] = 0;
                    index++;
                }
                i += take * 2;
            }

            return vector;
        }
    }
}
