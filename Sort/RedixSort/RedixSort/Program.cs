using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedixSort
{
    class Program
    {
        public List<int> arrayList { get; set; }
        public int arraySize { get; set; }

        public  void  countSort(int positionalExp)
        {
            List<int> outputList = new List<int>(arrayList);
            int[] frequencyCountArray = new int[10];
            foreach (var number in arrayList)
            {
                frequencyCountArray[(number/positionalExp)%10]++;
            }

            //comulative frequency to have actual position
            for (int i = 1; i < 10; i++)
            {
                frequencyCountArray[i] += frequencyCountArray[i - 1];
            }

            //foreach (var item in frequencyCountArray)
            //{
            //    Console.WriteLine(item);
            //}

            //reverse string
            arrayList.Reverse();

            foreach (var item in arrayList)
            {
                outputList[--frequencyCountArray[(item / positionalExp) % 10]] = item;
            }

            arrayList = outputList;
            
        }

        public  void redixSort(int maxValue)
        {
            
            for (int positonalExp = 1; maxValue/positonalExp > 0; positonalExp*=10)
            {
                countSort(positonalExp);
            }
        }

        static void Main(string[] args)
        {
            Program proObj = new Program();
            proObj.arrayList =new List<int>{23,3,44,13,1,200,111,211,9000,2901};
            int maxValue = proObj.arrayList.Max();
            proObj.redixSort(maxValue);
            foreach (var item in proObj.arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
