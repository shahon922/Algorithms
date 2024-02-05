using System;
public class Solution {
    public string solution(string s) {
        
        int num2 = (s.Length + 1) % 2;
        
        int num1 = (s.Length / 2) - num2;
        
        return s.Substring(num1, num2 + 1);
    }
}