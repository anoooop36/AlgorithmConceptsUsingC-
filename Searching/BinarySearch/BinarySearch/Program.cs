//Search a element x in given List(list must be sorted) using binary search. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace BinarySearch
{
    class Binary
    {

        static public List<int> SortedList { get; set; }

        // returns index of key from List
        static int BinarySearchFunc(int key, int begin, int end) {
            if (begin <= end) {
                int mid = (begin + end) / 2;
                if (SortedList[mid] == key)
                {
                    return mid;
                }
                else if (SortedList[mid] > key)
                {
                    return BinarySearchFunc(key, begin, mid - 1);
                }
                else if (SortedList[mid] < key)
                {
                    return BinarySearchFunc(key, mid + 1, end);
                }
            }
            return -1;
        }

        static bool parser(string [] str) {
            try
            {
                SortedList = str.Select(int.Parse).ToList();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Not all list elements are integers! Re-enter list");
            }
            return false;
        }

        static bool parserInt(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Key must be integer ! Re-enter key");
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.Write("Give a sorted list of numbers: ");
           
            bool valid = false;
            while (!valid)
            {
                string[] str = Console.ReadLine().Split(" ");
                valid=parser(str);
            }
            
            int key;
            string s="";
            valid = false;
            while (!valid)
            {
                Console.Write("Enter key to search: ");
                s = Console.ReadLine();
                valid = parserInt(s);
            }
            key = Int32.Parse(s);

            SortList sortListClass = new SortList();
            SortedList = sortListClass.sort(SortedList);

            Console.WriteLine("{0} is found at Index {1}",key,BinarySearchFunc(key,0,SortedList.Count-1));

            
            //foreach (var item in SortedList)
            //{
            //    Console.Write("{0} ",item);
            //}
            Console.ReadKey();
        }
    }
}
