using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yieldSample02
{
    class Program
    {
        static Random rand = new Random();

        private static IEnumerable<int> GetCollection1(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 100)
                {
                    yield break;
                }
                else
                {
                    yield return number;
                }
            }
        }

        private static IEnumerable<int> GetCollection2(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return rand.Next(39);
            }
        }

        static void Main(string[] args)
        {
            // object initializer
            List<int> numbers = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256
            };

            var c1 = GetCollection1(numbers);
            Console.Write("Output of GetCollection1(): ");
            foreach (var c in c1)
                Console.Write(c + " ");
            Console.WriteLine("");

            //Randem Number
            var c2 = GetCollection2(6);
            Console.Write("Output of GetCollection2(): ");
            foreach (var c in c2)
                Console.Write(c + " ");
            Console.WriteLine("");

            Console.ReadLine();

        }
    }
}
