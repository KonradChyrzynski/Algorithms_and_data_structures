using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public class KPMSearch
    {
        string sToSearch = "africalegalnetwork.com#EXT#";
        string pattern = "#EXT#";

        [Benchmark]
        public void KMPSGDG() => Program.KMPSearch(pattern, sToSearch);

        [Benchmark]
        public void REGEX() => Program.RegexStringSearch(sToSearch, pattern);

        [Benchmark]
        public void Contains() => sToSearch.Contains(pattern);

        public class Program 
        {
            public static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            }

            public static void RegexStringSearch(string sToSearch, string pattern){

                var regex = new Regex(pattern);

                var matches = regex.Matches(sToSearch);
                //Use while loop to loop through all Matches
                //

                var length = matches.Count;

                while (length > 0)
                {
                    length--;
                    Console.WriteLine(matches[length].Index);
                }
            }

            public static void KMPSearch(string pat, string txt)
            {
                int M = pat.Length;
                int N = txt.Length;

                // create longestProperPrefix[] that will hold the longest
                // prefix suffix values for pattern
                // Proper prefixes of ABC are {A, AB}, {A, B} and {A}

                int[] longestProperPrefix = new int[M];
                int j = 0; // index for pat[]

                // Preprocess the pattern (calculate longestProperPrefix[]
                // array)
                Program.computeLPSArray(pat, M, longestProperPrefix);

                int i = 0; // index for txt[]
                while (i < N) {
                    if (pat[j] == txt[i]) {
                        j++;
                        i++;
                    }
                    if (j == M) {
                        Console.Write("Found pattern "
                                + "at index " + (i - j));
                        j = longestProperPrefix[j - 1];
                    }

                    // mismatch after j matches
                    else if (i < N && pat[j] != txt[i]) {
                        // Do not match longestProperPrefix[0..longestProperPrefix[j-1]] characters,
                        // they will match anyway
                        if (j != 0)
                            j = longestProperPrefix[j - 1];
                        else
                            i = i + 1;
                    }
                }
            }

            static void computeLPSArray(string pat, int M, int[] longestProperPrefix)
            {
                // length of the previous longest prefix suffix
                int len = 0;
                int i = 1;
                longestProperPrefix[0] = 0; // longestProperPrefix[0] is always 0

                // the loop calculates longestProperPrefix[i] for i = 1 to M-1
                while (i < M) {
                    if (pat[i] == pat[len]) {
                        len++;
                        longestProperPrefix[i] = len;
                        i++;
                    }
                    else // (pat[i] != pat[len])
                    {
                        // This is tricky. Consider the example.
                        // AAACAAAA and i = 7. The idea is similar
                        // to search step.
                        if (len != 0) {
                            len = longestProperPrefix[len - 1];

                            // Also, note that we do not increment
                            // i here
                        }
                        else // if (len == 0)
                        {
                            longestProperPrefix[i] = len;
                            i++;
                        }
                    }
                }
            }
        }

    }
}

