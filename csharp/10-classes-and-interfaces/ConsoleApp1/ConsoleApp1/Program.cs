using System;
using System.Collections.Generic;
using System.Linq;

namespace Example // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Runner.Go();
        }

        static void GoSort()
        {
            int[] array = Enumerable
                .Repeat(0, 5)
                .Select(i => new Random().Next(0, 9))
                .ToArray();
            ISortable? sorter = null;

            int type = Console.Read();

            if (type == 0) sorter = new BubleSort();
            if (type == 1) sorter = new BubleSort();
            if (type == 2) sorter = new BubleSort();

            int[]? arraySorted = sorter?.Sort(array) ?? new int[0];

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", arraySorted));
        }
    }

    public interface ISortable
    {
        public int[] Sort(int[] array);
    }

    public class BubleSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            return array;
        }
    }
}