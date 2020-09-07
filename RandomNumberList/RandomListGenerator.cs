using System;
using System.Collections.Generic;

namespace RandomNumberList
{
    class RandomListGenerator
    {
        static void Main(string[] args)
        {
            int numberOfItems = 1;
            const int MAXLISTCOUNT = 10000;
            var RandomGeneratorList = new HashSet<int>();

            while(numberOfItems <= MAXLISTCOUNT)
            {
                var random = new Random().Next(1,10001);
                if(!RandomGeneratorList.Contains(random))
                {
                    RandomGeneratorList.Add(random);
                    numberOfItems++;
                }
            }
            numberOfItems = 1;

            foreach(var item in RandomGeneratorList)
            {
                Console.WriteLine($" count : {numberOfItems++} , Value : {item}");
            }
        }
    }
}
