
using System;

class Character
{
    public string Name;
    public int Health;
    public int Damage;

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(Character target)
    {
        Random random = new Random();
        int damage = Damage;

        if (random.Next(1, 3) == 1)
        {
            damage = Damage * 2;
            Console.WriteLine("KRITISCHER TREFFER!");
        }

        target.Health -= damage;

        Console.WriteLine($"{Name} greift {target.Name} an!");
        Console.WriteLine($"{target.Name} verliert {damage} HP.");
        Console.WriteLine($"{target.Name} hat noch {Math.Max(0, target.Health)} HP.");
    }

    public void Heal()
    {
        Health += 20;

        if (Health > 100)
        {
            Health = 100;
        }

        Console.WriteLine($"{Name} heilt sich um 20 HP.");
        Console.WriteLine($"{Name} hat jetzt {Health} HP.");
    }

    public void SpecialAttack(Character target)
    {
        int damage = 40;
        target.Health -= damage;

        Console.WriteLine($"{Name} verwendet einen Spezialangriff!");
        Console.WriteLine($"{target.Name} verliert {damage} HP.");
        Console.WriteLine($"{target.Name} hat noch {Math.Max(0, target.Health)} HP.");
    }
}
