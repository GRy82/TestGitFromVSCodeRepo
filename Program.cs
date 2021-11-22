using System;
using System.Collections.Generic;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parameters = new List<int>{ 7, 7, 4, 2, 1 };
            ICodingChallenge codingChallenge = new TaumBday();
            Console.WriteLine(codingChallenge.RunChallenge(parameters));
            Console.ReadKey(true);
        }
    }
}
