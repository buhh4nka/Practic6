using System;
using System.Collections.Generic;
using System.Text;

namespace Practic5
{
    class Pair
    {
        
        public Pair()
        {
            First = 0;
            Second = 0;
        }
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        public int First { get; set; }
        public int Second { get; set; }
        public Pair Sum(Pair firstPair, Pair secondPair)
        {
            First = firstPair.First + secondPair.First;
            Second = firstPair.Second + secondPair.Second;
            return new Pair(First, Second);
        }
        public Pair Sum(Pair firstPair, Pair secondPair, Pair thirdPair)
        {
            First = firstPair.First + secondPair.First + thirdPair.First;
            Second = firstPair.Second + secondPair.Second + thirdPair.Second;
            return new Pair(First, Second);
        }
        public Pair Add()
        {
            First += 1;
            Second += 1;
            return  new Pair(First, Second);
        }
        public Pair Add(int number)
        {
            First += number;
            Second += number;
            return new Pair(First, Second);
        }
        public static Pair operator --(Pair pair)
        {
            pair.First -= 1;
            pair.Second -= 1;
            return pair;
        }

        
    }
}
