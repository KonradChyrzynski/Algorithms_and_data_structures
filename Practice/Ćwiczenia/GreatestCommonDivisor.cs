using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class GreatestCommonDivisor
    {
        public int gcp_euclidean(int a, int b)
        {
            if (b != 0)
            {
                return gcp_euclidean(b, a % b);
            }
            return a;
        }

        public List<int> findDivisorsOfNumber(int a) 
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Math.Sqrt(a); i++) 
            {
                if (a % i == 0) 
                {
                    if (a / i == i)
                    {
                        list.Add(i);
                    }
                    else 
                    {
                        list.Add(i);
                        list.Add(a / i);
                    }
                }
            }

            return list;
        }

        public List<int> findCommonDivisorsOf2Numbers(int a, int b) 
        {
            int n = gcp_euclidean(a,b);
            return findDivisorsOfNumber(n);
        }
    }
}
