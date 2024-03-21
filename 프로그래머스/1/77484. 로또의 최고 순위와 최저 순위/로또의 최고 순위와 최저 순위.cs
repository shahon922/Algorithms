using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2] ;
        
        int zeroCount = 0;
        int sameCount = 0;
        
        foreach(int lotto in lottos)
        {
            if(lotto == 0)
            {
                zeroCount++;
                continue;
            }
            
            foreach(int winNum in win_nums)
            {
                if(lotto == winNum)
                {
                    sameCount++;
                    break;
                }
            }
        }
        
        answer[0] = 7 - (sameCount + zeroCount);
        answer[1] = 7 - sameCount;
        
        if(answer[0] >= 7)
        {
            answer[0] = 6;
        }
        
        if(answer[1] >= 7)
        {
            answer[1] = 6;
        }
        return answer;
    }
}