using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class SelectionSort
    {
        int findMinIndex(List<int> list,int begining)
        {
            int min = list[begining];
            int minIndex = begining;
            for (int i = begining+1; i < list.Count; i++)
            {
                if (min>list[i])
                {
                    min = list[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        

        //The selection sort algorithm sorts an array by repeatedly finding the minimum element(considering ascending order) 
        //from unsorted part and putting it at the beginning
        public List<int> doSorting(List<int> list) {
            for (int i = 0; i < list.Count; i++)
            {
                int minIndex = findMinIndex(list,i);
                Program.swap(list,i,minIndex);
            }
            return list;
        }
    }
}
