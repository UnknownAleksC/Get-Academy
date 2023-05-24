using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bossfight;
internal class GameCharacter
{
    internal string Name { get; set; }
    internal int Health { get; set; }
    internal int Strength { get; set; }
    internal int Stamina { get; set; }


    internal GameCharacter(string characterName, int health, int strength, int stamina)
    {
        Name = characterName;
        Health = health;
        Strength = strength;
        Stamina = stamina;
    }
    internal void Recharge(GameCharacter attacker)
    {
        Console.WriteLine($"\r\n{attacker.Name} regained 10 stamina points!");
        attacker.Stamina += 10;
        attacker.Strength = Strength;
    }

    internal void Fight(GameCharacter attacker, GameCharacter defender)
    {
        if (Stamina == 0) attacker.Strength = 0;
        Console.WriteLine($"\r\n{attacker.Name} attacks {defender.Name} for {attacker.Strength}HP");
        defender.Health -= attacker.Strength;
        if (attacker.Stamina > 0) attacker.Stamina -= 10;
    }
}