using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class BubbleSort
    {
        public List<int> doSorting(List<int> list) {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-i-1; j++)
                {
                    if (list[j]>list[j+1])
                    {
                        Program.swap(list,j,j+1);
                    }
                }
            }
            return list;
        }
    }
}
