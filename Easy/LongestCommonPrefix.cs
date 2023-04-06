public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var words = strs.OrderBy(word => word.Length);
        var minWord = words.FirstOrDefault();
        int count = minWord.Length;

        foreach (string word in strs)
        {
            for (int i = 0; i < count; i++)
            {
                if (word[i] != minWord[i])
                {
                    count = i;
                    break;
                }
            }
        }
        if (count == 0) return "";
        return minWord.Substring(0, count);
    }
}