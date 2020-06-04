using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bubble = new BubbleSort();

            int[] mas = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray(); // Reading mas

            Bubble.Sort(mas);

            
        }
    }
}
