using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first C# project");
            // All your code writing happens here

            // BASIC 13
            // Print1to255();
            // PrintSum();
            int[] myarray = {2,-46,7,-4,-25,7};
            // printArray(myarray);
            List<int> myList = new List<int>(){3,5,76,7,2,6};
            int num = 8;
            // printList(myList);
            dojoReplace(myarray);
        }

        public static void Print1to255()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <=255; i++){
                Console.WriteLine(i);
                sum+=i;
                Console.WriteLine(sum);
            }
        }

        public static void printArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void printList(List<int> listArr)
        {
            for(int i = 0; i < listArr.Count; i++)
            {
                Console.WriteLine(listArr[i]);
            }
        }

        public static object[] dojoReplace(int[] arr)
        {
            // we need to convert our int array into an object array
            object[] newArray = new object[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    newArray[i] = "dojo";
                } else {
                    newArray[i] = arr[i];
                }
            }
            foreach(var j in newArray)
            {
                Console.WriteLine(j);
            }
            return newArray;
        }

    }
}
