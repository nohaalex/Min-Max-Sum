using System;
namespace MinMaxSum
    //Program to find the Minimum and Maximum Sum of elements in an array and display it as two space-separated integers.
{
    public class MinMaxSum 
        
    {
        public static void  Main(string[] args)
        {

            Console.WriteLine("Enter the length of the array:");
            int x=Convert.ToInt32(Console.ReadLine());

            int[] arr=new int[x];
            Console.WriteLine("\nThe Elements to be entered:");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe array is :");

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }  
            Array.Sort(arr);
            Console.WriteLine("\nThe sorted array in ascending order is:");
            for(int i=0; i<arr.Length ; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("\n");
            int SmallestSum = 0;
            for(int i=0 ; i<(arr.Length)-1 ; i++)
            {
                SmallestSum += arr[i];
                
            }
            Console.WriteLine("\n");
            int BiggestSum = 0;
            for(int i=1; i<arr.Length ; i++)
            {
            BiggestSum += arr[i];
            }
            Console.WriteLine("The Smallest and Biggest Sum is:{0} {1}",SmallestSum,BiggestSum);
        }

    }
   
}