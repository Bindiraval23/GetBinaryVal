using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBinaryNumber
{
    class Program
    {
        static List<int> binaryVal = new List<int>();
        static int num = 0;
        static void Main(string[] args)
        {
            callMasterFun();
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                callMasterFun();
            }
        }
        static void callMasterFun()
        {
            Console.WriteLine("\n");
            num = 0;
            binaryVal.Clear();
            getNumber(); // get number via user input
            GetBinaryVal(); // convert decimal number to binary

            Console.WriteLine("Binary Value: {0}", string.Join("", binaryVal));//print binary value
            Console.WriteLine("Maximum Consecutive 1's are: " + GetMaxConsecutiveOnes());
            Console.Write("\n Press 'esc' to exit the process...");
        }
        static void getNumber()
        {
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        static void GetBinaryVal()
        {
            while (num != 0)
            {
                if (num % 2 == 0)
                    binaryVal.Add(0);
                else
                    binaryVal.Add(1);

                num = (int)num / 2;
            }
            binaryVal.Reverse();
        }
        static int GetMaxConsecutiveOnes()
        {
            int count = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < binaryVal.Count; i++)
            {
                if (binaryVal[i] == 1)
                {
                    count++;
                    if (i == binaryVal.Count - 1)
                        numbers.Add(count);
                }
                else
                {
                    numbers.Add(count);
                    count = 0;
                }
            }
            int max = numbers.Max();
            return max;
        }

        static void doNothing()
        {
            //do nothing..
        }
    }
}
