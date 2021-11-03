using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concept_practicing_with_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager printManager = new PrintManager();
            ArrayManager arrayManager = new ArrayManager();

            arrayManager.Array = arrayManager.Create();
            printManager.Print(arrayManager.Array);
            Console.WriteLine(new string('-', 30));
            //Assigning hew height and width to the array
            arrayManager.ArrayHeight = 4;
            arrayManager.ArrayWidth = 4;
            //Before new array setup
            printManager.Print(arrayManager.Array);
            //After new array setup
            arrayManager.Array = arrayManager.Create();
            Console.WriteLine(new string('-', 30));
            printManager.Print(arrayManager.Array);
            Console.WriteLine(new string('-', 10));
            printManager.Print(arrayManager.GetDiagonal());

            Console.ReadKey();
        }
    }

    class ArrayManager
    {
        private int[,] array;
        private int[] arr;
        private int arrayHeight = 5, arrayWidth = 5, arrayMinSize = -15, arrayMaxSize = 3;
        //Properties of array, arrayHeight, arrayWidth, arrayMinSize, arrayMaxSize fields
        public int [,] Array
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }
        public int[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = GetDiagonal();
            }
        }
        public int ArrayHeight
        {
            get
            {
                return arrayHeight;
            }
            set
            {
                arrayHeight = value;
            }
        }
        public int ArrayWidth
        {
            get
            {
                return arrayWidth;
            }
            set
            {
                arrayWidth = value;
            }
        }
        public int ArrayMinSize
        {
            get
            {
                return arrayMinSize;
            }
            set
            {
                arrayMinSize = value;
            }
        }
        public int ArrayMaxSize
        {
            get
            {
                return arrayMaxSize;
            }
            set
            {
                arrayMaxSize = value;
            }
        }
        ///<summary>
        ///Randomly generates two dimenional array.
        ///</summary>
        ///<returns>Returns two dimensional array.</returns>
        public int[,] Create()
        {
            Random random = new Random();
            int[,] array = new int[ArrayHeight, ArrayWidth];

            for (int i = 0; i < ArrayHeight; i++)
            {
                for (int j = 0; j < ArrayWidth; j++)
                {
                    array[i, j] = random.Next(ArrayMinSize, ArrayMaxSize);
                }
            }
            return array;
        }
        ///<summary>
        ///Puts diagonal elements into an array.
        ///</summary>
        ///<returns>Returns a single dimensional array.</returns>
        public int[] GetDiagonal()
        {
            int arrayLength = Array.GetLength(0);
            arr = new int[arrayLength];
            if (ArrayWidth == ArrayHeight)
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    arr[i] = Array[i, i];
                }
                return arr;
            }
            throw new Exception("Can't get diagonal from not normally sized array"); 
        }
                ///<summary>
        ///Finds the max value in the given array.
        ///</summary>
        ///<param name="array">An input array to get the max value from.</param>
        ///<returns>Returns the max value of the array.</returns>
        public static int GetMaxOfArray()
        {
            int max = Arr[0];

            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return max;
        }
    }

    class PrintManager
    {
        ///<summary>
        ///Prints the given message having the given value included.
        ///</summary>
        ///<param name="message">The word or sentence to be printed.</param>
        ///<param name="value">The value that should to be printed.</param>
        public void Print(String message, int value)
        {
            Console.WriteLine($"{message} {value}.");
        }
        ///<summary>
        ///Prints the given array.
        ///</summary>
        ///<param name="array">The array that's goig to be printed.</param>
        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        ///<summary>
        ///Prints the given two dimensional array.
        ///</summary>
        ///<param name="array">The two dimensional array that's going to be printed.</param>
        public void Print(int[,] array)
        {
            int arrayLength = array.GetLength(0);
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
