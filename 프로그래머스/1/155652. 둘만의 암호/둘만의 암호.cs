using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char temp;
        
        for(int  i = 0; i < s.Length; i++)
        {
            temp = s[i];
            for(int k = 0; k < index; )
            {
                temp = (char)((int)temp + 1);
                if(temp > 'z')
                {
                    temp = 'a';
                }
                if(skip.Contains(temp) == true)
                {
                    continue;
                }
                k++;
            }
            answer += temp;
        }
        return answer;
    }
}