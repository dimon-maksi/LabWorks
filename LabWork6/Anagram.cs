using System.Text;

namespace LabWork6;
public class Anagram
{
    public static string Reverse(string sentence)
    {
        string[] substrings = sentence.Split(" ");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < substrings.Length; i++)
        {
            sb.Append(ReverseWord(substrings[i]) + ' ');
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
    public static string ReverseWord(string word)
    {
        char[] arr = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            arr[i] = char.IsLetter(word[i]) ? ' ' : word[i];
        }
        for (int i = 0, j = word.Length - 1; i < word.Length;)
        {
            if (arr[i] == ' ')
            {
                if (char.IsLetter(word[j]))
                {
                    arr[i] = word[j];
                    ++i;
                    --j;
                    continue;
                }
                --j;
                continue;
            }
            ++i;
        }

        return new string(arr);
    }
}
