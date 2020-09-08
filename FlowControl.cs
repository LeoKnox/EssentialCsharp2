using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public string MagicOrMundane(string charClass)
        {
            var result = "";
            switch(charClass.ToLower())
            {
                case "wizard":
                    result = "Magic";
                    break;
                default:
                    result = "Mundane";
                    break;
            }
            return result;
        }
        public string ClassOrSubclass(string charClass)
        {
            var result = "";
            if (charClass.ToLower() == "Fighter")
            {
                result = "Class";
            }
            else if (charClass.ToLower() == "Rogue")
            {
                result = "Class";
            }
            else if (charClass.ToLower() == "Wizard")
            {
                result = "Class";
            }
            else
            {
                result = "SubClass";
            }
            return result;
        }
        public bool IsClassFighter(string charClass)
        {
            return (charClass.ToLower() == "fighter");
        }
        public bool IsClassRogue(string charClass)
        {
            return (charClass.ToLower() == "rogue") ? true : false;
        }
        public bool IsClassWizard(string charClass)
        {
            if (charClass.ToLower() == "wizard")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
