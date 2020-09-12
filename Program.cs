using System;
using System.Collections.Generic;
using System.IO;

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
        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"c:\temp\Read.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found.");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("File not found.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error" + ex.Message);
            }
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
