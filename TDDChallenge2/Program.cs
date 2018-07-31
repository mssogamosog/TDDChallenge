using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 20;

            int[] arrayRandom = new int[20];
            Random randNum = new Random();
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = randNum.Next(Min, Max);
            }

            foreach (int value in arrayRandom)
            {
                Console.WriteLine(value.ToString());
            }
            Console.WriteLine("/////////////////////////////////");
            int[] result = ArraySort.Sort(arrayRandom);
            foreach (int value in result)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
