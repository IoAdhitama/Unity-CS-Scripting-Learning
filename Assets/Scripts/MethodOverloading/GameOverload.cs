// See MethodOverloadScene for usage of this script.
using UnityEngine;
using UnityEngine.UI;

public class GameOverload : MonoBehaviour
{
    private MethodOverload methodOverload;

    private string[] wordList = {"Lorem", "Ipsum", "Dolor", "Sit", "Amet", "Consectetur", "Adipiscing", "Elit", "Hello", "World"};

    public Text addedNumbersText;
    public Text addedStringsText;

    // Start is called before the first frame update
    void Start()
    {
        methodOverload = new MethodOverload();

        addedNumbersText.text = "0 + 0 = 0";
        addedStringsText.text = "Lorem + Ipsum = Lorem Ipsum";
    }

    // Update is called once per frame
    void Update()
    {
        int num1;
        int num2;
        
        // When Z is pressed, generate two random numbers, then add it up
        if (Input.GetKeyDown(KeyCode.Z))
        {
            num1 = Random.Range(1, 100);
            num2 = Random.Range(1, 100);

            int resultNumber = methodOverload.Add(num1, num2);
            addedNumbersText.text = num1 + " + " + num2 + " = " + resultNumber;
        }

        // When M is pressed, pick two random words from the wordList array, then add it up
        if (Input.GetKeyDown(KeyCode.M))
        {
            num1 = Random.Range(0, wordList.Length);
            num2 = Random.Range(0, wordList.Length);

            string resultText = methodOverload.Add(wordList[num1], wordList[num2]);
            addedStringsText.text = wordList[num1] + " + " + wordList[num2] + " = " + resultText;
        }
    }
}
