using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        int temp = 0;
        int count = 1;
         List<int> list = new List<int>(10000000);
        Array.Sort(tangerine);
        
        for(int i = 0; i < tangerine.Length; i++)
        {
            if(temp == tangerine[i])
            {
                count++;
            }
            else
            {
                if(tangerine[i] == 0)
                {
                    continue;
                }
                list.Add(count);
                count = 1;
            }
            temp = tangerine[i];
        }
        list.Add(count);
        list.Sort();
        list.Reverse();
        foreach(int index in list)
        {
            if(k <= 0)
            {
                break;
            }
            answer++;
            k -= index;
        }
        return answer;
    }
}