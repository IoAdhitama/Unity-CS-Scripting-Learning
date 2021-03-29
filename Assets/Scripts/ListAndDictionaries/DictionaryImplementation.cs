using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryImplementation : MonoBehaviour
{
    // Create a dictionary
    Dictionary<int, Bestiary> bestiary = new Dictionary<int, Bestiary>();

    // Start is called before the first frame update
    void Start()
    {
        Bestiary entry1 = new Bestiary("Clara", 60, 15);
        Bestiary entry2 = new Bestiary("April", 80, 12);
        Bestiary entry3 = new Bestiary("Laura", 100, 10);

        // Add variables to dictionary
        bestiary.Add(1, entry1);
        bestiary.Add(2, entry2);
        bestiary.Add(3, entry3);

        // Access the dictionary
        Bestiary currentBoss = bestiary[1];
        print(currentBoss.name + " - " + (currentBoss.health + currentBoss.attack));

        Bestiary temp = null;

        // Try accessing the value in a dictionary
        if(bestiary.TryGetValue(4, out temp))
        {
            // If successful
            print(temp);
        }
        else
        {
            // Failure
            print("Dictionary entry not found.");
        }
    }
}
