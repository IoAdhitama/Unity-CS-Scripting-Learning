using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListImplementation : MonoBehaviour
{
    List<Bestiary> bestiary = new List<Bestiary>();

    // Start is called before the first frame update
    void Start()
    {
        bestiary.Add(new Bestiary("Goblin", 10, 10));
        bestiary.Add(new Bestiary("Bandit", 100, 5));
        bestiary.Add(new Bestiary("Mage", 60, 25));

        bestiary.Sort();

        foreach (Bestiary enemy in bestiary)
        {
            print(enemy.name + " - " + (enemy.health + enemy.attack));
        }

        bestiary.Clear();
    }
}
