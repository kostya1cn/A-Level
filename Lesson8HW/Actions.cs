using Lesson8HW.Characters;
using Lesson8HW.Enemies;
using System;

public static class Actions
{
    public static void Attack(Character character, Enemy enemy)
    {
        Console.WriteLine($"{character.Name} attacks {enemy.Name} with {character.Equipment} for {character.Damage} damage.");
        enemy.TakeDamage(character.Damage);
    }

    public static void Attack(Enemy enemy, Character character)
    {
        Console.WriteLine($"{enemy.Name} attacks {character.Name} with equipment for {enemy.Damage} damage.");
        character.TakeDamage(enemy.Damage);
    }

    public static void Block(Character character)
    {
        character.DontTakeDamage = true;
        Console.WriteLine($"{character.Name} raises their {character.Equipment} to block an attack.");
    }

    public static void Block(Enemy enemy)
    {
        enemy.DontTakeDamage = true;
        Console.WriteLine($"{enemy.Name} raises their equipment to block an attack.");
    }
}