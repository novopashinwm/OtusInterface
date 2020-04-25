using System;
using System.Numerics;

namespace OtusInterfaceTask01
{
    public class OtusAlgorithm : IAlgoritm
    {
        public BigInteger FindFibo(int n)
        {
            if (n <= 40)
                return findFiboRecurs(n);
            return findFiboFast(n);
        }

        private BigInteger findFiboRecurs(int n)
        {
            if (n == 0)
                return 1;
            return findFiboRecurs(n - 1) + findFiboRecurs(n - 2);
        }

        private BigInteger findFiboFast(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            BigInteger f = a + b;
            for (int i = 0; i < n; i++)
            {
                f = a + b;
                a = b;
                b = f;
            }

            return f;

        }
    }
}