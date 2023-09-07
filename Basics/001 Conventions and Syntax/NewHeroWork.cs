using System;
					
public class Program
{
	public Hero shrineMaiden;
	public Hero Vampire;
	
	public void Main()
	{
		shrineMaiden = new Hero();
		Vampire = new Hero();
		
		shrineMaiden.health = 30;
		shrineMaiden.powerLevel = 50;
		
		Vampire.health = 150;
		Vampire.powerLevel = 80;
		
		Console.WriteLine("Reimu Harukei has " + shrineMaiden.health + " health.");
		Console.WriteLine("Her shrine maiden strength is " + shrineMaiden.powerLevel + "!");
		
		Console.WriteLine("Remilia Scarlet has " + Vampire.health + " health.");
		Console.WriteLine("Her vampiric strength is " + Vampire.powerLevel + "!");
	}
}

public class Hero {
	public int health = 50;
	public int powerLevel = 50;
	public string heroName = "Reimu Harukei";
}