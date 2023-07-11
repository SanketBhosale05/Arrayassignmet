///using System;
//using System.Data.SqlTypes;

//namespace _2DArray2
//{
//    internal class Program
//    {
//        static void main()
//        {


//            //int[,] matrix1 = new int[3, 3];
//            //int[,] matrix2 = new int[3, 3];
//            //int[,] resultMatrix = new int[3, 3];

//            //Console.WriteLine("Enter values for matrix1:");

//            //// Read values for matrix1
//            //for (int i = 0; i< 3; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        Console.Write("Enter value for element [{0},{1}]: ", i, j);
//            //        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
//            //    }
//            //}

//            //Console.WriteLine("\nEnter values for matrix2:");

//            //// Read values for matrix2
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        Console.Write("Enter value for element [{0},{1}]: ", i, j);
//            //        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
//            //    }
//            //}

//            //// Perform matrix addition
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
//            //    }
//            //}

//            //Console.WriteLine("\nMatrix Addition Result:");

//            //// Display the result
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 0; j < 3; j++)
//            //    {
//            //        Console.Write(resultMatrix[i, j] + "\t");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //WAP to search for a given number in an array and accordingly print the index if exists




//            //int[] Num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };

//            //Console.WriteLine(" enter the serach number");
//            //int searchNumber= int.Parse(Console.ReadLine());


//            //int index = Array.IndexOf(Num, searchNumber);

//            //if (index != -1) // index is not equal to -1 
//            //{
//            //    Console.WriteLine("num{0} found at index {0}", searchNumber,index);
//            //    // 
//            //}


//            //else
//            //    Console.WriteLine("num{0}not found in array ",searchNumber);







//            //WAP to print all negative elements in an array and also count total number of negative elements in an array.

//            //int[] Negativenum = {-1,-2,-3,-4,-5,-6,8,9,6,};


//            //int count = 0;
//            //Console.WriteLine("Negative elements:");
//            //foreach (int num in Negativenum)
//            //{
//            //    if (num < 0)
//            //    {
//            //        Console.WriteLine(num);
//            //    }
//            //}


//            //// count of negetive element 

//            //foreach (int num in Negativenum)
//            //    if ( num < 0)
//            //    {
//            //        count++;

//            //    }
//            //Console.WriteLine("THE TOTAL NEGAVTIVE ELEMENT:" + count);




//            Console.WriteLine("-------------------------------------------------");







//            // WAP to put even and odd elements of array in two separate arrays.
//            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, };

//            //int[] evenArray;
//            //int[] oddArray;
//            //int evenCount = 0;
//            //int oddCount = 0;

//            //// Count even and odd elements
//            //foreach (int num in array)
//            //{
//            //    if (num % 2 == 0)
//            //    {
//            //        evenCount++;
//            //    }
//            //    else
//            //    {
//            //        oddCount++;
//            //    }
//            //}

//            //// Initialize even and odd arrays
//            //evenArray = new int[evenCount];
//            //oddArray = new int[oddCount];

//            //// Populate even and odd arrays
//            //int evenIndex = 0;
//            //int oddIndex = 0;
//            //foreach (int num in array)
//            //{
//            //    if (num % 2 == 0)
//            //    {
//            //        evenArray[evenIndex] = num;
//            //        evenIndex++;
//            //    }
//            //    else
//            //    {
//            //        oddArray[oddIndex] = num;
//            //        oddIndex++;
//            //    }
//            //}

//            //// Print even array
//            //Console.WriteLine("Even elements:");
//            //foreach (int num in evenArray)
//            //{
//            //    Console.WriteLine(num);
//            //}

//            //// Print odd array
//            //Console.WriteLine("Odd elements:");
//            //foreach (int num in oddArray)
//            //{
//            //    Console.WriteLine(num);
//            //}


//            //WAP to find the maximum and minimum value in an array.
//            //    int[] numbers = { 5, 10, 3, 8, 1, 6 };

//            //    int minimum = numbers[0];
//            //    int maximum = numbers[0];

//            //    for (int i = 1; i < numbers.Length; i++)
//            //    {
//            //        if (numbers[i] < minimum)
//            //        {
//            //            minimum = numbers[i];
//            //        }

//            //        if (numbers[i] > maximum)
//            //        {
//            //            maximum = numbers[i];
//            //        }
//            //    }

//            //    Console.WriteLine("Minimum value: " + minimum);
//            //    Console.WriteLine("Maximum value: " + maximum);
//            //}

//            //WAP to find and count total number of duplicate elements in an array.






//            //int[] array = { 1, 2, 3, 4, 5, 2, 4, 6, 1, 3, 7, 8, 9, 5, 2 };

//            //Dictionary<int, int> elementCount = new Dictionary<int, int>();

//            //// Count the occurrences of each element
//            //foreach (int element in array)
//            //{
//            //    if (elementCount.ContainsKey(element))
//            //        elementCount[element]++;
//            //    else
//            //        elementCount[element] = 1;
//            //}

//            //int duplicateCount = 0;

//            //// Count the total number of duplicate elements
//            //foreach (var count in elementCount.Values)
//            //{
//            //    if (count > 1)
//            //        duplicateCount++;
//            //}

//            //    Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
//            //}

//            //  WAP to print all unique elements in the array.
//            // int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 19, 20, 21, 22, 23 };
//            //int[] uniqueElement;

//            // int[] Element = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13 };
//            //// int[] uniqueElement = { };
//            // //foreach (int item in Element)
//            //// {
//            //     uniqueElement[item] = item;
//            // //}
//            // // print unique element 
//            // Console.WriteLine("unique elemnt in array");

//            // foreach (int item in uniqueElement)
//            // {
//            //     Console.WriteLine(Element);
//            // }



//            //1. WAP to replace all negative value with its immediate left elements square. Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
//            //Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].

//           // Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9];
//            int[]array = new int[] {12,3,-19,29,5,-61,-44,7,-9};
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i]< 0)
//                {
//                    int a = i - 3;
//                    array[i] = array[a] * array[a];
//                }
//            }
//            foreach
//                (int i in array)
//            {
//                Console.WriteLine(i);
//            }   
            

           
            
            

            





//        }
//    }
//}

    




   



































