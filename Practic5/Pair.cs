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
        public static Pair operator +(Pair firstPair, Pair secondPair)
        {
            Pair result = new Pair();
            result.First = firstPair.First + secondPair.First;
            result.Second = firstPair.Second + secondPair.Second;
            return result;
        }
        public static Pair operator +(Pair firstPair, int number)
        {
            Pair result = new Pair();
            result.First = firstPair.First + number;
            result.Second = firstPair.Second + number;
            return result;
        }
        
        public static Pair operator ++(Pair pair)
        {
            pair.First += 1;
            pair.Second += 1;
            return pair;
        }
        public static Pair operator --(Pair pair)
        {
            pair.First -= 1;
            pair.Second -= 1;
            return pair;
        }
    }
}
