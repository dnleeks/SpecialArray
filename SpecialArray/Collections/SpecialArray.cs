using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace SpecialArray.Collections
{
    public class SpecialArray
    {
        private List<int> items;

        private SpecialArray(List<int> input)
        {
            items = new List<int>(input);
        }

        public static SpecialArray From(List<int> input)
        {
            return new SpecialArray(input);
        }

        public int this[int index]
        {
            get => items[index];
        }

        public int Size()
        {
            return items.Count;
        }

        public void Swap(int index)
        {
            int swap = items[0];

            items[0] = items[index];
            items[index] = swap;
        }
    }
}
