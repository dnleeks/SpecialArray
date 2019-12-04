using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialArray.Collections
{
    public class ArrayActions
    {
        public static void Sort(SpecialArray array)
        {
            if (array == null)
            {
                throw new ArgumentException("Cannot sort a null SpecialArray");
            }

            for (int index = array.Size() - 1; index > 0; index--)
            {
                for (int subIndex = index - 1; subIndex > 0; subIndex--)
                {
                    if (array[0] > array[index])
                    {
                        array.Swap(index);
                    }
                }
            }
        }
    }
}
