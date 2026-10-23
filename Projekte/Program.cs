
Console.WriteLine("=== BOSSFIGHT ===");
Console.WriteLine("Du betrittst die Arena!");

Character player = new Character("Justin", 100, 20);
Character boss = new Character("Ben", 150, 15);

Console.WriteLine($"Der Boss {boss.Name} erscheint!");

while (player.Health > 0 && boss.Health > 0)
{
    Console.WriteLine("\n--- DEIN ZUG ---");
    Console.WriteLine("1 = Normaler Angriff");
    Console.WriteLine("2 = Spezialangriff (40 Schaden)");
    Console.WriteLine("3 = Heilen (20 HP)");

    Console.Write("Deine Wahl: ");
    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        player.Attack(boss);
    }
    else if (choice == "2")
    {
        player.SpecialAttack(boss);
    }
    else if (choice == "3")
    {
        if (player.Health < 100)
        {
            player.Heal();
        }
        else
        {
            Console.WriteLine("Du hast bereits volle HP!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Ungültige Auswahl!");
        continue;
    }

    if (boss.Health <= 0)
    {
        break;
    }

    Console.WriteLine("\n--- BOSS IST AM ZUG ---");
    boss.Attack(player);

    Console.WriteLine($"\nDeine HP: {Math.Max(0, player.Health)}");
    Console.WriteLine($"Boss HP: {Math.Max(0, boss.Health)}");
}

Console.WriteLine("\n=== KAMPF ENDE ===");

if (player.Health > 0)
{
    Console.WriteLine("Justin hat gewonnen!");
}
else
{
    Console.WriteLine("Ben hat gewonnen!");
}
