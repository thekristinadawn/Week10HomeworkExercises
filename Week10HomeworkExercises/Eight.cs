using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10HomeworkExercises
{
    class Eight
    {

        //#8
        //The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. 
        //Write a program that finds the majorant of given array and prints it. If it does not exist, print "The majorant does not exist!".

        public void Majorant()
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int arrayLength = array.Length;
            int countMax = 0;
            int index = -1;
            for (int i = 0; i < arrayLength; i++)
            {
                int numCount = 0;
                for(int j = 0; j < arrayLength; j++)
                {
                    if (array[i] == array[j])
                        numCount++;
                }

                if (numCount > countMax)
                {
                countMax = numCount;
                index = i;
                }

            if (countMax > arrayLength / 2)
                Console.WriteLine(array[index]);
            else
                Console.WriteLine("The majorant does not exist!");
                
            }
        }

    }
}
