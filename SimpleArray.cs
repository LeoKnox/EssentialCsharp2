using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] AdventurerList;

        public SimpleArray()
        {
            AdventurerList = new string[4] { "Eveehi", "Conan", "Elric", "Aelien" };
        }

        public void MultiArray()
        {
            var MultiPass = new int[3, 4]
            {
                {0,1,2,3 },
                {4,5,6,7 },
                {8,9,10,11 }
            };
            var CharClasses = new List<string>();
            CharClasses.Add("Fighter");
            CharClasses.Add("Wizard");
            CharClasses.Sort();
        }

        public override string ToString()
        {
            return $"There are {AdventurerList.Length} and they are {AdventurerList.ToString()}";
        }
    }
}
