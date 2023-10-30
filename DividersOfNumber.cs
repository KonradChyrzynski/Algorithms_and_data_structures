using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace AlghoritmsAndDataStructures
{
    public class DividersOfNumber
    {
        public void printDividersOfNumbersSync()
        {
            foreach (int number in findDividersOfNumberSync(5))
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> findDividersOfNumberSync(int number) 
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<int> findDividersOfNumberSquare(int number) 
        {
            List<int> result = new List<int>();
            for(int i = 1; i <= Math.Sqrt(number); i++) 
            { 
                if(number % i == 0) 
                { 
                    if (number / i == i) 
                    {
                        result.Add(i);
                    }
                    else 
                    {
                        result.Add(number / i);
                        result.Add(i);
                    }
                }
            }
            return result;
        }

        [Benchmark]
        public List<int> findDivisorsSync() => findDividersOfNumberSync(36);
        [Benchmark]
        public List<int> findDivisorsSquare() => findDividersOfNumberSquare(36);
    }
}
