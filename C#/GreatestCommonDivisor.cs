
namespace AlghoritmsAndDataStructures 
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
    }
}
