using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10HomeworkExercises
{
    class One
    {
        public void SumAndAverage()
        {
            //#1 Console read input of numbers and break at empty. Print sum and average of sequence. 
            Console.WriteLine("Please enter positive integers on separate lines. Press enter when done.");
            List<int> numberList = new List<int>();
            string input = Console.ReadLine();

            while (input != string.Empty)
            {
                int number = -1;
                try
                {
                    number = int.Parse(input);
                    if (number < 0)
                    {
                        Console.WriteLine("Postive integers only!");
                    }
                    else
                    {
                        numberList.Add(number);
                        Console.WriteLine("Added!");
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("SUM: " + numberList.Sum());
            Console.WriteLine("AVERAGE: " + numberList.Average());
        }
    }
}
