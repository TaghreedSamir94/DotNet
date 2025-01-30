using System.Collections;

namespace AssignmentDay_1
{
    internal class Program
    {
        #region Q3
        public static void ReverseArrList(ArrayList list)
        {
            int n = list.Count;
            for (int i = 0; i < n / 2; i++)
            {
                object Temp = list[i];
                list[i] = list[n - i - 1];
                list[n - i - 1] = Temp;
            }
        }
        #endregion

        #region Q4
        public static List<int> EvenList(List<int> list)
        {
            int n = list.Count;
            List<int> evenlist = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenlist.Add(list[i]);
                }

            }
            return evenlist;
        }
        #endregion

        #region Q6
        public static int FindFirstChar(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string lowerStr = str.ToLower();

            foreach (char c in lowerStr)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }

            }
            for (int i = 0; i < str.Length; i++)
            {
                if (dict[lowerStr[i]] == 1)
                {
                    return i;
                }

            }
            return -1;
        } 
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*1.The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm 
              And implement the code of this optimised bubble sort algorithm*/

            ////We can optimize buble sort Algorithim by
            ////1. early trimnate if list is already sorted by add Flag to check if Swapped accure or not
            ////2. reduce number of comparison as we dont need to compare the last (i) elements as it sorted and be in correct position after each iteration by add in inner loop (j-i-1)

            //int[] Arr = { 100, 12, 25, 6, 85, 0, 46 };
            //Console.WriteLine("Original array:");
            //Helper.PrintArray(Arr);
            //Q1.OptimizedBubbleSort(Arr);
            //Console.WriteLine("Sorted array:");
            //Helper.PrintArray(Arr);

            //int[] Arr = { 100, 150, 175, 200, 225, 250, 300 };
            //Console.WriteLine("Original array:");
            //Helper.PrintArray(Arr);
            //Q1.OptimizedBubbleSort(Arr);
            //Console.WriteLine("Sorted array:");
            //Helper.PrintArray(Arr);
            #endregion

            #region Q2
            /*2.create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            Requirements:
            1.	Create a generic class named Range<T> where T represents the type of values.
            2.	Implement a constructor that takes the minimum and maximum values to define the range.
            3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
            */

            //Range<int> range = new Range<int>(10,50);
            //Console.WriteLine(range.ToString());
            //Console.WriteLine(range.IsInRange(70));
            //Console.WriteLine($"Length:{range.Length()}");
            #endregion

            #region Q3
            /*3.You are given an ArrayList containing a sequence of elements.
             * try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without
             * using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies 
             * it to have the reversed order of elements.*/

            //ArrayList list = new ArrayList{ 5,2, true, 8,"Ahmed"};
            //Console.Write($"Original ArrayList: ");
            //Helper.PrintArray(list.ToArray());

            //ReverseArrList(list);

            //Console.Write($"Reversed ArrayList: ");
            //Helper.PrintArray(list.ToArray());

            #endregion

            #region Q4
            /*4.You are given a list of integers. Your task is to find and return a new list containing only 
             * the even numbers from the given list.*/

            //List<int> list = [1, 2, 3, 25 ,4, 8, 22, 61, 100, 99];
            //List<int> evenList =  EvenList(list);
            //Console.Write("EvenList only :");
            //Helper.PrintArray(evenList.ToArray());

            #endregion

            #region Q5
            /*5.implement a custom list called FixedSizeList<T> with a predetermined capacity. 
             * This list should not allow more elements than its capacity and should provide clear
             * messages if one tries to exceed it or access invalid indices.
            Requirements:
            1.	Create a generic class named FixedSizeList<T>.
            2.	Implement a constructor that takes the fixed capacity of the list as a parameter.
            3.	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            4.	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
            */

            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.AddList(3);
            //list.AddList(4);
            //list.AddList(5);
            //// list.AddList(6); // throw exception

            //Console.WriteLine($"index 0 is {list.Get(0)}");
            // Console.WriteLine($"index 1 is {list.Get(1)}");
            //// Console.WriteLine($"index 5 is {list.Get(5)}");// Invalid index
            #endregion

            #region Q6
            /*6.Given a string, find the first non-repeated character in it and return its index. 
             * If there is no such character, return -1. Hint you can use dictionary */

            //Console.Write("Entter a String: ");
            //string input = Console.ReadLine();
            //int index = FindFirstChar(input);
            //Console.WriteLine($"Non repeated Charcter in index: {index}");

            #endregion

        }
    }
}
