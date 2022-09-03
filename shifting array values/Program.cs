using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifting_array_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Введите число, на которое хотите циклически сместить массив влево");
            int userInput = int.Parse(Console.ReadLine());

            for(int i = 0; i < userInput; i++)
            {
               for(int j= array.Length-2;j>-1;j--)
                {
                    int driver= array[j+1];
                    array[j+1]=array[j];
                    array[j]=driver;
                }               
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
