using Katas.Linq;
using Katas.Randomize;
using Katas.Tests;
using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpTests = new CSharpTests();
            cSharpTests.TestingTypes();

            #region quickTests
            var dog = new Dog();


            if (DateTime.Now > dog.Date)
            {
                var toto = "";
            }

            var result = dog?.IsIt == true ? 111 : 222;  //musi byc == true

            var dog2 = new Dog(2, isIt: true);
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
            public Dog(int i, bool isIt)
            {
                
            }

            public Dog ()
            {
                
            }

            public int MyProperty { get; set; }
            public bool IsIt { get; set; }

            public DateTime? Date { get; set; }            
        }
    }
}
