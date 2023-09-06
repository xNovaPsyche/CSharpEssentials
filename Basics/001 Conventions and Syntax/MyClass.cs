using System;

public class Program
{
    public Weapon goheiStaff;
    public SpellCard weaponSpellCard;
    public Debuff heroDebuff;
    
    public void Main()
    {
        goheiStaff = new Weapon();
        weaponSpellCard = new SpellCard();

        goheiStaff.bulletCount += 50;
        goheiStaff.firePower += weaponSpellCard.powerLevel;
        Console.WriteLine(goheiStaff.weaponName + " has a bullet count of " + goheiStaff.bulletCount + ".");
        Console.WriteLine("Spellcard magic enhance is now " + goheiStaff.firePower + "!");
        goheiStaff.firePower += heroDebuff.powerLevel;
        Console.WriteLine("Player has been weakened " + goheiStaff.firePower + "!");
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
public class Debuff {
    public float powerLevel = -25.5f;
    
}