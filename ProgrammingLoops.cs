using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public int ForEachLoop()
    {
        var numbers = new List<int> { 1, 3, 5, 7, 9 };
        var sum = 0;
        foreach(var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public class ProgrammingLoops
    {
        public void ForLoop()
        {
            int sum = 0;
            for(int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
