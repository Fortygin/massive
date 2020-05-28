using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive3ver
{
    class Program
    {


        static void FillIntArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;

            }

        }

        static void FillRandomIntArray(int[] arr)
        {
            Random rdn = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rdn.Next();
            }

        }

        static void FillRandomIntMatrixArray(int[,] arr)
        {

            Random rdn = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdn.Next();
                }
  
        }

        static void FillRandomIntNotchedArray(int[][] arr)
        {

            Random rdn = new Random();
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rdn.Next();
                    Console.WriteLine(arr[i][j] + " ");
                }

        }
        static string[] UniteTwoArraysOfStrings(string[] arr, string[] arr2)
        {
            string[] c = new string[arr2.Length];

            for (int i = 0; i < arr2.Length; i++)
                if (i < arr.Length)
                    c[i] = arr[i] + arr2[i];
                else
                    c[i] = arr2[i];
            Array.ForEach(c, x => Console.Write(x + " "));
            Console.ReadKey(true);



            return c;
        }

        static void PrintMaxAndMinOfArray(int[] arr)
        {
            int MaxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (MaxValue < arr[i])
                {
                    MaxValue = arr[i];
                }
            }

            Console.WriteLine("Max Value = {0}", MaxValue);

            int MinValue = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {
                if(MinValue > arr[j])
                {
                    MinValue = arr[j];
                }
                    
            }
            Console.WriteLine("Min Value = {0}", MinValue);

        }

        static float AverageArithmetic(float[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            float Average = sum / arr.Length;

            Console.WriteLine(Average);
            return Average;
        }

        //static int SearchIndexInMassive(string[] arr, string a)
        //{

        //}

        //static List<int> GetUniqueElements(List<int> list)
        //{

        //}

        //static bool CheckNumberInList(List<int> list, int number)
        //{

        //}




        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);

            }
            Console.ReadLine();
        }

        static void PrintDoubleArray(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    Console.Write(arr[i, j] + " ");

                }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            FillIntArray(a);
            PrintArray(a);
            int[] array = new int[10];
            FillRandomIntArray(array);
            PrintArray(array);
            int[,] doubleArray = new int[10, 5];
            FillRandomIntMatrixArray(doubleArray);
            PrintDoubleArray(doubleArray);
            Console.ReadKey();
            int[][] notched = new int[10][];

            for (int i = 0; i < notched.Length; i++)
            {
                notched[i] = new int[10];

            }
            FillRandomIntNotchedArray(notched);
            string[] array1 = { "Sun", "Mun" };
            string[] array2 = { "Wen", "Ken" };
            UniteTwoArraysOfStrings(array1, array2);
            int[] IntArray = { 1, 0, -5, 66, 21 };
            PrintMaxAndMinOfArray(IntArray);
            float[] ArrayFloat = {30, 21, 11};
            AverageArithmetic(ArrayFloat);
            

            Console.ReadKey();

        }
    }
}

    

