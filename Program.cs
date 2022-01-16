using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int targetIndex = SearchArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, input);
            Console.WriteLine(targetIndex);

            Console.ReadLine();
        }

        public static int SearchArray(int[] arr, int target)
        {
            int targetIndex = 0;
            double left = 0;
            double right = arr.Length - 1;
            int mid;
            if (target < arr[0])
            {
                targetIndex = - 1;
            }
            else
            {
                while (left <= right)
                {
                    mid = (int)Math.Floor((left + right) / 2);
                    if (arr[mid] == target)
                    {
                        targetIndex = mid;
                        break;
                    }
                    else if (target < arr[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            
            return targetIndex;
        }
    }
}
