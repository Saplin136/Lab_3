using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];
            int[] Z = new int[4];
            int jA, jB;

            A = Fill();
            Console.WriteLine("A(4, 4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            jA = Search(A);
            Console.WriteLine('\n' + "Column with lowest value = " + jA + '\n' + '\n');

            B = Fill();
            Console.WriteLine("B(4, 4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            jB = Search(B);
            Console.WriteLine('\n' + "Column with lowest value = " + jB + '\n');

            Z = Vector(A, B, jA, jB);
            Console.WriteLine("Z:");
            for (int i = 0; i < 4; i++)
                Console.Write(Z[i] + "  ");
        }

        public static int[,] Fill()
        {
            int[,] x = new int[4, 4];
            Random rnd = new Random();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    x[i, j] = rnd.Next(-128, 128);
                }
            }
            return x;
        }

        public static int Search(int[,] x)
        {
            int k = 0;
            int value = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (value > x[i, j])
                    {
                        value = x[i, j];
                        k = j;
                    }
                }
            }
            return k;
        }

        public static int[] Vector(int [,] x, int [,] y, int jA, int jB)
        {
            int[] z = new int[4];
            for(int i = 0; i < 4; i++)
            {
                z[i] = x[i, jA] - y[i, jB];
            }
            return z;
        }
    }
}
 