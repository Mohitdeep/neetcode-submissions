public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        Dictionary<char, char> matchingOpener = new() {
            {')', '('}, {'}', '{'}, {']', '['}
        };
        
        foreach (char ch in s) {
            if (ch == '(' || ch == '{' || ch == '[') {
                stack.Push(ch);
            }
            else {

                if(stack.Count==0) return false;

                char last = stack.Pop();
                if(matchingOpener[ch]!= last) return false;
            }
        }
        return stack.Count ==0;
    }
}