using System.ComponentModel;

namespace Katas.Tests
{
    public class CSharpTests
    {
        public void TestingTypes()
        {
            var t1 = nameof(Agreement.ID); // "ID"
            var t2 = nameof(Agreement.Surname); // "Surname"

            var t3 = typeof(Agreement); // class => Type (store a lot of info)
            var t4 = typeof(ETest);

            var stop = string.Empty;
        }
    }

    class Agreement
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DisplayName("surname")]
        public string Surname { get; set;}
    }

    enum ETest
    {
        TestOne = 1,
        TestTwo
    }
}