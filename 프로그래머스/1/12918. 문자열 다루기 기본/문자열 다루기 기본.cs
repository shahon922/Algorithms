using System;
public class Solution {
    public bool solution(string s) {
        int num;
        bool answer = false;
        
        if(s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s, out num);
        }       
        return answer;
    }
}