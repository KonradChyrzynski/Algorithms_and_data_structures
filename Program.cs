using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace AlghoritmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failed = 0;
            var tasks = new List<Task>();

            String[] urls = { "www.adatum.com", "www.cohovineyard.com",
                        "www.cohowinery.com", "www.northwindtraders.com",
                        "www.contoso.com" };

            foreach (var value in urls)
            {
                var url = value;
                tasks.Add(Task.Run(() => {
                    var png = new Ping();
                    try
                    {
                        var reply = png.Send(url);
                        if (!(reply.Status == IPStatus.Success))
                        {
                            Interlocked.Increment(ref failed);
                            throw new TimeoutException("Unable to reach " + url + ".");
                        }
                    }
                    catch (PingException)
                    {
                        Interlocked.Increment(ref failed);
                        throw;
                    }
                }));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
                Console.WriteLine("All ping attempts succeeded.");
            else if (t.Status == TaskStatus.Faulted)
                Console.WriteLine("{0} ping attempts failed", failed);

        }

        public static IEnumerable<List<char>> SplitList<T>(List<char> locations, int nSize)
        {
            for (int i = 0; i < locations.Count; i += nSize)
            {
                yield return locations.GetRange(i, Math.Min(nSize, locations.Count - i));
            }
        }

        static List<int[]> FindDuplicatedProduct(int[] arr)
        {
            Dictionary<int, List<int[]>> map = new Dictionary<int, List<int[]>>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    int product = arr[i] * arr[j];

                    if (map.ContainsKey(product))
                    {
                        map[product].Add(new int[] { i, j });

                        return map[product];
                    }
                    else
                    {
                        map.Add(product, new List<int[]>() { new int[] { i, j } });
                    }
                }
            }

            return null;
        }

        private static bool checkParenthesis(string sequence)
        {
            Stack<string> stack = new Stack<string>();
            Dictionary<char, string> dictionary = new Dictionary<char, string>()
            {
                { char.Parse("\""), "straightquotationmarks" },
                { char.Parse("\'"), "singlestraightquotationmarks" }
            };

            foreach (char c in sequence)
            {
                if (dictionary.ContainsKey(c))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(dictionary[c]);
                    }
                    else 
                    {
                        if (stack.Contains(dictionary[c]))
                        {
                            if (stack.Peek() == dictionary[c])
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else 
                        {
                            stack.Push(dictionary[c]);
                        }
                    }
                }
                else 
                {
                    return false;
                }
            }
            if (stack.Count != 0) 
            {
                return false;
            }
            return true;

        }




        private static void showFirstIndexesOfReapeatedNumbers(List<int> list)  
        {
            Dictionary<int, List<int>> valeIndexPair = new Dictionary<int, List<int>>();

            int index = 0;
            foreach (int i in list)
            {
                if (valeIndexPair.ContainsKey(i))
                {
                    valeIndexPair[i].Add(index);
                }
                else 
                {
                    valeIndexPair[i] = new List<int>() { index };
                }
                index++;
            }
        }
    }
}
