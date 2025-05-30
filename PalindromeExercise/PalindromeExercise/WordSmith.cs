 namespace PalindromeExercise;

 public class Palindrome
{
    public bool IsAPalindrome(string word)
    {
        string backwards = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            backwards += word[i];
        }

        if (backwards == word)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}