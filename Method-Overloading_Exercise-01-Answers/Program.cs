using System;
using System.Collections.Generic;

namespace Method_Overloading_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            //// TODO: Call each of the overloads here (pass in the values directly)
            //PrintItems(10); // int
            //PrintItems(1, 2, 3, 4, 5); // params int[]
            //PrintItems(.222); // double
            //PrintItems(.1, .2, .3); // params double[]
            //PrintItems(72.278264262678M); // decimal
            //PrintItems(72.2788M, 120.34543M, 12.111111384900099M); // params decimal[]
            //PrintItems(true);// bool
            //PrintItems(true, false, true, false, false, true); // params bool[]
            //PrintItems("A string argument"); // string
            //PrintItems("Multiple", "string", "arguments"); // params string[]
            //PrintItems('A'); // char 
            //PrintItems('a', '%', 'Y', 'j', 'E', '&'); // char[]
            //PrintItems(.1f); // float
            //PrintItems(.1f, .2f, .3f, 4f); // params float[]
            //PrintItems(121242L); // long
            //PrintItems(1L, 2L, 3L, 4L, 38478748349283982L); // params long[]

            // Bonus
            // TODO: Call the PrintItems overload and pass in a System.Object as an argument
            PrintItems(new System.Object()); // object

            // Note: for the params object[] overloads you might need to create 3 objects then pass those variables into the method as the arguments

            // Example 1:
            var str = "Hello World!";
            var num1 = 27;
            var symbol1 = '$';            
            PrintItems(str, num1, symbol1);



            // Example 2:
            var arr = new int[] { 1, 2, 3 };
            var arr1 = new double[] { .1, .2, .3 };
            var arr2 = new float[] { .1f, .2f, .3f };
            PrintItems(arr, arr1, arr2);
        }

        // TODO: Create a method called PrintItems
        // TODO: Make the method public 
        // TODO: Make the method static
        // TODO: Make the return type void
        // TODO: Make the parameter of type int
        // TODO: Make the method print out what's passed in to the console
        public static void PrintItems(int item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create an overload for PrintItems that prints out ANY amount of integers passed in to the function as arguments
        public static void PrintItems(params int[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() double overload
        public static void PrintItems(double item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() double overload that prints out ANY amount of doubles passed in to the function as arguments
        public static void PrintItems(params double[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() decimal overload
        public static void PrintItems(decimal item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() decimal overload that prints out ANY amount of decimals passed in to the function as arguments
        public static void PrintItems(params decimal[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() bool overload
        public static void PrintItems(bool item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() bool overload that prints out ANY amount of bools passed in to the function as arguments
        public static void PrintItems(params bool[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() string overload
        public static void PrintItems(string item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() string overload that prints out ANY amount of strings passed in to the function as arguments
        public static void PrintItems(params string[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() char overload
        public static void PrintItems(char item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() char overload that prints out ANY amount of chars passed in to the function as arguments
        public static void PrintItems(params char[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() float overload
        public static void PrintItems(float item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() float overload that prints out ANY amount of floats passed in to the function as arguments
        public static void PrintItems(params float[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        // TODO: Create a PrintItems() long overload
        public static void PrintItems(long item)
        {
            Console.WriteLine(item);
        }



        // TODO: Create a PrintItems() long overload that prints out ANY amount of longs passed in to the function as arguments
        public static void PrintItems(params long[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }





        // BONUS

        // TODO: Create a PrintItems() object overload
        public static void PrintItems(object item)
        {
            Console.WriteLine(item.ToString());
        }




        // TODO: Create a PrintItems() object overload that prints out ANY amount of objects passed in to the function as arguments
        public static void PrintItems(params object[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
