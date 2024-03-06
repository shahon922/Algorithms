using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int index = -1;
        for(int i = 0; i < s.Length; i++)
        {
            index = -1;
            for(int k = i - 1; k >= 0; k--)
            {
                if(s[i] == s[k])
                {
                    index = i - k;
                    break;
                }
            }
            answer[i] = index;
        }
        return answer;
    }
}