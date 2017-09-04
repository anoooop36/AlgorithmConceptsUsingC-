using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class InsertionSort
    {
        public List<int> doSorting(List<int> list) {
            for (int i = 1; i < list.Count; i++)
            {
                int currentElement = list[i];
                int j=i-1;
                while (j >= 0 && list[j]>currentElement)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j+1] = currentElement;

            }
            return list;
        }
    }
}
