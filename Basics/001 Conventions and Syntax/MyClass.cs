using System;

public class Program
{
    public Weapon goheiStaff;
    public SpellCard weaponSpellCard;
    
    public void Main()
    {
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
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 25;
		
		heroTwo.health = 100;
		
		Console.WriteLine(heroOne.health);

		
		Console.WriteLine(heroTwo.health);
	}
}

public class Hero {
	public int health = 25;
	public string heroName = "Reimu Harukei";
}