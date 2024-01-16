using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int i = 1;
        do
        {
            if(i % 2 == 0)
            {
                answer += i;
            }
            i++;
        }
        while(i <= n);
        
        return answer;
    }
}