using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public class Program
    {
        static bool parser(string str,ref List<int> list)
        {
            try
            {
                list = str.Split(' ').Select(int.Parse).ToList();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Not all list elements are integers! Re-enter list");
            }
            return false;
        }

        public static void swap(List<int> list, int index1, int index2)
        {
            int temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter the emelements of the list: ");
            bool validInput = false;
            while (!validInput)
            {
                string str = Console.ReadLine();
                validInput=parser(str,ref list);
            }
            
           // list = str.Split(' ').Select(Int32.Parse).ToList();

            //SelectionSort selectionSort = new SelectionSort();
            //list = selectionSort.doSorting(list);
            //BubbleSort bubbleSort = new BubbleSort();
            //list = bubbleSort.doSorting(list);
            //InsertionSort insertionSort = new InsertionSort();
            //list=insertionSort.doSorting(list);
            //QuickSort quickSort = new QuickSort();
            //quickSort.doSorting(list);

            MergeSort mergeSort = new MergeSort();
            mergeSort.doSorting(list);

            Console.Write("Sorted List :");

            foreach (int item in list)
            {
                Console.Write("{0} ",item);
            }

            Console.ReadKey();

        }
    }
}
