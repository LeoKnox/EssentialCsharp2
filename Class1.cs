using System;

namespace EssentialTraining
{
    public class Class1
    {
        public int AddTwo(int a, int b)
        {
            var groceryList = new string[4] { "Eveehi", "Elric", "Conan", "Sonya" };
            Array.Resize(ref groceryList, 6);
            groceryList[4] = "Kord";
            groceryList[5] = "Aelien";
            return a + b;
        }
    }
}
