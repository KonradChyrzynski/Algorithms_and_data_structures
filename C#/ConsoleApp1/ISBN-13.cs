using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ISBN_13
    {
        private static char[] prefix;
        private static char[] country;
        private static char[] publisher;
        private static char[] publicationNumber;
        private static List<char> listOfConectedNumbers = new List<char>();
        public ISBN_13(string prefixConstructor, string countryConstructor, string publisherConstructor, string publicationNumberConstructor)
        {
            prefix = prefixConstructor.ToCharArray();
            country = countryConstructor.ToCharArray();
            publisher = publisherConstructor.ToCharArray();
            publicationNumber = publicationNumberConstructor.ToCharArray();
            addNumbersToList(prefix);
            addNumbersToList(country);
            addNumbersToList(publisher);
            addNumbersToList(publicationNumber);
            Console.WriteLine(checkSumSign());
        }

        private static double sumNumbersOfAList(List<char> list)
        {
            double sum = 0;
            int listLength = list.Count;
            for(int i = 1; i <= listLength; i++ )
            {
                int convertedNumber = Int32.Parse(list[i - 1].ToString());
                double pow = (i + 1) % 2;
                double power = Math.Pow(3, pow);
                Console.WriteLine("Power: {0}", pow);
                double calculations = (convertedNumber * power);
                sum += calculations;
                
            }
            Console.WriteLine(sum);
            return sum;

        }

        private static double checkSumSign()
        {
            return ((10 - (sumNumbersOfAList(listOfConectedNumbers)) % 10)) % 10;
        }

        private static void addNumbersToList(char[] arr){
            foreach (char x in arr) {
                listOfConectedNumbers.Add(x);
            }
        }
        private static void printList(List<char> lst) {
            foreach (char x in lst) { Console.WriteLine(x); }
        }

        private void sum(List<char> lst) {
            foreach(char x in lst) { Console.WriteLine(Int32.Parse(x.ToString()) + 5);}
        }

    }
}
