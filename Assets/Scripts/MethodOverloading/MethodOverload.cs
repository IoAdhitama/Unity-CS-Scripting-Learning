// See GameOverload.cs for usage of this class.
// This class is a simple implementation of method overloading.
public class MethodOverload
{
    // The first add method will add up two numbers together
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // The second add method will join two words together
    public string Add(string word1, string word2)
    {
        return word1 + " " + word2;
    }
}