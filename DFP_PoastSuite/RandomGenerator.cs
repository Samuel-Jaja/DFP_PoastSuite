using System;
using System.Collections.Generic;
using System.Text;

namespace DFP_PoastSuite
{
    class RandomGenerator
    {
       // Instantiate random number generator.
            // It is better to keep a single Random instance 
            // and keep using Next on the same instance.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
