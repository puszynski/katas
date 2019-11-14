using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Search
{
    /// <summary>
    /// https://www.codewars.com/kata/5259510fc76e59579e0009d4/train/csharp
    /// 
    /// var fruits = new Kata(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
    /// fruits.FindMostSimilar("strawbery"); // must return "strawberry"
    /// fruits.FindMostSimilar("berry"); // must return "cherry"
    /// 
    /// things = new Dictionary(new List<string> { "stars", "mars", "wars", "codec", "codewars" });
    /// things.FindMostSimilar("coddwars"); // must return "codewars"
    /// 
    /// languages = new Dictionary(new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" });
    /// languages.FindMostSimilar("heaven"); // must return "java"
    /// languages.FindMostSimilar("javascript"); // must return "javascript" (same words are obviously the most similar ones)
    ///
    /// </summary>
    public class FindMostSimilarWord
    {
        private IEnumerable<string> _words;

        public FindMostSimilarWord(IEnumerable<string> words)
        {
            _words = words;
        }

        public string FindMostSimilar(string searchString)
        {
            var mostSimilarWordPoints = new Dictionary<int, string>();

            foreach (var item in mostSimilarWordPoints)
            {

            }

            return mostSimilarWordPoints.OrderBy(x => x.Key).First().Value;
        }
    }
}
