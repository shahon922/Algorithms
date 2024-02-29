using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        int k = strings.Length;
        string[] answer = new string[k];

        for(int i = 0; i < k; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        
        Array.Sort(answer);
        
        for(int j = 0; j < k; j++)
        {
            answer[j] = answer[j].Substring(1);
        } 
        
        return answer;
    }
}