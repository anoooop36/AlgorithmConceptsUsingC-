using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class MergeSort
    {
        void merge(ref List<int> list,int l,int r,int mid) {
            List<int> rightList=new List<int>();
            List<int> leftList = new List<int>( list.GetRange(l,mid-l+1));
            if(mid + 1<=r)
                rightList = new List<int>( list.GetRange(mid+1,r-mid));
            int p = 0, q = 0;
            for (int i = l; i < r+1; i++)
            {
                if (p < leftList.Count && q < rightList.Count && leftList[p] <= rightList[q])
                {
                    list[i] = leftList[p];
                    p++;
                }
                else if (p < leftList.Count && q < rightList.Count && leftList[p] > rightList[q])
                {
                    list[i] = rightList[q];
                    q++;
                }
                else if (p >= leftList.Count && q < rightList.Count) {
                    while (q<rightList.Count)
                    {
                        list[i] = rightList[q];
                        i++;
                        q++;
                    }
                }
                else
                {
                    while (p < leftList.Count)
                    {
                        list[i] = leftList[p];
                        i++;
                        p++;
                    }
                }
            }

        }

        void mergeSort(ref List<int> list,int l,int r) {
            if (l<r)
            {
                int mid = (l+r) / 2;
                mergeSort(ref list, l, mid);
                mergeSort(ref list,mid+1,r);
                merge(ref list,l,r,mid);
            }
        }

        public List<int> doSorting(List<int> list) {
            mergeSort(ref list,0,list.Count-1);
            return list;
        }
    }
}
