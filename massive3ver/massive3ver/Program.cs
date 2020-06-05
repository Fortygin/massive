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
                Console.WriteLine(arr[i]);
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
                }

        }
        static string[] UniteTwoArraysOfStrings(string[] arr, string[] arr2)
        {
            string[] c = new string[arr.Length + arr2.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                c[i] = arr[i];
            }
                
            for (int i = 0; i < arr2.Length; i++)
          
            {
                c[i + arr.Length] = arr2[i];
            }
    
            return c;
        }

        static void PrintMaxAndMinOfArray(int[] arr)
        {
            if (arr.Length == 0)
                Console.WriteLine("The Array is empty");

            else
            {
                int MaxValue = arr[0];
                int MinValue = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (MaxValue < arr[i])
                        MaxValue = arr[i];
                    if (MinValue > arr[i])
                        MinValue = arr[i];

                }

                Console.WriteLine("Max Value = {0}", MaxValue);

                Console.WriteLine("Min Value = {0}", MinValue);
            }
            

        }

        static float AverageArithmetic(float[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
           
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            float Average = sum / arr.Length;

            return Average;
        }

        static int SearchIndexInMassive(string[] arr, string a)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                   return i;
                
            }

            return -1;
        }




        static List<int> GetUniqueElements(List<int> list)
        {
          


            //int i = 0;
            //List<int> distinctElements = new List<int>();
            //while (i < list.Count)
            //{
            //    if (!distinctElements.Contains(list[i]))
            //        distinctElements.Add(list[i]);
            //    i++;
            //}
            //Console.WriteLine();
            //return distinctElements;
            //создать новый список и вернуть его
            

        }

        //static bool CheckNumberInList(List<int> list, int number)
        //{
        //   //то же самое что с индексом
        //    if ()
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
                    
                    Console.Write(arr[i, j] + "\t");

                }
        }
        static void Main(string[] args)
        {
            //int[] a = new int[10];
            //FillIntArray(a);
            //PrintArray(a);
            //int[] array = new int[10];
            //FillRandomIntArray(array);
            //PrintArray(array);
            //int[,] doubleArray = new int[10, 5];
            //FillRandomIntMatrixArray(doubleArray);
            //PrintDoubleArray(doubleArray);
            //Console.ReadKey();
            //int[][] notched = new int[10][];

            //for (int i = 0; i < notched.Length; i++)
            //{
            //    notched[i] = new int[10];

            //}
            //FillRandomIntNotchedArray(notched);
            //string[] array1 = { "Sun", "Mun" };
            //string[] array2 = { "Wen", "Ken" };
            //UniteTwoArraysOfStrings(array1, array2);
            //int[] IntArray = { 1, 0, -5, 66, 21 };
            //int[] intNull = { };
            //PrintMaxAndMinOfArray(IntArray);
            float[] ArrayFloat = { 30, 21, 11 };
            float[] ArrayZeroFloat = new float[0];
            AverageArithmetic(ArrayZeroFloat);
            Console.WriteLine(AverageArithmetic(ArrayZeroFloat));
            //Console.WriteLine(AverageArithmetic(ArrayFloat));
            //string[] cities = { "Chelyabinsk", "Moscow", "Novosibirsk" }; d
            //string city = "Moscow";
            //SearchIndexInMassive(cities, city);
            //List<int> numbers = new List<int> { 1, 2, 5, 2, 2, 1, 4 };
            //GetUniqueElements(numbers);
            //Console.WriteLine(GetUniqueElements(numbers));



            Console.ReadKey();

        }
    }
}

    

