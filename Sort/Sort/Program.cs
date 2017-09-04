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
            Console.WriteLine("Enter number corresspoding to sorting method to be used:\n1)Selection Sort\n2)Bubble Sort\n3)Insertion Sort\n4)Quick Sort\n5)Merge Sort\n");
            int choice = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter the emelements of the list: ");
            bool validInput = false;
            while (!validInput)
            {
                string str = Console.ReadLine();
                validInput=parser(str,ref list);
            }

            switch (choice)
            {
                case 1:
                    SelectionSort selectionSort = new SelectionSort();
                    list = selectionSort.doSorting(list);
                    break;
                case 2:
                    BubbleSort bubbleSort = new BubbleSort();
                    list = bubbleSort.doSorting(list);
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    list = insertionSort.doSorting(list);
                    break;
                case 4:
                    QuickSort quickSort = new QuickSort();
                    quickSort.doSorting(list);
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.doSorting(list);
                    break;
                default:
                    break;
            }

            Console.Write("Sorted List :");

            foreach (int item in list)
            {
                Console.Write("{0} ",item);
            }

            Console.ReadKey();

        }
    }
}
