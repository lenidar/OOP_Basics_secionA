using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            //method1();
            //Console.WriteLine("Main method!");

            //Console.WriteLine(method3());

            //if(method3())
            //{
            //    Console.WriteLine("method 3 has a value of true");
            //}    
            //else
            //{
            //    Console.WriteLine("method 3 has a value of false");
            //}

            //if(args.Length > 0)
            //{
            //    Console.WriteLine(args[0]);
            //}

            ////method2();

            //method5(5);

            //Console.WriteLine(method6().ToLower().ToUpper());

            //Console.WriteLine(method7(10, 11));

            //Console.WriteLine("The input number is {0}", getUserInputNumber());

            forLoop(0, 100);

            writeline("");

            forLoop(20, 50);

            Console.ReadKey();
        }

        #region Hello world
        /// <summary>
        /// This is the basic method
        /// </summary>
        static void method1()
        {
            Console.WriteLine("Hello world from method 1");
            int x = 0;
        }

        static void method2()
        {
            Console.WriteLine("Hello world from method 2");
            int x = 0;
            method2();
            Console.ReadKey();
        }

        static bool method3()
        {
            Console.WriteLine("method 3 - 1");
            Console.WriteLine("method 3 - 2");
            return false;
        }
        static bool method4()
        {
            bool something = false;

            return something;
        }

        static void method5(int x)
        {
            Console.WriteLine(x);
        }

        static string method6()
        {
            return "I am from method 6";
        }
        #endregion

        /// <summary>
        /// This method adds two numbers a and b
        /// </summary>
        /// <param name="a"> the first number </param>
        /// <param name="b"> the second number</param>
        /// <returns>the sum of a and b</returns>
        static int method7(int a, int b)
        {
            return a + b;
        }

        static int getUserInputNumber()
        {
            int num = 0;
            string uInput = "";
            bool isNum = false;

            Console.Clear();
            Console.Write("Please input a number : ");
            uInput = Console.ReadLine();
            isNum = int.TryParse(uInput, out num);
            if (!isNum)
            {
                Console.WriteLine("{0} is not a number... Press any key to continue...", uInput);
                Console.ReadKey();
                num = getUserInputNumber();
                //getUserInputNumber();
            }


            return num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        static void write(string message)
        {
            Console.Write(message);
        }

        static void writeline(string message)
        {
            write(message);
            write("\n");
        }

        static int forLoop(int curVal, int lastVal)
        {
            if (curVal < lastVal)
            {
                writeline("The current value is " + curVal + " and the target value is " + lastVal);
                //writeline("Adding 1 to " + curVal);
                curVal = forLoop(curVal + 1, lastVal);
            }

            return curVal;
        }
    }
}
