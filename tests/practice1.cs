using System;
					
public class Program
{
	public class Character
	{
		public string Name { get; set; }
		public string Class { get; set; }
		public string Race { get; set; }
		public int Stat1 { get; set; }
		public int Stat2 { get; set; }
		public int Stat3 { get; set; }
		public int Hp { get; set; }
		public int Def { get; set; }
		public int Atk { get; set; }
		
		public Character(string name)
		{
			this.Name = name;
		}
		
		public void Attack()
		{
			Console.WriteLine(this.Name + " attacks");
		}
	}
	public static void Main()
	{
		Character adv = new Character("Aelien");
		adv.Name = "Eveehi";
		Console.WriteLine(adv.Name);
		adv.Attack();
	}
}
