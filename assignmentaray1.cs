using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray2
{
    internal class assignmentaray1
    {
        static void Main(string[] args)
        {
            //1. WAP to replace all negative value with its immediate left elements square. Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
            //Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].

            // Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9];
            //int[] array = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)// get negavtive number
            //    {
            //        int a = i - 1;// for pre index
            //        array[i] = array[a] * array[a];// squre of prev index
            //    }
            //    Console.WriteLine(array[i]);
            //}


            //ind pair of elements in array whose number is given number.
            //  e.g.Given array is { 4, 5, 7, 1, 2, 3, 0 } If number given is 7.Then pairs whose sum is equal to given
            //number are – (4, 3)(5, 2)(7, 0)


            //int[] array = { 4, 5, 7, 1, 2, 3, 0, 4, 5, 6, 7, };
            //Console.WriteLine("enter your number ");
            //int num =Convert.ToInt32(Console.ReadLine());
            
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 1; j < array.Length-1; j++)
            //    {
            //        int sum= array[i]+ array[j];
            //       if (array[i]+ array[j] == num)
            //        {
            //            Console.WriteLine($"addition pair {(array[i], array[j])}");
            //        }
                   
            //    }
            //}


            //Move zeros to beginning or end of array. 
            // e.g. if given array is { 2, 10, 0, 5, 3, 0, 4, 1 } then output array should be
            //a. { 0,0,2,10,5,3,4,1}
            // b. { 2,10,5,3,4,1,0,0}
            int[] array = { 2, 10, 0, 5, 3, 0, 4,1 };
           
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    int c = 0;
                    if (array[j] == 0)
                    {
                        c = array[i];
                        array[i] = array[j];
                        array[j] = c;
                    }
                       
                    

                }
              
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }








        }
    }
}
