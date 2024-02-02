using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>(arr);
        int min = arr.Min();
        
        answer.Remove(min);
        
        if(answer.Count == 0)
        {
            answer.Add(-1);
        }
        
        return answer.ToArray();
    }
}