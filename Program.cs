using System;

namespace QuickSort
{
    class Program
    {
        public class Sorting
        {
            public  void exchange (int[] data, int m,int n)
            {
                int t;
                t = data[m];
                data[m] = data[n];
                data[n] = t;
            }

            public  void IntArrayQuickSort(int[] data, int l, int r)
            {
                int i, j, x;

                i = l;
                j = r;

                x = data[(l + r) / 2];
                while (true)
                {
                    while (data[i] < x)
                        i++;
                    while (x < data[j])
                        j--;
                    if (i <= j)
                    {
                        exchange(data, i, j);
                        i++;
                        j--;
                    }
                    if (i > j)
                    {
                        break;
                    }
                }

                if (l < j)
                    IntArrayQuickSort(data, l, j);
                if (i < r)
                    IntArrayQuickSort(data, i, r);

            }
            public void IntArrayQuickSort(int[] data)
            {
                IntArrayQuickSort(data, 0, data.Length - 1);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                int[] Numbers = new int[] { 4, 3, 8, 1, 10, 2 };
                Sorting obj = new Sorting();
                Console.WriteLine("Unsorted array: \n");
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Console.Write(Numbers[i] + "  ");
                }
                obj.IntArrayQuickSort(Numbers);

                Console.WriteLine(" \nSorted array:\n ");
                for(int i =0; i<Numbers.Length;i++)
                {
                    Console.Write(Numbers[i] + "  ");
                }
                Console.ReadKey();
            }
        }
    }
}
