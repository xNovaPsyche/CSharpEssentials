using System;

public class Program
{
    public Weapon goheiStaff;
    public SpellCard weaponSpellCard;
	
	public Hero shrineMaiden;
	public Hero Vampire;
	
    
    public void Main()
    {
        
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
		goheiStaff = new Weapon();
        weaponSpellCard = new SpellCard();

        goheiStaff.bulletCount += 50;
        goheiStaff.firePower += weaponSpellCard.powerLevel;
        Console.WriteLine(goheiStaff.weaponName + " has a bullet count of " + goheiStaff.bulletCount + ".");
        Console.WriteLine("Spellcard magic enhance is now " + goheiStaff.firePower + "!");
		
    }
}
public class Weapon {
    public int bulletCount = 20;
    public string weaponName = "Goddesses Blessing";
    public float firePower = 5.99f;
}
public class SpellCard {
    public float powerLevel = 33.5f;
   }					
public class Heroes
{
	public Hero heroOne;
	
	public void Main()
	{
		heroOne = new Hero();
		
		heroOne.health = 25;
		Console.WriteLine("Reimu's health is " + heroOne.health + ".");

	}
}

public class Hero {
	public int health = 50;
	public int powerLevel = 50;
	public string heroName = "Reimu Harukei";
}