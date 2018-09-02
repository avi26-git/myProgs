using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDemos
{
    class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int arr)
        {
            for (int i = 0; i < arr; i++)
            {
                string print = ReturnStars().Take(i + 1).Aggregate((a, b) => a + b);
                List<string> test = ReturnStars().Take(i + 1).ToList();
                Console.Write(print.PadLeft(arr));
                Console.WriteLine();
            }

        }
        static IEnumerable<string> ReturnStars()
        {
            while (1 == 1)
            {
                yield return "#";
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
