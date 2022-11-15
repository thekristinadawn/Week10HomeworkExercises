using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10HomeworkExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 Console read input of numbers and break at empty. Print sum and average of sequence. 

            //List<int> numbers = new List<int>();
            //while (true) //while(input != string.Empty)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input < 0)
            //    {
            //        break;
            //    }
            //    if (input == int.Empty)
            //    {
            //        break;
            //    }
            //    numbers.Add(input);
            //}
            //fills a list called numbers until user enters " -1 "

            List<int> numbers = new List<int>();
            bool inputNum;
            int number;
            string input = Console.ReadLine();
            inputNum = int.TryParse(input, out number);
            while (input != string.Empty)

            {
                {

                    if (number < 0)
                    {
                        break;
                    }
                    numbers.Add(number);

                }
            }

            Console.WriteLine(number);
            Console.WriteLine("numbers" + numbers);




        }
    }
}
