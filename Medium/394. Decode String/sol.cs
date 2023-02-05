public class Solution {
    public string DecodeString(string s) {
        var numberStack = new Stack<int>();
        var textStack = new Stack<string>();
        int number = 0;
        var text = new StringBuilder();
        foreach(var c in s)
        {
            if (char.IsDigit(c))
            {
                number *= 10;
                number += c - '0';
                if (number <= 9)
                {
                    textStack.Push(text.ToString());
                    text.Clear();
                }
            }
            else if (c == '[')
            {
                numberStack.Push(number);
                number = 0;
            }
            else if (char.IsLetter(c)) text.Append(c);
            else if (c == ']')
            {
                var repeat = numberStack.Pop();
                var temp = text.ToString();
                for(var i = 1; i < repeat; i++) text.Append(temp);
                if (textStack.Any()) text.Insert(0, textStack.Pop());
            }
        }

        return text.ToString();
    }
}
