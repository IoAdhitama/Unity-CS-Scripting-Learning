// See PlayerProperties.cs for details on PlayerProperties class.
// See PropertiesScene scene for usage of this script.
using UnityEngine;
using UnityEngine.UI;

public class GameProperties : MonoBehaviour
{
    public Text health;
    public Text experience;
    public Text level;
    public Text buttonPress;

    PlayerProperties myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = new PlayerProperties();
        myPlayer.Health = 100;

        health.text = "Health: " + myPlayer.Health;
        experience.text = "Experience: " + myPlayer.Experience;
        level.text = "Level: " + myPlayer.Level;
        buttonPress.text = "Button Press Amount: " + myPlayer.ButtonPress;
    }

    // Update is called once per frame
    void Update()
    {
        // Gain experience when V is pressed
        if (Input.GetKeyDown(KeyCode.V))
        {
            myPlayer.Experience += 500;
            experience.text = "Experience: " + myPlayer.Experience;
            level.text = "Level: " + myPlayer.Level;
            IncrementButtonPressAmount();
        }

        // Gain health when H is pressed
        if (Input.GetKeyDown(KeyCode.H))
        {
            myPlayer.Health += 10;
            health.text = "Health: " + myPlayer.Health;
            IncrementButtonPressAmount();
        }

        // Lose health when Z is pressed
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myPlayer.Health -= 10;
            health.text = "Health: " + myPlayer.Health;
            IncrementButtonPressAmount();
        }
    }

    // Increment the amount of times the key is pressed
    void IncrementButtonPressAmount()
    {
        myPlayer.ButtonPress++;
        buttonPress.text = "Button Press Amount: " + myPlayer.ButtonPress;
    }
}
