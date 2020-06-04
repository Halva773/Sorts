using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BubbleSort
{
    class BubbleSort
    {
        public void Sort(int[] a)
        {
            for(int i = a.Length - 1; i >= 0; i--)
                for(int y = 0;y < i; y++)
                {
                    if (a[y] > a[y + 1]) 
                    {
                        int trash = a[y];
                        a[y] = a[y+1];
                        a[y + 1] = trash;
                    }
                }
            for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]); // Entering mas
        }
    }
}
