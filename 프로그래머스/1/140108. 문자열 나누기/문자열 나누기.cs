using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;

    int firstCount = 0;
    int otherCount = 0;
    char first;

    first = s[0];
    int i;

    for (i = 0; i < s.Length - 1; i++)
    {
        if (first == s[i])
        {
            firstCount++;
        }
            
        else  
        {
           otherCount++; 
        }
            
        if (firstCount == otherCount) 
        {
            firstCount = 0;
            otherCount = 0;
            answer++;

            first = s[i + 1]; 
        }
    }
    
    if ((s = s.Substring(i)).Length != 0)
        answer++;

    return answer;
    }
}