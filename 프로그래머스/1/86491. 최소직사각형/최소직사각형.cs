using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int maxW = 0;
        int maxH = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            maxW = Math.Max(maxW, Math.Max(sizes[i, 0], sizes[i, 1]));
            maxH = Math.Max(maxH, Math.Min(sizes[i, 0], sizes[i, 1]));
        }
        
       answer = maxW * maxH;
        
        return answer;
    }
}