using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("Program started.");
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
                logger.Error("Directory not found." + ex.Message);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("File not found.");
                logger.Error("File not found." + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Try/Catch used.");
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
