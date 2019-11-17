using System;
using System.Linq;

namespace Katas.Randomize
{
    //Create random array from 1 to 100
    public class RandomArray1_100
    {
        Random _random;

        public RandomArray1_100()
        {
            _random = new Random();
        }

        public int[] Generate()
        {
            var result = new int[100];

            for (int i = 0; i < result.Length; i++)
            {
                RandomAgain:

                while (result[i] == 0)
                {
                    var tempRandomNum = _random.Next(1, 101);

                    if (result.Any(x => x.Equals(tempRandomNum)))
                        goto RandomAgain;

                    result[i] = tempRandomNum;
                }
            }

            return result;
        }
    }
}
