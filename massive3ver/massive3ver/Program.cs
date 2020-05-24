using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive3ver
{
    class Program
    {
        static void IntArray(int[] arr)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void RandomArray(int[] arr)
        {
            Random rdn = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rdn.Next();
            }

        }

        static void RandomArrayTwoMassive(int[,] arr)
        {
            int[,] array = new int[5, 10];
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
       

        static void Main(string[] args)
        {
          
            Console.ReadLine();
        }
    }
}

    

