using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bestiary : IComparable<Bestiary>
{
    public string name;
    public int health;
    public int attack;

    public Bestiary(string newName, int newHealth, int newAttack)
    {
        name = newName;
        health = newHealth;
        attack = newAttack;
    }

    public int CompareTo(Bestiary other)
    {
        if(other == null)
        {
            return 1;
        }

        return (health + attack) - (other.health + other.attack);
    }
}
