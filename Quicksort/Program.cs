using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1= new int[] {6,3,5,1,9,8 };
            Console.WriteLine(Outputing(ar1));

            Quicksorting(ar1,0,ar1.Length-1);

            Console.WriteLine(Outputing(ar1));

        }

        static void Quicksorting(int[] array, int start, int end)
        {
            if (start>= end)
            {
                return;
            }
            int spec = PartOfSorting(array,start, end);
            Quicksorting(array, start, spec - 1);
            Quicksorting(array, spec + 1, end);
        }

        static int PartOfSorting(int[] array, int start, int end)
        {
            int mark = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i]<=array[end])
                {
                    int temp = array[mark]; // swap
                    array[mark] = array[i];
                    array[i] = temp;
                    mark += 1;
                }
            }

            return mark-1;
        }
        static string Outputing(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }


    }
}
