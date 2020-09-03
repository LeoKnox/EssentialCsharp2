using System;
					
public class Program
{
	public class Character
	{
		public string Name { get; set; }
	}
	public static void Main()
	{
		Character adv = new Character();
		adv.Name = "Eveehi";
		Console.WriteLine(adv.Name);
	}
}
