﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class SortList
    {
        //SORT LIST USING QUICKSORT

         int Partition(ref List<int> list,int firstIndex, int lastIndex) {
            int pivotElement = list[lastIndex];
            int i = firstIndex-1;
   
            // iterate through each element . if element is smaller swap it with next element to ith element
            for (int j = firstIndex; j < lastIndex ; j++) {
                if (list[j] < pivotElement)
                {
                    i++;
                    // swap arr[i] and arr[j]
                    int t = list[i];
                    list[i] = list[j];
                    list[j] = t;
                    
                }
            }
            //swap i+1 th with lastIndex

            int temp = list[i + 1];
            list[i + 1] = list[lastIndex];
            list[lastIndex] = temp;

            return (i + 1);
        }

         void QuickSort(ref List<int> list, int firstIndex, int lastIndex)
        {
            if (firstIndex<lastIndex)
            {
                int pi = Partition(ref list, firstIndex, lastIndex);
                QuickSort(ref list,firstIndex,pi-1);
                QuickSort(ref list, pi + 1, lastIndex);
            }
        }

        public List<int> sort(List<int> list) {
            QuickSort(ref list, 0, list.Count - 1);
            return list;
        }
    }
}
