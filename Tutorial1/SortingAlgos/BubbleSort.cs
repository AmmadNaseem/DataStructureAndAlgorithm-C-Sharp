using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.SortingAlgos
{
    public class BubbleSort
    {
        public void SortArray(int[] unsortArr)
        {
            Console.WriteLine("*************Bubble Sort|***********");
            Console.Write("Unsorted Values are:");

            foreach (var item in unsortArr)
            {
                Console.Write(item+",");
            }


            int temp =0;

            for (int i = 0; i < unsortArr.Length-1; i++)
            {
                for (int j = i+1; j <unsortArr.Length ; j++)
                {
                    if (unsortArr[i] > unsortArr[j])
                    {
                        temp = unsortArr[i];
                        unsortArr[i] = unsortArr[j];
                        unsortArr[j]=temp;

                    }
                }

            }
            Console.Write("\nSorted Values are:");
            foreach (var item in unsortArr)
            {
                Console.Write(item + ",");
            }

        }

        public int[] PerforBubbleSort(int[] array)
        {
            //hold temporary swap vaiable. think state
            int temp = 0;
            //iterates over entire loop Many times
            for (int pointer = 0; pointer < array.Length; pointer++)
            {
                //forms the "box" that does the comparsion
                for (int sort = 0; sort < array.Length-1; sort++)
                {
                    if (array[sort] > array[sort+1])
                    {
                        //swap: we store vaiable as tmep so we don't overwrite it when we swap
                        temp = array[sort + 1];
                        //put left variable in the right
                        array[sort+1] = array[sort];
                        //put the right variable in the left
                        array[sort] = temp;
                    }

                }
            }
         return array;
        }
    }
}
