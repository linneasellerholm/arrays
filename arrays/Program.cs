using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //Övning 1
            string[] namn = new string[10];

            for (int i = 0; i < namn.Length; i++)
            {
                Console.Write("Mata in ett namn: ");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0; i < namn.Length; i++)
            {
                Console.Write(namn[i] + ", ");
            }
            Console.WriteLine("");
            
            //Övning 2
            string[] nummer = new string[10];

            for (int i = 0; i < nummer.Length; i++)
            {
                Console.Write("Mata in ett nummer: ");
                nummer[i] = Console.ReadLine();
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(nummer[i] + " ");
            }
            Console.WriteLine(""); */

            //Övning 3
            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int z = 0;
            for (int x = 0; x < numbArray.Length; x++)
            {
                for (int y = 0; y < numbArray.Length; y++)
                {
                    if (numbArray[x] < numbArray[y])
                    {
                        z = numbArray[x];
                        numbArray[x] = numbArray[y];
                        numbArray[y] = z;
                    }
                    
                }
            }
            foreach (int y in numbArray)
                Console.WriteLine(y);
        }
    }
}
