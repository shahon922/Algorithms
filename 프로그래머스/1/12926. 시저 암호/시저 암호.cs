using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] arr = s.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == ' ')
            {
                continue;
            }
            int temp = Convert.ToInt32(arr[i]) + n;
            
            if((arr[i] >= 'A' && arr[i] <= 'Z'))
            {
                if(temp > 'Z')
                {
                    temp -= 26;
                }
            }
            else
            {
                if(temp > 'z')
                {
                    temp -= 26;
                }
            }
            arr[i] = Convert.ToChar(temp);
        }
        answer = new string(arr);
        return answer;
    }
}