using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class CharClasses
    {
        public List<string> CharacterClasses { get; set; }
        public CharClasses()
        {
            CharacterClasses = new List<string>();
        }
        public bool DoesClassExist(string myclass)
        {
            return CharacterClasses.Contains(myclass);
        }
    }
}
