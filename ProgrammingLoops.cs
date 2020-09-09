using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    class ProgrammingLoops
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
