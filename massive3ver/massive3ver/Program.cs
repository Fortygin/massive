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
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rdn.Next(100);
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }

        static string[] UniteTwoArraysOfStrings(string[] arr, string[] arr2)
        {

        }

        static void PrintMaxAndMinOfArray(int[] arr)
        {

        }

        static float AverageArithmetic(float[] arr)
        {

        }

        static int SearchIndexInMassive(string[] arr, string a)
        {

        }

        static List<int> GetUniqueElements(List<int> list)
        {

        }

        static bool CheckNumberInList(List<int> list, int number)
        {

        }




        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);

            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            FillIntArray(a);
            PrintArray(a);
            int[] array = new int[10];
            FillRandomIntArray(array);
            PrintArray(array);

        }
    }
}

    

