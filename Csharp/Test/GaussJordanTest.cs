using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class GaussJordanTest
    {
        [TestMethod]
        public void Solve()
        {
            Csharp.Array<Csharp.Array<double>> A = new Csharp.Array<Csharp.Array<double>>(3);
            A[0] = new Csharp.Array<double>(3);
            A[1] = new Csharp.Array<double>(3);
            A[2] = new Csharp.Array<double>(3);
            A[0][0] = 1;
            A[0][1] = -2;
            A[0][2] = 3;
            A[1][0] = 4;
            A[1][1] = -5;
            A[1][2] = 6;
            A[2][0] = 7;
            A[2][1] = -8;
            A[2][2] = 10;
            Csharp.Array<double> b = new Csharp.Array<double>(3);
            b[0] = 6;
            b[1] = 12;
            b[2] = 21;
            var answer = Csharp.Algorithm.GaussJordan.Solve(A, b);
            System.Console.WriteLine(answer[0]);
            System.Console.WriteLine(answer[1]);
            System.Console.WriteLine(answer[2]);
        }
    }
}
