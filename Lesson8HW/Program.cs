using Lesson8HW.Characters;
using Lesson8HW.Enemies;
using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Battle Game!");
        Console.WriteLine("Choose your character:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Wizard");
        Console.WriteLine("3. Hunter");

        Character? player = null;
        string? playerName;

        while (player == null)
        {
            if (int.TryParse(Console.ReadLine(), out int characterChoice) && characterChoice >= 1 && characterChoice <= 3)
            {
                Console.Write("Enter your character's name: ");
                playerName = Console.ReadLine();

                switch (characterChoice)
                {
                    case 1:
                        player = new Warrior(playerName!);
                        break;
                    case 2:
                        player = new Wizard(playerName!);
                        break;
                    case 3:
                        player = new Hunter(playerName!);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid character (1-3).");
            }
        }

        int enemyIndex = 0;
        Enemy[] enemies = { new Goblin(), new Troll(), new Orc() };

        while (true)
        {
            if (player.Health <= 0)
            {
                Console.WriteLine("You have been defeated. Game over!");
                break;
            }

            if (enemyIndex >= enemies.Length)
            {
                Console.WriteLine("Congratulations! You have defeated all enemies.");
                break;
            }

            Enemy currentEnemy = enemies[enemyIndex];

            Console.WriteLine($"You are facing {currentEnemy.Name} ({currentEnemy.Health} HP).");
            Console.WriteLine($"Your HP: {player.Health}");
            Console.WriteLine($"Enemy HP: {currentEnemy.Health}");
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Block");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
            {

                if (choice == 1)
                {
                    Random random = new Random();
                    int enemyChoice = random.Next(1, 3);

                    if (enemyChoice == 1)
                    {
                        Actions.Attack(currentEnemy, player);
                    }

                    else
                    {
                        Actions.Block(currentEnemy);
                    }

                    Actions.Attack(player, currentEnemy);
                }
                else
                {
                    Actions.Block(player);
                    Random random = new Random();
                    int enemyChoice = random.Next(1, 3);
                    if (enemyChoice == 1)
                    {
                        Actions.Attack(currentEnemy, player);
                    }
                    else
                    {
                        Actions.Block(currentEnemy);
                    }
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("You have been defeated. Game over!");
                    break;
                }
                else if (currentEnemy.Health <= 0)
                {
                    Console.WriteLine($"You defeated {currentEnemy.Name}. On to the next enemy!");
                    enemyIndex++;
                }
                player.DontTakeDamage = false;
                currentEnemy.DontTakeDamage = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}