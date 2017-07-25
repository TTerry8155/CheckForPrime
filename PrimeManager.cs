using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetermineIfANumberIsPrime
{
    public class PrimeManager
    {
        public static bool CheckIfPrime(int number)
        {
            return (Enumerable.Range(1, number).Count(x => number % x == 0) == 2);
        }
    }
}
