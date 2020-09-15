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
	
	public class player
	{
		public string Name { get; set; }
		public int atk { get; set; }
		public int hp { get; set; }
		public int str { get; set; }
		public int mgc { get; set; }
		
		public player (string Name, int atk, int hp, int str, int mgc)
		{
			this.Name = Name;
			this.atk = atk;
			this.hp = hp;
			this.str = str;
			this.mgc = mgc;
		}
		
		public int OneHit(int ac)
		{
			return (this.atk + this.str) / ac;
		}
	}
	
	public static void Main()
	{
		player One = new player("Aelien", 15, 22, 16, 8);
		
		Character adv = new Character("Aelien");
		adv.Name = "Eveehi";
		Console.WriteLine(adv.Name);
		adv.Attack();
	}
}
