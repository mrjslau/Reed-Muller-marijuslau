using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reed_Muller_marijuslau
{
    class GenMatrixGenerator
    {
        int R, M, N;
        int[][] Matrixx;
        public string[] Matrix { get; set; } 

        public GenMatrixGenerator(int r, int m)
        {
            R = r;
            M = m;
            N = Convert.ToInt32(Math.Pow(2, m));
            GenerateMatrix();
        }

        void GenerateMatrix()
        {
            List<string> bitList = new List<string>();

            Console.WriteLine("[R=" + R + ", M=" + M + "]");
            int test = 1;
            for (int r = 1; r <= R; r++)                                   
            {
                Console.WriteLine("test = " + test);
                test += Factorial(M) / (Factorial(r) * Factorial(M - r));
            }
            Console.WriteLine("Turėtų būti k = " + test + " " + N + "-ilgio žodžių");

            GetOnesVector(N);
            string v0 = GetOnesVector(N);
            bitList.Add(v0);

            if (R > 0)
            {
                int take = 1;
                for(int m = 1; m <= M; m++)
                {
                    string nextVec = GetVector(N, take); 
                    bitList.Add(nextVec);
                    take *= 2;
                }
            }

            if (R > 1)
            {

            }

            int tmpi = 1;
            foreach (string bits in bitList)
            {
                Console.WriteLine(tmpi + " vektorius: " + bits);
                tmpi++;
            }

            Matrixx = new int[test][];
            for(int i = 0; i < N; i++)
            {
                Matrixx[0][i] = 1;
            }
            if (R > 0)
            {
                int take = 1;
                for (int m = 1; m <= M; m++)
                {
                    int[] nextVec = GetIntVector(N, take);
                    Matrixx[m] = nextVec;
                    take *= 2;
                }
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

        public static string GetOnesVector(int length)
        {
            string vector = "";

            while (vector.Length != length)
            {
                vector = "1" + vector;
            }

            return vector;
        }

        public static string GetVector(int length, int take)
        {
            string vector = "";

            while (vector.Length != length)
            {
                for(int i = 0; i < take; i++)
                {
                    vector = vector + "0";
                }
                for (int i = 0; i < take; i++)
                {
                    vector = vector + "1";
                }
            }

            return vector;
        }

        public static int[] GetIntVector(int length, int take)
        {
            int[] vector = new int[length];

            for(int i = 0; i < length; i++)
            {
                for (int j = 0; j < take; j++)
                {
                    vector[i] = 0;
                }
                for (int j = 0; j < take; j++)
                {
                    vector[i] = 1;
                }
            }

            return vector;
        }
    }
}
