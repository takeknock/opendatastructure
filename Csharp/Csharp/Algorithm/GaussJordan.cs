using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Algorithm
{
    public class GaussJordan
    {
        /// <summary>
        /// Solve Ax=b
        /// </summary>
        /// <param name="A"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public Array<double> Solve(Array<Array<double>> A, Array<double> b)
        {
            int n = A.Length;
            Array<Array<double>> B = new Array<Array<double>>(n);
            for (int i = 0; i < n; i++)
            {
                B[i] = new Array<double>(n + 1);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i][j] = A[i][j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                B[i][n] = b[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(B[i][i]) < 1E-8)
                {
                    return new Array<double>(n);
                }
                for (int j = i+1; j <= n; j++)
                {
                    B[i][j] /= B[i][i];
                }
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        for (int k = i+1 ; k <= n; k++)
                        {
                            B[j][k] -= B[i][j] * B[i][k];
                        }
                    }
                }
            }
            Array<double> x = new Array<double>(n);
            for (int i = 0; i < n; i++)
            {
                x[i] = B[i][n];
            }
            return x;
        }
    }
}
