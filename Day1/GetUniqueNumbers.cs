using System;
using System.Collections.Generic;

namespace Day1
{
    public class GetUniqueNumbers
    {
        public GetUniqueNumbers()
        {
        }

        // return non-duplicate elements, keeping only first occurrence
        public static List<int> GetUniqueNumbersArr(int[] arr)
        {
            List<int> ans = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ans.Contains(arr[i]))
                {
                    ans.Add(arr[i]);
                }
            }

            return ans;
        }
    }
}
