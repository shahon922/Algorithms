using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;
        int count = 0;
        
        for(int i = 0; i < targets.Length; i++)
        {
            for(int k = 0; k < targets[i].Length; k++)
            {
                count = press(keymap, targets[i][k]);
                if(count == -1)
                {
                    sum = -1;
                    break;
                }
                sum += count;
            }
            answer[i] = sum;
            sum = 0;
        }
        return answer;
    }
    
    public int press(string[] keymap, char ch)
    {
        int min = -1;
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int k = 0; k < keymap[i].Length; k++)
            {
                if(keymap[i][k] == ch)
                {
                    if(min == -1)
                    {
                        min = k + 1;
                    }
                    else if(min > k)
                    {
                        min = k + 1;
                    }
                    break;
                }
            }
        }
        return min;
    }
}