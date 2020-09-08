using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
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
