using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayFundamentals
{
    public class ArrayService
    {
        public int[] ReverseArray(int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                int tmp = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = tmp;
            }

            return a;
        }
    }
}
