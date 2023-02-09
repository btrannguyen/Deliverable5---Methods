/*
 * Author: Tran Nguyen
 * Date: 2/9/2023
 * Description: Using C# Console Application to demonstrate Methods
 */

using System;

namespace Deliverable5___Methods
{
    class Program
    {
        static int[] randomArray(int array_len)
        {
            Random random = new Random();
            int[] myArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                myArray[i] = random.Next(10,50); 
            }
            return myArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Boolean done = false;
            while (!done)
            {
                try
                {                    
                        Console.WriteLine("Enter an integer number between 5 and 15");
                        int input = int.Parse(Console.ReadLine());
                        if (input >= 5 && input <= 15)
                        {
                            int[] sampleArray = randomArray(input); //reference to method randomArray
                            Console.WriteLine("The elements of the arrays are: ");
                            foreach (int element in sampleArray)
                            {
                                Console.WriteLine(element);
                            }
                            Console.WriteLine("The sum is: " + sum(sampleArray));
                        }                    
                }
                catch
                {
                    Console.WriteLine("Please enter an interger");
                }
                   
            }
            
            
        }
    }
}