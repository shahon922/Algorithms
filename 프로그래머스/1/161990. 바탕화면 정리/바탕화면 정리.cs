using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[]{int.MaxValue, int.MaxValue, 0, 0};
        
        for(int i = 0; i < wallpaper.Length; i++)
        {
            for(int k = 0; k < wallpaper[i].Length; k++)
            {
                if(wallpaper[i][k] == '#')
                {
                    answer[0] = Math.Min(answer[0], i);
                    answer[1] = Math.Min(answer[1], k);
                    answer[2] = Math.Max(answer[2], i + 1);
                    answer[3] = Math.Max(answer[3], k + 1);
                }
            }
        }
        return answer;
    }
}