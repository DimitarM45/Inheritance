using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            int randomIndex = random.Next(0, Count);

            string stringToReturn = this[randomIndex];

            RemoveAt(randomIndex);

            return stringToReturn;
        }
    }
}
