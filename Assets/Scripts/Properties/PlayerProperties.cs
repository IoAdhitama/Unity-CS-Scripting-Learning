// See GameProperties.cs for usage of this class.
public class PlayerProperties
{
    // This is a field (member variables)
    private int experience = 0;
    private int health;

    // This is a basic/standard property, showing how much experience point the player have
    public int Experience
    {
        get
        {
            return experience;
        }

        set
        {
            experience = value;
        }
    }

    // Level property: Convert experience points into level (1000xp per level)
    // This property is an example of a read-only property
    public int Level 
    {
        get
        {
            return experience / 1000;
        }
    }

    // Property to manage player's health
    // This property shows that some other lines of codes can be inserted into the get and set method.
    public int Health
    {
        get
        {
            return health;
        }

        // By inserting some if statement, we can restrict the range of the class variable,
        // ensuring that the health will never go down below 0
        set
        {
            if (value < 0)
            {
                health = 0;
            }
            else health = value;
        }
    }

    // An auto-implemented property, used to track how many times a key is pressed
    public int ButtonPress { get; set; }
}
