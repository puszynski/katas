﻿using Katas.Search;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    public class FindMostSimilarWordTest
    {
        [Test]
        public void ExampleOne()
        {
            /// var fruits = new Kata(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            /// fruits.FindMostSimilar("strawbery"); // must return "strawberry"
            /// fruits.FindMostSimilar("berry"); // must return "cherry"
            /// 
            IEnumerable<string> words = new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" };

            var findMostSimilarWord = new FindMostSimilarWord(words);
        }
    }
}
