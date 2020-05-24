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

       

        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}

    

