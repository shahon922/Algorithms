using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] arr = s.Split();
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
                if(j == 0)
                {
                    answer += char.ToUpper(arr[i][j]);
                    continue;
                }             
                if(j % 2 == 0)
                {
                    answer += char.ToUpper(arr[i][j]);
                }
                else
                {
                    answer += char.ToLower(arr[i][j]);
                }
            }
            if(i != arr.Length - 1)
            {
                answer += " ";
            }
        }  
        return answer;
    }
}