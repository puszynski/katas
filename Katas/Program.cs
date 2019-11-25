using Katas.Linq;
using Katas.Randomize;
using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            var gac = new GroupAndCount();
            gac.GetData();


            Console.WriteLine("Random array[100] with numbers from 1 to 100:");
            var randomArray1_100 = new RandomArray1_100();
            var result_int_1_100 = randomArray1_100.Generate();

            Console.WriteLine("End");
        }
    }
}
