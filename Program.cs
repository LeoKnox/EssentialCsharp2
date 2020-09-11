using System;
using System.Collections.Generic;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Steak");
            Words.Add("Potato");
            Words.Add("Wine");

            CrazyMath();
        }
        private static int CrazyMath()
        {
            var income = 1000;
            for( var i = 10; i > 0; i--)
            {
                income = income = (income / i); // divides by zero
            }
            return income;
        }
    }
}
