public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> charDic = new Dictionary<char, char>{
            {'}',  '{'},
            {')',  '('},
            {']',  '['},
        };
        Stack<char> charStack = new Stack<char>();

        foreach (var ch in s)
        {
            if (charStack.Count > 0 && charDic.ContainsKey(ch))
            {
                if (charDic[ch] == charStack.Peek())
                {
                    charStack.Pop();
                }
                else
                {
                    return false;
                }

            }
            else
            {
                charStack.Push(ch);
            }
        }
        return charStack.Count == 0;
    }
}