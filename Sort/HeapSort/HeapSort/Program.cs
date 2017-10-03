
// heap sort using array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        public int[] array { get; set; }
        public int arraySize { get; set; }

        public void heapify(int index)
        {
            int length = array.Length;
            int largest = index;
            int l = 2 * index + 1;
            int r = 2 * index + 2;
       
            // set largest to largest among left, righ, root
            if(l<arraySize)
                largest= array[largest] < array[l] ? l :largest;
            if(r<arraySize)
                largest = array[largest] < array[r] ? r : largest;
            if (largest!=index)
            {
                //swap largest with item at index
                swap(index,largest);
                // recursively heapify on affected side
                heapify(largest);
            }
        }

        public void buildHeap()
        {
            // Half of the elements are at leaf nodes so we need to hepify only half of the array
            for (int i = arraySize/2; i >=0; i--)
            {
                heapify(i);
            }
        }

        public void heapSort()
        {
            int length = arraySize - 1;
            buildHeap();
            for (int i = length; i >=0; i--)
            {
                swap(0, i);
                arraySize--;
                heapify(0);
            }
        }

        private void swap(int index, int largest)
        {
            int temp = array[index];
            array[index] = array[largest];
            array[largest] = temp;
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 7, 2, 0, 9 };
            Program proObj = new Program();
            proObj.array = arr;
            proObj.arraySize = arr.Length;
            proObj.heapSort();
            foreach (var item in proObj.array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
