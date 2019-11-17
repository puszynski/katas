using Katas.Randomize;
using NUnit.Framework;
using System;
using System.Linq;

namespace NUnitTests
{
    public class RandomArray1_100Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckSum()
        {
            var _randomArray = new RandomArray1_100();
            var result = _randomArray.Generate();

            // 1+2+3+...+99+100 = 5050
            var expectedSum = 5050;

            Assert.AreEqual(expectedSum, result.Sum());
        }

        [Test]
        public void CheckIfArrayIsCompleted()
        {
            var _randomArray = new RandomArray1_100();
            var array = _randomArray.Generate();

            foreach (var item in array)
            {
                if (item == 0)
                    throw new NotImplementedException("Non of list elements should be equal to 0");
            }
        }
    }
}