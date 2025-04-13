using System;
using System.Collections.Generic;

namespace AlghoritmsAndDataStructures;

public sealed class MathExtensions
{
    public static int gcp_euclidean(int a, int b)
    {
        if (b != 0)
        {
            return gcp_euclidean(b, a % b);
        }

        return a;
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
}
