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
        Console.WriteLine("Players magic enhance is now " + goheiStaff.firePower + "!");
    }
}
public class Weapon {
    public int bulletCount = 20;
    public string weaponName = "Goddesses Blessing";
    public float firePower = 5.99f;
}
public class SpellCard {
    public float powerLevel = 33.5f;
    public class Heroes
{
	public class Program
    {
    public Reimu shrineMaiden;
	public Remilia mistressVampire;
	
	public void Main()
	{
		shrineMaiden = new Reimu();
		mistressVampire = new Remilia();
		
		shrineMaiden.health = 25;
		shrineMaiden.powerLevel = 50;
		
		mistressVampire.health = 100;
		mistressVampire.powerLevel = 80;
		
		Console.WriteLine(shrineMaiden.health);
		Console.WriteLine(shrineMaiden.powerLevel);
		
		Console.WriteLine(mistressVampire.health);
		Console.WriteLine(mistressVampire.powerLevel);
	}
}
}
}
