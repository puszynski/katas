using Katas.Linq;
using Katas.Randomize;
using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region quickTests
            var dog = new Dog();
            var result = dog?.IsIt == true ? 111 : 222;  //musi byc == true
            #endregion

            var joinTwoQueries = new JoinTwoQueries();
            var re = joinTwoQueries.LinkData();


            var gac = new GroupAndCount();
            gac.GetData();


            Console.WriteLine("Random array[100] with numbers from 1 to 100:");
            var randomArray1_100 = new RandomArray1_100();
            var result_int_1_100 = randomArray1_100.Generate();

            Console.WriteLine("End");
        }

        class Dog
        {
            public int MyProperty { get; set; }
            public bool IsIt { get; set; }
        }
    }
}
