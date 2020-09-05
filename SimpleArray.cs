using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    class SimpleArray
    {
        public string[] AdventurerList;

        public SimpleArray()
        {
            AdventurerList = new string[4] { "Eveehi", "Conan", "Elric", "Aelien" };
        }

        public override string ToString()
        {
            return $"There are {AdventurerList.Length} and they are {AdventurerList.ToString()}";
        }
    }
}
