using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialArray.Collections
{
    public class ArrayActions
    {
        public static void Sort(SpecialArray array)
        {
            for (int index = array.Size() - 1; index > 0; index--)
            {
                if (array[0] > array[index])
                {
                    array.Swap(index);
                }
            }
        }
    }
}
